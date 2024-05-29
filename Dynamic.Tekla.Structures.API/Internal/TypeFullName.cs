using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dynamic.Tekla.Structures.Internal
{
    internal static class TypeFullName
    {
        private static bool IsTeklaType(Type type)
        {
            return type.FullName?.StartsWith("Tekla.Structures") ?? false;
        }
        public static string GetTypeFullName_WithDynamic(Type type)
        {
            var result = GetTypeFullName(type);
            result = result.Replace("Tekla.Structures.", "Dynamic.Tekla.Structures.");
            return result;
        }

        public static string GetTypeFullName(Type type)
        {
            if (type.IsByRef)
                type = type.GetElementType();

            var result = GetCSharpRepresentation(type, true);
            return result;
        }

        private static string FullName(Type type)
        {
            var result = type.Name;

            var currentType = type;
            while (currentType.DeclaringType != null)
            {
                currentType = currentType.DeclaringType;
                result = currentType.Name + "." + result;
            }

            result = type.Namespace + "." + result;
            result = result.Replace("&", "");
            return result;
        }
        private static string GetCSharpRepresentation(Type t, bool trimArgCount)
        {
            if (t.IsGenericType)
            {
                var genericArgs = t.GetGenericArguments().ToList();

                return GetCSharpRepresentation(t, trimArgCount, genericArgs);
            }
            return FullName(t);
        }
        private static string GetCSharpRepresentation(Type t, bool trimArgCount, List<Type> availableArguments)
        {
            if (t.IsGenericType)
            {
                string value = FullName(t);
                if (trimArgCount && value.IndexOf("`") > -1)
                {
                    value = value.Substring(0, value.IndexOf("`"));
                }

                if (t.DeclaringType != null)
                {
                    // This is a nested type, build the nesting type first
                    value = GetCSharpRepresentation(t.DeclaringType, trimArgCount, availableArguments) + "+" + value;
                }

                // Build the type arguments (if any)
                string argString = "";
                var thisTypeArgs = t.GetGenericArguments();
                for (int i = 0; i < thisTypeArgs.Length && availableArguments.Count > 0; i++)
                {
                    if (i != 0) argString += ", ";

                    argString += GetCSharpRepresentation(availableArguments[0], trimArgCount);
                    availableArguments.RemoveAt(0);
                }

                // If there are type arguments, add them with < >
                if (argString.Length > 0)
                {
                    value += "<" + argString + ">";
                }

                return value;
            }

            return FullName(t);
        }
    }
}
