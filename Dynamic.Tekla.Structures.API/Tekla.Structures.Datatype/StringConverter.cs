using System;
using System.ComponentModel;
using System.Globalization;

namespace Dynamic.Tekla.Structures.Datatype;
/// <summary>
/// The StringConverter class converts types to and from the string datatype.
/// </summary>
public class StringConverter : TypeConverter
{
    /// <summary>
    /// Checks whether the conversion can be made from the source type to the string datatype.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="sourceType">The type to convert from.</param>
    /// <returns>True if possible, false if not possible.</returns>
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
        if (!(sourceType == typeof(string)))
        {
            return base.CanConvertFrom(context, sourceType);
        }
        return true;
    }

    /// <summary>
    /// Checks whether the conversion can be made from the string datatype to the destination type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="destinationType">The type to convert to.</param>
    /// <returns>True if possible, false if not possible.</returns>
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
        if (!(destinationType == typeof(string)))
        {
            return base.CanConvertTo(context, destinationType);
        }
        return true;
    }

    /// <summary>
    /// Converts an object from the given culture to the Tekla.Structures.Datatype.String type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="culture">The culture.</param>
    /// <param name="value">The object to be converted.</param>
    /// <returns>The new string datatype object.</returns>
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
        if (value is string)
        {
            return new String((string)value);
        }
        return base.ConvertFrom(context, culture, value);
    }

    /// <summary>
    /// Converts an object from the string datatype to the given destination type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="culture">The target culture.</param>
    /// <param name="value">The string datatype object to be converted.</param>
    /// <param name="destinationType">The destination type.</param>
    /// <returns>The given string datatype object converted to the new type.</returns>
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
        if (destinationType == typeof(string))
        {
            return ((String)value).ToString();
        }
        return base.ConvertTo(context, culture, value, destinationType);
    }
}

