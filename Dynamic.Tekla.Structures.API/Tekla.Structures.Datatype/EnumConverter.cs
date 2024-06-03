using System;
using System.ComponentModel;
using System.Globalization;

namespace Dynamic.Tekla.Structures.Datatype;
/// <summary>Type converter for <see cref="T:System.Enum" /></summary>
public class EnumConverter : TypeConverter
{
    /// <inheritdocs />
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
        if (!(sourceType != null) || !sourceType.IsEnum)
        {
            return base.CanConvertFrom(context, sourceType);
        }
        return true;
    }

    /// <inheritdocs />
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
        if (!(destinationType != null) || !destinationType.IsEnum)
        {
            return base.CanConvertTo(context, destinationType);
        }
        return true;
    }

    /// <inheritdocs />
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value");
        }
        Type type = value.GetType();
        if (!type.IsEnum)
        {
            return base.ConvertFrom(context, culture, value);
        }
        Type type2 = typeof(Enum<>).MakeGenericType(type);
        object obj = Activator.CreateInstance(type2);
        type2.GetProperty("Value").SetValue(obj, value, null);
        return obj;
    }

    /// <inheritdocs />
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value");
        }
        Type type = value.GetType();
        if (!type.IsGenericType || type.GetGenericTypeDefinition() != typeof(Enum<>) || type.GetGenericArguments()[0] != destinationType)
        {
            return base.ConvertTo(context, culture, value, destinationType);
        }
        return type.GetProperty("Value").GetValue(value, null);
    }
}
