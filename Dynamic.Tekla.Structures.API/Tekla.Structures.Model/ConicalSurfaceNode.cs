











using Dynamic.Tekla.Structures.Geometry3d;
using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Dynamic.Tekla.Structures.Model;

public class ConicalSurfaceNode : BendSurfaceNode
{

    internal ConicalSurfaceNode() { }

    public ConicalSurfaceNode(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public ConicalSurfaceNode(ConicalSurface surface)
    {
        var args = new object[1];
        args[0] = ConicalSurface_.GetTSObject(surface);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConicalSurfaceNode", args);
    }


    public override IGeometryNode Clone()
    {
        Line line = new Line(new Point(Surface.CenterLine.Origin), Surface.RotationAxis);
        List<Point> lateralBoundary = Surface.LateralBoundary1.Select((Point point) => new Point(point)).ToList();
        List<Point> lateralBoundary2 = Surface.LateralBoundary2.Select((Point point) => new Point(point)).ToList();
        return new ConicalSurfaceNode(new ConicalSurface(lateralBoundary, lateralBoundary2, line, line.Direction));
    }


}

internal static class ConicalSurfaceNode_
{
    public static dynamic GetTSObject(ConicalSurfaceNode dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ConicalSurfaceNode FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ConicalSurfaceNode)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ConicalSurfaceNodeArray_
{
    public static dynamic GetTSObject(ConicalSurfaceNode[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(ConicalSurfaceNode_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static ConicalSurfaceNode[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<ConicalSurfaceNode>();
        foreach (var tsItem in tsArray)
        {
            list.Add(ConicalSurfaceNode_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}




