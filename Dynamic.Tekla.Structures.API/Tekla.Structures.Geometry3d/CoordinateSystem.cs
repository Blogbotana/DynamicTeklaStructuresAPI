using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Geometry3d;
/// <summary>
/// The CoordinateSystem class defines a coordinate system in space. The system is
/// defined by an origin, an X-axis and a Y-axis. The Z-axis is the cross product
/// of the X-axis and the Y-axis.
/// </summary>
public class CoordinateSystem
{
    /// <summary>
    /// The origin of the coordinate system.
    /// </summary>
    public Point Origin
    {
        get
        {
            try
            {
                dynamic value = teklaObject.Origin;
                dynamic value_ = Point_.FromTSObject(value);
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
                dynamic value_ = Point_.GetTSObject(value);
                teklaObject.Origin = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Origin), ex);
            }
        }
    }
    public Dynamic.Tekla.Structures.Geometry3d.Vector AxisX
    {
        get
        {
            try
            {
                var value = teklaObject.AxisX;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AxisX), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
                teklaObject.AxisX = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AxisX), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Vector AxisY
    {
        get
        {
            try
            {
                var value = teklaObject.AxisY;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AxisY), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
                teklaObject.AxisY = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AxisY), ex);
            }
        }
    }
    internal dynamic teklaObject;
    public CoordinateSystem()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.CoordinateSystem");
    }
    public CoordinateSystem(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public CoordinateSystem(Point Origin, Vector AxisX, Vector AxisY)
    {
        object[] args = new object[3];
        args[0] = Point_.GetTSObject(Origin);
        args[1] = Vector_.GetTSObject(AxisX);
        args[2] = Vector_.GetTSObject(AxisY);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.CoordinateSystem", args);
    }
}
internal static class CoordinateSystem_
{
    public static dynamic GetTSObject(CoordinateSystem dynObject)
    {
        return dynObject is null ? null : dynObject.teklaObject;
    }

    public static CoordinateSystem FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        dynamic typeName = "Dynamic." + tsObject.GetType().FullName;
        dynamic type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        object[] parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        CoordinateSystem dynObject = (CoordinateSystem)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
