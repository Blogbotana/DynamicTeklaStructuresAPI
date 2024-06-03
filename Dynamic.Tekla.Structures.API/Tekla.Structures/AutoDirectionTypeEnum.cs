using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures;
public enum AutoDirectionTypeEnum
{
    AUTODIR_NA,
    AUTODIR_BASIC,
    AUTODIR_DIAGONAL,
    AUTODIR_SPLICE,
    AUTODIR_DETAIL,
    AUTODIR_GLOBAL_Z,
    AUTODIR_SEATING,
    AUTODIR_PRIMARY_X,
    AUTODIR_FROM_ATTRIBUTE_FILE
}
internal static class AutoDirectionTypeEnum_
{
    public static dynamic GetTSObject(AutoDirectionTypeEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.AutoDirectionTypeEnum").GetType();

        return dynEnum switch
        {
            AutoDirectionTypeEnum.AUTODIR_NA => System.Enum.Parse(tsType, "AUTODIR_NA"),
            AutoDirectionTypeEnum.AUTODIR_BASIC => System.Enum.Parse(tsType, "AUTODIR_BASIC"),
            AutoDirectionTypeEnum.AUTODIR_DIAGONAL => System.Enum.Parse(tsType, "AUTODIR_DIAGONAL"),
            AutoDirectionTypeEnum.AUTODIR_SPLICE => System.Enum.Parse(tsType, "AUTODIR_SPLICE"),
            AutoDirectionTypeEnum.AUTODIR_DETAIL => System.Enum.Parse(tsType, "AUTODIR_DETAIL"),
            AutoDirectionTypeEnum.AUTODIR_GLOBAL_Z => System.Enum.Parse(tsType, "AUTODIR_GLOBAL_Z"),
            AutoDirectionTypeEnum.AUTODIR_SEATING => System.Enum.Parse(tsType, "AUTODIR_SEATING"),
            AutoDirectionTypeEnum.AUTODIR_PRIMARY_X => System.Enum.Parse(tsType, "AUTODIR_PRIMARY_X"),
            AutoDirectionTypeEnum.AUTODIR_FROM_ATTRIBUTE_FILE => System.Enum.Parse(tsType, "AUTODIR_FROM_ATTRIBUTE_FILE"),
            _ => throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented"),
        };
    }

    public static AutoDirectionTypeEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

        if (tsEnumValue.Equals("AUTODIR_NA", System.StringComparison.InvariantCulture))
            return AutoDirectionTypeEnum.AUTODIR_NA;
        else if (tsEnumValue.Equals("AUTODIR_BASIC", System.StringComparison.InvariantCulture))
            return AutoDirectionTypeEnum.AUTODIR_BASIC;
        else if (tsEnumValue.Equals("AUTODIR_DIAGONAL", System.StringComparison.InvariantCulture))
            return AutoDirectionTypeEnum.AUTODIR_DIAGONAL;
        else if (tsEnumValue.Equals("AUTODIR_SPLICE", System.StringComparison.InvariantCulture))
            return AutoDirectionTypeEnum.AUTODIR_SPLICE;
        else if (tsEnumValue.Equals("AUTODIR_DETAIL", System.StringComparison.InvariantCulture))
            return AutoDirectionTypeEnum.AUTODIR_DETAIL;
        else if (tsEnumValue.Equals("AUTODIR_GLOBAL_Z", System.StringComparison.InvariantCulture))
            return AutoDirectionTypeEnum.AUTODIR_GLOBAL_Z;
        else if (tsEnumValue.Equals("AUTODIR_SEATING", System.StringComparison.InvariantCulture))
            return AutoDirectionTypeEnum.AUTODIR_SEATING;
        else if (tsEnumValue.Equals("AUTODIR_PRIMARY_X", System.StringComparison.InvariantCulture))
            return AutoDirectionTypeEnum.AUTODIR_PRIMARY_X;
        else if (tsEnumValue.Equals("AUTODIR_FROM_ATTRIBUTE_FILE", System.StringComparison.InvariantCulture))
            return AutoDirectionTypeEnum.AUTODIR_FROM_ATTRIBUTE_FILE;

        else
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

    }
}

