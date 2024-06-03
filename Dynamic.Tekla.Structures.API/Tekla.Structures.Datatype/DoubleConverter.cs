using System;
using System.ComponentModel;
using System.Globalization;

namespace Dynamic.Tekla.Structures.Datatype;
public class DoubleConverter : TypeConverter
{
    /// <summary>
    /// Checks whether the conversion can be made from the source type to the double datatype.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="sourceType">The type to convert from.</param>
    /// <returns>True if possible, false if not possible.</returns>
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
        bool result = false;
        if (sourceType == typeof(string) || sourceType == typeof(double) || base.CanConvertFrom(context, sourceType))
        {
            result = true;
        }
        return result;
    }

    /// <summary>
    /// Checks whether the conversion can be made from the double datatype to the destination type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="destinationType">The type to convert to.</param>
    /// <returns>True if possible, false if not possible.</returns>
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
        bool result = false;
        if (destinationType == typeof(string) || destinationType == typeof(double) || base.CanConvertTo(context, destinationType))
        {
            result = true;
        }
        return result;
    }

    /// <summary>
    /// Converts an object from the given culture to the Tekla.Structures.Datatype.Double type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="culture">The culture.</param>
    /// <param name="value">The object to be converted.</param>
    /// <returns>The new double datatype object.</returns>
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
        if (value is string)
        {
            double result;
            if (value is string text && text.Equals(string.Empty))
            {
                result = -2147483648.0;
            }
            else if (!double.TryParse((string)value, NumberStyles.Float, CultureInfo.InvariantCulture.NumberFormat, out result))
            {
                throw new FormatException();
            }
            return new Double(result);
        }
        return value is double ? new Double((double)value) : base.ConvertFrom(context, culture, value);
    }

    /// <summary>
    /// Converts an object from the double datatype to the given destination type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="culture">The target culture.</param>
    /// <param name="value">The double datatype object to be converted.</param>
    /// <param name="destinationType">The destination type.</param>
    /// <returns>The given double datatype object converted to the new type.</returns>
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
        if (destinationType == typeof(string))
        {
            return ((Double)value).ToString();
        }
        return destinationType == typeof(double)
            ? ((Double)value).Value
            : base.ConvertTo(context, culture, value, destinationType);
    }
}
