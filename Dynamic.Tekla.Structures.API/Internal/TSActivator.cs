﻿using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Linq;
using System.Reflection;

namespace Dynamic.Tekla.Structures.Internal;

internal static class TSActivator
{
    /// <summary>Creates instance of type with typeName. TypeName should be c# full name like: Tekla.Structures.Model.Beam.BeamTypeEnum</summary>
    /// <exception cref="DynamicAPINotFoundException">If could not find type</exception>
    /// <exception cref="DynamicAPIException">If Tekla is not running or unknown internal error</exception> 
    public static dynamic CreateInstance(string typeName)
    {
        var type = GetTypeFromTypeName(typeName);
        return Activator.CreateInstance(type);
    }

    /// <summary>Creates instance of type with typeName. TypeName should be c# full name like: Tekla.Structures.Model.Beam.BeamTypeEnum</summary>
    /// <param name="args">Constructor parameters</param>
    /// <exception cref="DynamicAPINotFoundException">If could not find type</exception>
    /// <exception cref="DynamicAPIException">If Tekla is not running or unknown internal error</exception> 
    public static dynamic CreateInstance(string typeName, object[] args)
    {
        var convertedArgs = ConvertParameters(args);
        var type = GetTypeFromTypeName(typeName);
        return Activator.CreateInstance(type, args);
    }

    private static object[] ConvertParameters(object[] input)
    {
        if (input.Length.Equals(0)) return new object[0];

        var output = new object[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            output[i] = ConvertParameter(input[i]);
        }

        return output;
    }

    private static object ConvertParameter(object input)
    {
        if(input is null)
            return null;

        var type = input.GetType();
        var typeFullName = type.ToString();
        object converted = null;

        if (typeFullName.StartsWith("Dynamic.Tekla.Structures.", StringComparison.InvariantCulture))
        {
            string converterName = string.Empty;

            if (typeFullName.EndsWith("[]", StringComparison.InvariantCulture))
            {
                throw new NotImplementedException("typeFullName.EndsWith(\"[]\"");//  converterName = typeFullName.Substring(0, typeFullName.Length - 2) + "Array_";
            }
            else
            {
                converterName = typeFullName + "_";
            }

            var converterType = Assembly.GetExecutingAssembly().GetType(converterName);
            var parameters = new object[] { input };
            var fromTSObjectMethod = GetMethod("GetTSObject", parameters, converterType);

            converted = fromTSObjectMethod.Invoke(null, parameters);
        }
        else if (typeFullName.StartsWith("System.Collections.ArrayList", StringComparison.InvariantCulture))
            converted = ArrayListConverter.ToTSObjects((System.Collections.ArrayList)input);
        else if (typeFullName.StartsWith("System.Collections.Generic.List<", StringComparison.InvariantCulture))
            converted = ListConverter.ToTSObjects(input);
        else if (typeFullName.StartsWith("System.Type", StringComparison.InvariantCulture))
            converted = TypeConverter.ToTSObjects((Type)input);
        else if (typeFullName.StartsWith("System.Nullable<", StringComparison.InvariantCulture))
            converted = NullableConverter.ToTSObjects((Type)input);
        else if (typeFullName.StartsWith("System.Collections.Generic.IEnumerable<", StringComparison.InvariantCulture))
            converted = IEnumerableConverter.ToTSObjects((Type)input);
        else
        {
            return input;
        }

        return converted;
    }

    /// <summary>Gets the method from the type</summary>
    /// <exception cref="DynamicAPINotFoundException">If could not find metod</exception>
    public static MethodInfo GetMethod(string methodName, object[] parameters, Type type)
    {
        var methods = type.GetMethods()
            .Where(m => m.Name.Equals(methodName, StringComparison.InvariantCulture)
            && m.GetParameters().Length.Equals(parameters.Length)
            ).ToList();
        int count = methods.Count;

        if (count.Equals(1))
        {
            return methods[0];
        }
        else
        {
            foreach (var method in methods)
            {
                bool parametersMath = true;

                int i = 0;
                var methodParameters = method.GetParameters();
                foreach (var parameter in methodParameters)
                {
                    var parametrFromI = parameters[i] is null ? new object() : parameters[i];
                    if (!(parameter.ParameterType.Equals(parameters[i].GetType())
                        || parameter.ParameterType.Equals(parameters[i].GetType().MakeByRefType())))
                    {
                        parametersMath = false;
                        break;
                    }
                    i++;
                }

                if (parametersMath) return method;
            }
        }

        throw new DynamicAPINotFoundException("Could not find method " + methodName + " in type " + type.Name);
    }


    /// <summary>Finds type from loaded Tekla API assemblies</summary>
    /// <exception cref="DynamicAPINotFoundException">If could not find type</exception>
    /// <exception cref="DynamicAPIException">If Tekla is not running or unknown internal error</exception>
    public static Type GetTypeFromTypeName(string typeName)
    {
        if (TeklaProcess.IsTeklaRunning())
        {
            if (TeklaProcess.APIAssemblies.ContainsKey(typeName))
            {
                var assembly = TeklaProcess.APIAssemblies[typeName];
                var tsAPITypes = assembly;
                var type = tsAPITypes.GetType(typeName);

                if (type != null) return type;

                type = TryGetNestedType(typeName, ref assembly);
                if (type != null) return type;

                throw new DynamicAPIException("Unknown error. Type is null in GetTypeFromTypeName() method. Type name: " + typeName);
            }
            else
            {
                throw new DynamicAPINotFoundException("Could not find type " + typeName + " in Tekla API assemblies");
            }
        }

        throw new DynamicAPITeklaNotRunningException();
    }

    private static Type TryGetNestedType(string typeName, ref Assembly assembly)
    {
        if (typeName.Contains('.'))
        {
            string output = string.Copy(typeName);
            var lastDotPosition = typeName.LastIndexOf('.');
            output = typeName.Insert(lastDotPosition, "+");
            output = output.Remove(lastDotPosition + 1, 1);

            var type = assembly.GetType(output);

            if (type != null)
                return type;
            else
                return TryGetNestedType(output, ref assembly);
        }
        else return assembly.GetType(typeName);
    }

}
