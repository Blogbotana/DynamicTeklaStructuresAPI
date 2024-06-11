using Dynamic.Tekla.Structures.Geometry3d;
using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Dynamic.Tekla.Structures.Model;


public class CylindricalSurfaceNode : BendSurfaceNode
{
    internal CylindricalSurfaceNode() { }

    public CylindricalSurfaceNode(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public CylindricalSurfaceNode(CylindricalSurface surface)
    {
        var args = new object[1];
        args[0] = CylindricalSurface_.GetTSObject(surface);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CylindricalSurfaceNode", args);
    }

    public override IGeometryNode Clone()
    {
        Line line = new Line(new Point(Surface.CenterLine.Origin), Surface.RotationAxis);
        List<Point> lateralBoundary = Surface.LateralBoundary1.Select((Point point) => new Point(point)).ToList();
        List<Point> lateralBoundary2 = Surface.LateralBoundary2.Select((Point point) => new Point(point)).ToList();
        return new CylindricalSurfaceNode(new CylindricalSurface(lateralBoundary, lateralBoundary2, line, line.Direction));
    }
}

internal static class CylindricalSurfaceNode_
{
    public static dynamic GetTSObject(CylindricalSurfaceNode dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static CylindricalSurfaceNode FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (CylindricalSurfaceNode)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}


