using System;
using System.ComponentModel;
using System.Globalization;

namespace Dynamic.Tekla.Structures.Datatype;
/// <summary>
/// The DistanceListConverter class converts types to and from the distance list type.
/// </summary>
public sealed class DistanceListConverter : TypeConverter
{
    /// <summary>
    /// Checks whether the conversion can be made from the source type to the distance list type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="sourceType">The type to convert from.</param>
    /// <returns>True if possible, false if not possible.</returns>
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
        if (!(sourceType == typeof(string)) && !(sourceType == typeof(double[])))
        {
            return base.CanConvertFrom(context, sourceType);
        }
        return true;
    }

    /// <summary>
    /// Checks whether the conversion can be made from the distance list type to the destination type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="destinationType">The type to convert to.</param>
    /// <returns>True if possible, false if not possible.</returns>
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
        if (!(destinationType == typeof(string)) && !(destinationType == typeof(double[])))
        {
            return base.CanConvertTo(context, destinationType);
        }
        return true;
    }

    /// <summary>
    /// Converts an object from the given culture to the distance list type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="culture">The culture.</param>
    /// <param name="value">The object to be converted.</param>
    /// <returns>The new distance object.</returns>
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
        if (value is string)
        {
            return DistanceList.Parse((string)value, CultureInfo.InvariantCulture);
        }
        if (value is double[])
        {
            return new DistanceList(Array.ConvertAll((double[])value, (double doubleValue) => new Distance(doubleValue)));
        }
        return base.ConvertFrom(context, culture, value);
    }

    /// <summary>
    /// Converts an object from the distance list type to the given destination type.
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
            return ((DistanceList)value).ToString(null, CultureInfo.InvariantCulture);
        }
        if (destinationType == typeof(double[]))
        {
            return Array.ConvertAll(((DistanceList)value).ToArray(), (Distance distanceValue) => distanceValue.Millimeters);
        }
        return base.ConvertTo(context, culture, value, destinationType);
    }
}
