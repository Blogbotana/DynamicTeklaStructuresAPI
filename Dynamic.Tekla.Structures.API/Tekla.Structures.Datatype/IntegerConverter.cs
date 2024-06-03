using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Datatype;
/// <summary>
/// The IntegerConverter class converts types to and from the integer datatype.
/// </summary>
public class IntegerConverter : TypeConverter
{
    /// <summary>
    /// Checks whether the conversion can be made from the source type to the integer datatype.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="sourceType">The type to convert from.</param>
    /// <returns>True if possible, false if not possible.</returns>
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
        bool result = false;
        if (sourceType == typeof(string) || sourceType == typeof(int) || sourceType == typeof(bool) || base.CanConvertFrom(context, sourceType))
        {
            result = true;
        }
        return result;
    }

    /// <summary>
    /// Checks whether the conversion can be made from the integer datatype to the destination type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="destinationType">The type to convert to.</param>
    /// <returns>True if possible, false if not possible.</returns>
    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
        bool result = false;
        if (destinationType == typeof(string) || destinationType == typeof(int) || destinationType == typeof(bool) || base.CanConvertTo(context, destinationType))
        {
            result = true;
        }
        return result;
    }

    /// <summary>
    /// Converts an object from the given culture to the Tekla.Structures.Datatype.Integer type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="culture">The culture.</param>
    /// <param name="value">The object to be converted.</param>
    /// <returns>The new integer datatype object.</returns>
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
        if (value is string)
        {
            string text = value as string;
            int result;
            if (text != null && text.Equals(string.Empty))
            {
                result = int.MinValue;
            }
            else if (!int.TryParse((string)value, out result))
            {
                result = 0;
            }
            return new Integer(result);
        }
        if (value is int)
        {
            return new Integer((int)value);
        }
        if (value is bool)
        {
            if (!(bool)value)
            {
                return new Integer(0);
            }
            return new Integer(1);
        }
        return base.ConvertFrom(context, culture, value);
    }

    /// <summary>
    /// Converts an object from the the integer datatype to the given destination type.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <param name="culture">The target culture.</param>
    /// <param name="value">The integer datatype object to be converted.</param>
    /// <param name="destinationType">The destination type.</param>
    /// <returns>The given integer datatype object converted to the new type.</returns>
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
        if (destinationType == typeof(string))
        {
            return ((Integer)value).ToString();
        }
        if (destinationType == typeof(int))
        {
            return ((Integer)value).Value;
        }
        if (destinationType == typeof(bool))
        {
            if (((Integer)value).Value == 0)
            {
                return false;
            }
            return true;
        }
        return base.ConvertTo(context, culture, value, destinationType);
    }
}
