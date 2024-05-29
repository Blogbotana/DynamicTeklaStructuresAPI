using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Geometry3d;
public enum PolymeshEdgeTypeEnum
{
    /// <summary>
    /// Explicitly states that this edge is visible
    /// </summary>
    VISIBLE_EDGE = 1,
    /// <summary>
    /// For hiding edges in visualizations
    /// </summary>
    INVISIBLE_EDGE
}
internal static class PolymeshEdgeTypeEnum_
{
    public static dynamic GetTSObject(PolymeshEdgeTypeEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.PolymeshEdgeTypeEnum").GetType();

        switch (dynEnum)
        {
            case PolymeshEdgeTypeEnum.VISIBLE_EDGE:
                return System.Enum.Parse(tsType, "VISIBLE_EDGE");
            case PolymeshEdgeTypeEnum.INVISIBLE_EDGE:
                return System.Enum.Parse(tsType, "INVISIBLE_EDGE");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static PolymeshEdgeTypeEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

        if (tsEnumValue.Equals("VISIBLE_EDGE", System.StringComparison.InvariantCulture))
            return PolymeshEdgeTypeEnum.VISIBLE_EDGE;
        else if (tsEnumValue.Equals("INVISIBLE_EDGE", System.StringComparison.InvariantCulture))
            return PolymeshEdgeTypeEnum.INVISIBLE_EDGE;

        else
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

    }
}