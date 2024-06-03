using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Globalization;

namespace Dynamic.Tekla.Structures;
public enum DetailTypeEnum
{
    END,
    INTERMEDIATE,
    INTERMEDIATE_REVERSE
}

internal static class DetailTypeEnum_
{
    public static dynamic GetTSObject(DetailTypeEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.DetailTypeEnum").GetType();

        switch (dynEnum)
        {
            case DetailTypeEnum.END:
                return Enum.Parse(tsType, "END");
            case DetailTypeEnum.INTERMEDIATE:
                return Enum.Parse(tsType, "INTERMEDIATE");
            case DetailTypeEnum.INTERMEDIATE_REVERSE:
                return Enum.Parse(tsType, "INTERMEDIATE_REVERSE");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static DetailTypeEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", CultureInfo.InvariantCulture);

        if (tsEnumValue.Equals("END", StringComparison.InvariantCulture))
            return DetailTypeEnum.END;
        else if (tsEnumValue.Equals("INTERMEDIATE", StringComparison.InvariantCulture))
            return DetailTypeEnum.INTERMEDIATE;
        else if (tsEnumValue.Equals("INTERMEDIATE_REVERSE", StringComparison.InvariantCulture))
            return DetailTypeEnum.INTERMEDIATE_REVERSE;

        else
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

    }
}

