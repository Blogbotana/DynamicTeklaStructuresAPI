using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Dynamic.Tekla.Structures.Internal.Converters;

public static class ListConverter
{
    public static List<dynamic> ToTSObjects(dynamic dynAPIObjects)
    {
        try
        {
            if (dynAPIObjects.Count.Equals(0))
                return new List<dynamic>();

            List<dynamic> output = new(dynAPIObjects.Count + 1);
            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (dynamic dynObject in dynAPIObjects)
            {
                if (dynObject.GetType().ToString().StartsWith("Dynamic.Tekla.Structures.", StringComparison.InvariantCulture))
                {
                    string converterName = dynObject.GetType().ToString() + "_";
                    Type converterType = assembly.GetType(converterName);
                    object[] parameters = new object[] { dynObject };
                    MethodInfo fromTSObjectMethod = TSActivator.GetMethod("GetTSObject", parameters, converterType);

                    output.Add(fromTSObjectMethod.Invoke(null, parameters));
                }
                else
                {
                    output.Add(dynObject);
                }
            }

            return output;
        }
        catch (Exception ex)
        {
            throw new DynamicAPIException("Error in method ListConverter.ToTSObjects() Input type: "
                + dynAPIObjects.GetType().ToString() + "\n Internal error message: " + ex.Message, ex);
        }
    }

    public static List<T> FromTSObjects<T>(dynamic tsObjects)
    {
        try
        {
            if (tsObjects.Count.Equals(0))
                return new List<T>();

            List<T> output = new(tsObjects.Count + 1);
            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (dynamic tsObject in tsObjects)
            {
                if (tsObject.GetType().ToString().StartsWith("Tekla.Structures.", StringComparison.InvariantCulture))
                {
                    string converterName = "Dynamic." + tsObject.GetType().ToString() + "_";
                    Type converterType = assembly.GetType(converterName);
                    object[] parameters = new object[] { tsObject };
                    MethodInfo fromTSObjectMethod = TSActivator.GetMethod("FromTSObject", parameters, converterType);

                    output.Add((T)fromTSObjectMethod.Invoke(null, parameters));
                }
                else
                {
                    output.Add((T)tsObject);
                }
            }
            return output;
        }
        catch (Exception ex)
        {
            throw new DynamicAPIException("Error in method ListConverter.FromTSObjects() Input type: "
                               + tsObjects.GetType().ToString() + "Generic type: " + nameof(T)
                               + " \n Internal error message: " + ex.Message, ex);
        }
    }
}

