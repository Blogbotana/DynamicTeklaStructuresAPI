﻿using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures;
public enum ConnectionStatusEnum
{
    STATUS_UNKNOWN,
    STATUS_OK,
    STATUS_WARNING,
    STATUS_ERROR
}
internal static class ConnectionStatusEnum_
{
    public static dynamic GetTSObject(ConnectionStatusEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.ConnectionStatusEnum").GetType();

        switch (dynEnum)
        {
            case ConnectionStatusEnum.STATUS_UNKNOWN:
                return System.Enum.Parse(tsType, "STATUS_UNKNOWN");
            case ConnectionStatusEnum.STATUS_OK:
                return System.Enum.Parse(tsType, "STATUS_OK");
            case ConnectionStatusEnum.STATUS_WARNING:
                return System.Enum.Parse(tsType, "STATUS_WARNING");
            case ConnectionStatusEnum.STATUS_ERROR:
                return System.Enum.Parse(tsType, "STATUS_ERROR");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static ConnectionStatusEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

        if (tsEnumValue.Equals("STATUS_UNKNOWN", System.StringComparison.InvariantCulture))
            return ConnectionStatusEnum.STATUS_UNKNOWN;
        else if (tsEnumValue.Equals("STATUS_OK", System.StringComparison.InvariantCulture))
            return ConnectionStatusEnum.STATUS_OK;
        else if (tsEnumValue.Equals("STATUS_WARNING", System.StringComparison.InvariantCulture))
            return ConnectionStatusEnum.STATUS_WARNING;
        else if (tsEnumValue.Equals("STATUS_ERROR", System.StringComparison.InvariantCulture))
            return ConnectionStatusEnum.STATUS_ERROR;

        else
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

    }
}
