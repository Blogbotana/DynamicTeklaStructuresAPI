using Dynamic.Tekla.Structures.Internal.Exceptions;
using System.Reflection;
using System;

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

    /// <summary>Gets the value of an instance property or field from the object</summary>
    /// <exception cref="DynamicAPINotFoundException">If could not find the field or property</exception>
    public static object GetInstancePropertyOrFieldValue(object instance, string fieldOrPropertyName)
    {
        if (instance == null)
        {
            throw new ArgumentNullException(nameof(instance));
        }

        System.Type type = instance.GetType();
        System.Reflection.FieldInfo fieldInfo = type.GetField(fieldOrPropertyName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
        if (fieldInfo != null)
        {
            object result = fieldInfo.GetValue(instance);
            return result is null ? null : result;
        }

        System.Reflection.PropertyInfo propertyInfo = type.GetProperty(fieldOrPropertyName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
        if (propertyInfo != null)
        {
            object result = propertyInfo.GetValue(instance);
            return result is null ? null : result;
        }

        throw new DynamicAPINotFoundException("Could not find instance property or field " + fieldOrPropertyName + " in type " + type.Name);
    }
    /// <summary>
    /// Sets the value of an instance property or field on the object.
    /// </summary>
    /// <exception cref="DynamicAPINotFoundException">If could not find the field or property</exception>
    public static void SetInstancePropertyOrFieldValue(object instance, string fieldOrPropertyName, object value)
    {
        if (instance == null)
        {
            throw new ArgumentNullException(nameof(instance));
        }

        System.Type type = instance.GetType();
        System.Reflection.FieldInfo fieldInfo = type.GetField(fieldOrPropertyName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
        if (fieldInfo != null)
        {
            fieldInfo.SetValue(instance, value);
            return;
        }

        System.Reflection.PropertyInfo propertyInfo = type.GetProperty(fieldOrPropertyName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
        if (propertyInfo != null)
        {
            propertyInfo.SetValue(instance, value);
            return;
        }

        throw new DynamicAPINotFoundException("Could not find instance property or field " + fieldOrPropertyName + " in type " + type.Name);
    }
}
