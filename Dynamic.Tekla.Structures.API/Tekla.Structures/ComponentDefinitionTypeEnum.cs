﻿using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures;
public enum ComponentDefinitionTypeEnum
{
    SYSTEM,
    DOTNET_DRAWING,
    DOTNET_CONNECTION,
    DOTNET,
    CUSTOM
}
internal static class ComponentDefinitionTypeEnum_
{
    public static dynamic GetTSObject(ComponentDefinitionTypeEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.ComponentDefinitionTypeEnum").GetType();

        switch (dynEnum)
        {
            case ComponentDefinitionTypeEnum.SYSTEM:
                return System.Enum.Parse(tsType, "SYSTEM");
            case ComponentDefinitionTypeEnum.DOTNET_DRAWING:
                return System.Enum.Parse(tsType, "DOTNET_DRAWING");
            case ComponentDefinitionTypeEnum.DOTNET_CONNECTION:
                return System.Enum.Parse(tsType, "DOTNET_CONNECTION");
            case ComponentDefinitionTypeEnum.DOTNET:
                return System.Enum.Parse(tsType, "DOTNET");
            case ComponentDefinitionTypeEnum.CUSTOM:
                return System.Enum.Parse(tsType, "CUSTOM");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static ComponentDefinitionTypeEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

        if (tsEnumValue.Equals("SYSTEM", System.StringComparison.InvariantCulture))
            return ComponentDefinitionTypeEnum.SYSTEM;
        else if (tsEnumValue.Equals("DOTNET_DRAWING", System.StringComparison.InvariantCulture))
            return ComponentDefinitionTypeEnum.DOTNET_DRAWING;
        else if (tsEnumValue.Equals("DOTNET_CONNECTION", System.StringComparison.InvariantCulture))
            return ComponentDefinitionTypeEnum.DOTNET_CONNECTION;
        else if (tsEnumValue.Equals("DOTNET", System.StringComparison.InvariantCulture))
            return ComponentDefinitionTypeEnum.DOTNET;
        else if (tsEnumValue.Equals("CUSTOM", System.StringComparison.InvariantCulture))
            return ComponentDefinitionTypeEnum.CUSTOM;

        else
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

    }
}
