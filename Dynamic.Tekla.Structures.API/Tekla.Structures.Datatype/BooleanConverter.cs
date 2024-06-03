using System;
using System.ComponentModel;
using System.Globalization;

namespace Dynamic.Tekla.Structures.Datatype;
/// <summary>
/// The BooleanConverter class converts types to and from the boolean type.
/// </summary>
public sealed class BooleanConverter : TypeConverter
{
    /// <summary>
    /// Checks whether the conversion can be made from the source type to the boolean type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="sourceType">The type to convert from.</param>
    /// <returns>True if possible, false if not possible.</returns>
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
        if (!(sourceType == typeof(string)) && !(sourceType == typeof(bool)) && !(sourceType == typeof(int)))
        {
            return base.CanConvertFrom(context, sourceType);
        }
        return true;
    }

    /// <summary>
    /// Checks whether the conversion can be made from the boolean type to the destination type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="destinationType">The type to convert to.</param>
    /// <returns>True if possible, false if not possible.</returns>
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
        if (!(destinationType == typeof(string)) && !(destinationType == typeof(bool)) && !(destinationType == typeof(int)))
        {
            return base.CanConvertTo(context, destinationType);
        }
        return true;
    }

    /// <summary>
    /// Converts an object from the given culture to the boolean type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="culture">The culture.</param>
    /// <param name="value">The object to be converted.</param>
    /// <returns>The new boolean object.</returns>
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
        if (value is string)
        {
            if (bool.TryParse((string)value, out var result))
            {
                return new Boolean(result);
            }
            return default(Boolean);
        }
        if (value is bool)
        {
            return new Boolean((bool)value);
        }
        if (value is int)
        {
            return new Boolean((int)value != 0);
        }
        return base.ConvertFrom(context, culture, value);
    }

    /// <summary>
    /// Converts an object from the boolean type to the given destination type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="culture">The target culture.</param>
    /// <param name="value">The boolean object to be converted.</param>
    /// <param name="destinationType">The destination type.</param>
    /// <returns>The given boolean object converted to the new type.</returns>
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
        if (destinationType == typeof(string))
        {
            return ((Boolean)value).Value.ToString(CultureInfo.InvariantCulture);
        }
        if (destinationType == typeof(bool))
        {
            return ((Boolean)value).Value;
        }
        if (destinationType == typeof(int))
        {
            return ((Boolean)value).Value ? 1 : 0;
        }
        return base.ConvertTo(context, culture, value, destinationType);
    }
}
