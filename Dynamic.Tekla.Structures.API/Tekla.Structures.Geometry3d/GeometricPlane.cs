using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;

namespace Dynamic.Tekla.Structures.Geometry3d;
public class GeometricPlane
{
    public Point Origin
    {
        get
        {
            try
            {
                var value = teklaObject.Origin;
                var value_ = Point_.FromTSObject(value);
                return (Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Origin), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Point_.GetTSObject(value);
                teklaObject.Origin = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Origin), ex);
            }
        }
    }

    public Vector Normal
    {
        get
        {
            try
            {
                var value = teklaObject.Normal;
                var value_ = Vector_.FromTSObject(value);
                return (Vector)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Normal), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Vector_.GetTSObject(value);
                teklaObject.Normal = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Normal), ex);
            }
        }
    }


    internal dynamic teklaObject;

    public GeometricPlane()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.GeometricPlane");
    }

    public GeometricPlane(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public GeometricPlane(Point Origin, Vector Normal)
    {
        var args = new object[2];
        args[0] = Point_.GetTSObject(Origin);
        args[1] = Vector_.GetTSObject(Normal);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.GeometricPlane", args);
    }
    public GeometricPlane(Point Origin, Vector Xaxis, Vector Yaxis)
    {
        var args = new object[3];
        args[0] = Point_.GetTSObject(Origin);
        args[1] = Vector_.GetTSObject(Xaxis);
        args[2] = Vector_.GetTSObject(Yaxis);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.GeometricPlane", args);
    }
    public GeometricPlane(CoordinateSystem CoordSys)
    {
        var args = new object[1];
        args[0] = CoordinateSystem_.GetTSObject(CoordSys);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.GeometricPlane", args);
    }

    /// <summary>
    /// Returns a normalized normal vector of the plane.
    /// </summary>
    /// <returns>The normalized normal vector of the plane.</returns>
    public Vector GetNormal()
    {
        Vector vector = new Vector(Normal);
        vector.Normalize();
        return vector;
    }


}
internal static class GeometricPlane_
{
    public static dynamic GetTSObject(GeometricPlane dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static GeometricPlane FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (GeometricPlane)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}


