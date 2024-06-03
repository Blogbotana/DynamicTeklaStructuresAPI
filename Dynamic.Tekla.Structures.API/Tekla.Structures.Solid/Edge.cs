using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dynamic.Tekla.Structures.Geometry3d;

namespace Dynamic.Tekla.Structures.Solid;
/// <summary>
/// The Edge class represents a single global edge in a solid.
/// </summary>
public sealed class Edge : ICloneable
{
    public EdgeTypeEnum Type
    {
        get
        {
            try
            {
                var value = teklaObject.Type;
                var value_ = EdgeTypeEnum_.FromTSObject(value);
                return (EdgeTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex);
            }
        }
    }

    public Point StartPoint
    {
        get
        {
            try
            {
                var value = teklaObject.StartPoint;
                var value_ = Point_.FromTSObject(value);
                return (Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPoint), ex);
            }
        }

    }

    internal dynamic teklaObject;

    internal Edge() { }
    
    public Edge(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }

    public object Clone()
    {
        try
        {
            var result = (object)teklaObject.Clone();
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Clone), ex);
        }
    }

    /// <summary>
    /// The type of the edge.
    /// </summary>
    public enum EdgeTypeEnum
    {
        /// <summary>
        /// The normal edge type.
        /// </summary>
        EDGE_TYPE_NORMAL,
        /// <summary>
        /// The curved surface edge type.
        /// </summary>
        EDGE_TYPE_CURVED_SURFACE,
        /// <summary>
        /// The hidden edge type.
        /// </summary>
        EDGE_TYPE_HIDDEN
    }

    internal static class EdgeTypeEnum_
    {
        public static dynamic GetTSObject(EdgeTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Solid.Edge.EdgeTypeEnum").GetType();

            switch (dynEnum)
            {
                case EdgeTypeEnum.EDGE_TYPE_NORMAL:
                    return System.Enum.Parse(tsType, "EDGE_TYPE_NORMAL");
                case EdgeTypeEnum.EDGE_TYPE_CURVED_SURFACE:
                    return System.Enum.Parse(tsType, "EDGE_TYPE_CURVED_SURFACE");
                case EdgeTypeEnum.EDGE_TYPE_HIDDEN:
                    return System.Enum.Parse(tsType, "EDGE_TYPE_HIDDEN");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static EdgeTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("EDGE_TYPE_NORMAL", System.StringComparison.InvariantCulture))
                return EdgeTypeEnum.EDGE_TYPE_NORMAL;
            else if (tsEnumValue.Equals("EDGE_TYPE_CURVED_SURFACE", System.StringComparison.InvariantCulture))
                return EdgeTypeEnum.EDGE_TYPE_CURVED_SURFACE;
            else if (tsEnumValue.Equals("EDGE_TYPE_HIDDEN", System.StringComparison.InvariantCulture))
                return EdgeTypeEnum.EDGE_TYPE_HIDDEN;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }

}
internal static class Edge_
{
    public static dynamic GetTSObject(Edge dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Edge FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Solid.Edge)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
