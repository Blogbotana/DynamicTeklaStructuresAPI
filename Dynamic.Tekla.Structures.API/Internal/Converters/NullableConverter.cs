using System;
using System.Reflection;

namespace Dynamic.Tekla.Structures.Internal.Converters;

internal static class NullableConverter
{
    public static dynamic ToTSObjects(dynamic input)
    {
        dynamic inputGenericType = input.GetValueOrDefault().GetType();

        if (inputGenericType.ToString().StartsWith("Dynamic.Tekla.Structures.", StringComparison.InvariantCulture))
        {
            dynamic hasValue = input.HasValue;
            dynamic value = input.GetValueOrDefault();

            Type convertedNullableType = typeof(System.Nullable<>);
            convertedNullableType = convertedNullableType.MakeGenericType(TypeConverter.ToTSObjects(inputGenericType));
            _ = Activator.CreateInstance(convertedNullableType);
            dynamic convertedNullableObject;
            if (hasValue)
            {
                Assembly assembly = Assembly.GetExecutingAssembly();

                string converterName = inputGenericType.ToString() + "_";
                Type converterType = assembly.GetType(converterName);
                object[] parameters = new object[] { value };
                MethodInfo getTSObjectMethod = TSActivator.GetMethod("GetTSObject", parameters, converterType);

                convertedNullableObject = getTSObjectMethod.Invoke(null, parameters);
                return convertedNullableObject;
            }
            else
            {
                convertedNullableObject = null;
                return convertedNullableObject;
            }
        }
        else return input;
    }

    public static dynamic FromTSObject<T>(dynamic input) where T : struct
    {
        dynamic inputGenericType = input.GetValueOrDefault().GetType();

        if (inputGenericType.ToString().StartsWith("Tekla.Structures.", StringComparison.InvariantCulture))
        {
            dynamic hasValue = input.HasValue;
            dynamic value = input.GetValueOrDefault();
            _ = new System.Nullable<T>();
            T? convertedNullableObject;
            if (hasValue)
            {
                Assembly assembly = Assembly.GetExecutingAssembly();

                string converterName = "Dynamic." + inputGenericType.ToString() + "_";
                Type converterType = assembly.GetType(converterName);
                object[] parameters = new object[] { value };
                MethodInfo getTSObjectMethod = TSActivator.GetMethod("GetTSObject", parameters, converterType);

                convertedNullableObject = (System.Nullable<T>)getTSObjectMethod.Invoke(null, parameters);
                return convertedNullableObject;
            }
            else
            {
                convertedNullableObject = null;
                return convertedNullableObject;
            }
        }
        return input;
    }
}
