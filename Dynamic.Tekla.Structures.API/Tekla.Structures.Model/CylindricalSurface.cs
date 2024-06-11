using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;


public class CylindricalSurface : BendSurface
{


    public double Radius
    {
        get
        {
            try
            {
                return teklaObject.Radius;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Radius), ex);
            }
        }

    }




    internal CylindricalSurface() { }

    public CylindricalSurface(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public CylindricalSurface(Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal1, Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal2, Dynamic.Tekla.Structures.Geometry3d.LineSegment sideBoundary1, Dynamic.Tekla.Structures.Geometry3d.LineSegment sideBoundary2)
    {
        var args = new object[4];
        args[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal1);
        args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal2);
        args[2] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(sideBoundary1);
        args[3] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(sideBoundary2);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CylindricalSurface", args);
    }
    public CylindricalSurface(Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal1, Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal2, System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary1, System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary2)
    {
        var args = new object[4];
        args[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal1);
        args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal2);
        args[2] = lateralBoundary1;
        args[3] = lateralBoundary2;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CylindricalSurface", args);
    }
    public CylindricalSurface(Dynamic.Tekla.Structures.Geometry3d.Arc baseArc, double height)
    {
        var args = new object[2];
        args[0] = Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(baseArc);
        args[1] = height;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CylindricalSurface", args);
    }
    public CylindricalSurface(System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary1, System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary2, Dynamic.Tekla.Structures.Geometry3d.Line centerLine, Dynamic.Tekla.Structures.Geometry3d.Vector rotationAxis)
    {
        var args = new object[4];
        args[0] = lateralBoundary1;
        args[1] = lateralBoundary2;
        args[2] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(centerLine);
        args[3] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(rotationAxis);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CylindricalSurface", args);
    }





}

internal static class CylindricalSurface_
{
    public static dynamic GetTSObject(CylindricalSurface dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static CylindricalSurface FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (CylindricalSurface)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

