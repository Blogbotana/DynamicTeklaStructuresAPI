using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures;
/// <summary> The type of property: int/double/string.</summary>
public enum PropertyTypeEnum
{
    /// <summary>
    /// The integer property type.
    /// </summary>
    TYPE_INT,
    /// <summary>
    /// The double property type.
    /// </summary>
    TYPE_DOUBLE,
    /// <summary>
    /// The string property type.
    /// </summary>
    TYPE_STRING
}
internal static class PropertyTypeEnum_
{
    public static dynamic GetTSObject(PropertyTypeEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.PropertyTypeEnum").GetType();

        switch (dynEnum)
        {
            case PropertyTypeEnum.TYPE_INT:
                return System.Enum.Parse(tsType, "TYPE_INT");
            case PropertyTypeEnum.TYPE_DOUBLE:
                return System.Enum.Parse(tsType, "TYPE_DOUBLE");
            case PropertyTypeEnum.TYPE_STRING:
                return System.Enum.Parse(tsType, "TYPE_STRING");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static PropertyTypeEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

        if (tsEnumValue.Equals("TYPE_INT", System.StringComparison.InvariantCulture))
            return PropertyTypeEnum.TYPE_INT;
        else if (tsEnumValue.Equals("TYPE_DOUBLE", System.StringComparison.InvariantCulture))
            return PropertyTypeEnum.TYPE_DOUBLE;
        else if (tsEnumValue.Equals("TYPE_STRING", System.StringComparison.InvariantCulture))
            return PropertyTypeEnum.TYPE_STRING;

        else
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

    }
}

