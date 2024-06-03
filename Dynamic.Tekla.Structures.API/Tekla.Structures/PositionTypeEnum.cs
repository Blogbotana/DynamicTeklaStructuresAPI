using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures;
/// <summary>
/// The position type for connections and details.
/// </summary>
public enum PositionTypeEnum
{
    /// <summary>
    /// The middle plane position type.
    /// </summary>
    MIDDLE_PLANE,
    /// <summary>
    /// The box plane position type.
    /// </summary>
    BOX_PLANE,
    /// <summary>
    /// The collision plane position type.
    /// </summary>
    COLLISION_PLANE,
    /// <summary>
    /// The end plane position type.
    /// </summary>
    END_END_PLANE,
    /// <summary>
    /// The gusset plane position type.
    /// </summary>
    GUSSET_PLANE
}
internal static class PositionTypeEnum_
{
    public static dynamic GetTSObject(PositionTypeEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.PositionTypeEnum").GetType();

        switch (dynEnum)
        {
            case PositionTypeEnum.MIDDLE_PLANE:
                return System.Enum.Parse(tsType, "MIDDLE_PLANE");
            case PositionTypeEnum.BOX_PLANE:
                return System.Enum.Parse(tsType, "BOX_PLANE");
            case PositionTypeEnum.COLLISION_PLANE:
                return System.Enum.Parse(tsType, "COLLISION_PLANE");
            case PositionTypeEnum.END_END_PLANE:
                return System.Enum.Parse(tsType, "END_END_PLANE");
            case PositionTypeEnum.GUSSET_PLANE:
                return System.Enum.Parse(tsType, "GUSSET_PLANE");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static PositionTypeEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

        if (tsEnumValue.Equals("MIDDLE_PLANE", System.StringComparison.InvariantCulture))
            return PositionTypeEnum.MIDDLE_PLANE;
        else if (tsEnumValue.Equals("BOX_PLANE", System.StringComparison.InvariantCulture))
            return PositionTypeEnum.BOX_PLANE;
        else if (tsEnumValue.Equals("COLLISION_PLANE", System.StringComparison.InvariantCulture))
            return PositionTypeEnum.COLLISION_PLANE;
        else if (tsEnumValue.Equals("END_END_PLANE", System.StringComparison.InvariantCulture))
            return PositionTypeEnum.END_END_PLANE;
        else if (tsEnumValue.Equals("GUSSET_PLANE", System.StringComparison.InvariantCulture))
            return PositionTypeEnum.GUSSET_PLANE;

        else
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

    }
}

