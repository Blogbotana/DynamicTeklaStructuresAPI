using System;
using System.ComponentModel;
using System.Globalization;

namespace Dynamic.Tekla.Structures.Datatype;
/// <summary>
/// The DistanceConverter class converts types to and from the distance type.
/// </summary>
public sealed class DistanceConverter : TypeConverter
{
    /// <summary>
    /// Checks whether the conversion can be made from the source type to the distance type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="sourceType">The type to convert from.</param>
    /// <returns>True if possible, false if not possible.</returns>
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
        if (!(sourceType == typeof(string)) && !(sourceType == typeof(double)))
        {
            return base.CanConvertFrom(context, sourceType);
        }
        return true;
    }

    /// <summary>
    /// Checks whether the conversion can be made from the distance type to the destination type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="destinationType">The type to convert to.</param>
    /// <returns>True if possible, false if not possible.</returns>
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
        if (!(destinationType == typeof(string)) && !(destinationType == typeof(double)))
        {
            return base.CanConvertTo(context, destinationType);
        }
        return true;
    }

    /// <summary>
    /// Converts an object from the given culture to the distance type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="culture">The culture.</param>
    /// <param name="value">The object to be converted.</param>
    /// <returns>The new distance object.</returns>
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
        if (value is string)
        {
            return Distance.Parse((string)value, CultureInfo.InvariantCulture);
        }
        if (value is double)
        {
            return new Distance((double)value);
        }
        return base.ConvertFrom(context, culture, value);
    }

    /// <summary>
    /// Converts an object from the distance type to the given destination type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="culture">The target culture.</param>
    /// <param name="value">The distance object to be converted.</param>
    /// <param name="destinationType">The destination type.</param>
    /// <returns>The given distance object converted to the new type.</returns>
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
        if (destinationType == typeof(string))
        {
            return ((Distance)value).ToString(CultureInfo.InvariantCulture);
        }
        if (destinationType == typeof(double))
        {
            return ((Distance)value).Millimeters;
        }
        return base.ConvertTo(context, culture, value, destinationType);
    }
}
