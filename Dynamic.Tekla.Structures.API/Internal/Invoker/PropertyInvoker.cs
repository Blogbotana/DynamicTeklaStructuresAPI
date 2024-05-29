using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Internal.Invoker;

internal static class PropertyInvoker
{
    /// <summary>Gets the method from the type</summary>
    /// <exception cref="DynamicAPINotFoundException">If could not find metod</exception>
    public static object GetStaticPropertyOrFieldValue(string typeName, string fieldOrPropertyName)
    {
        System.Type type = TSActivator.GetTypeFromTypeName(typeName);
        System.Reflection.FieldInfo fieldInfo = type.GetField(fieldOrPropertyName);
        if (fieldInfo != null)
        {
            object result = fieldInfo.GetValue(null);
            return result is null ? null : result;
        }

        System.Reflection.PropertyInfo propertyInfo = type.GetProperty(fieldOrPropertyName);
        if (propertyInfo != null)
        {
            object result = propertyInfo.GetValue(null);
            return result is null ? null : result;
        }

        throw new DynamicAPINotFoundException("Could not find static property or field " + fieldOrPropertyName + " in type " + typeName);
    }

    ///<summary>Sets value of static field or property in type with typeName</summary>
    /// <exception cref="DynamicAPINotFoundException">If could not find type</exception>
    public static void SetStaticPropertyOrFieldValue(string typeName, string fieldOrPropertyName, object value)
    {
        System.Type type = TSActivator.GetTypeFromTypeName(typeName);
        System.Reflection.FieldInfo fieldInfo = type.GetField(fieldOrPropertyName);

        if (fieldInfo != null)
        {
            fieldInfo.SetValue(null, value);
            return;
        }

        System.Reflection.PropertyInfo propertyInfo = type.GetProperty(fieldOrPropertyName);
        if (propertyInfo != null)
        {
            propertyInfo.SetValue(null, value);
            return;
        }

        throw new DynamicAPINotFoundException("Could not find static property or field " + fieldOrPropertyName + " in type " + typeName);
    }

}
