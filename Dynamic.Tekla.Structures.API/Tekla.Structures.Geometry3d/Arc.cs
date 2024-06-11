using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;

namespace Dynamic.Tekla.Structures.Geometry3d;
/// <summary>
/// Represents an arc geometry
/// </summary>
public class Arc : ICurve, IEquatable<ICurve>
{
    /// <summary>
	/// Returns the length of the arc
	/// </summary>
	public double Length => Radius * Angle;

    /// <summary>
    ///  Gets or sets start point of the arc.
    /// </summary>
    public Point StartPoint => CenterPoint + (Radius * StartDirection);

    /// <summary>
    ///  Gets or sets end point of the arc.
    /// </summary>
    public Point EndPoint => CenterPoint + (Radius * Math.Cos(Angle) * StartDirection) + (Radius * Math.Sin(Angle) * StartTangent);

    public Point CenterPoint
    {
        get
        {
            try
            {
                dynamic value = teklaObject.CenterPoint;
                dynamic value_ = Point_.FromTSObject(value);
                return (Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CenterPoint), ex);
            }
        }

    }

    /// <summary>
    /// Gets the point located at the middle of the arc
    /// </summary>
    public Point ArcMiddlePoint => CenterPoint + (Radius * Math.Cos(Angle / 2.0) * StartDirection) + (Radius * Math.Sin(Angle / 2.0) * StartTangent);

    /// <summary>
    /// Gets normal of the arc, which defines the axis of rotation of the radial vector pointing to the start point
    /// of the arc.
    /// </summary>
    public Vector Normal => StartDirection.Cross(StartTangent);

    /// <summary>
    /// Gets angle of the arc in radians.
    /// </summary>
    public double Angle
    {
        get
        {
            try
            {
                return teklaObject.Angle;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Angle), ex);
            }
        }

    }

    /// <summary>
    /// Gets the radius of the arc.
    /// </summary>
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

    /// <summary>
    /// Gets the unit vector tangent to the start point which defines the Y axis of the arc coordinate system
    /// </summary>
    public Vector StartTangent
    {
        get
        {
            try
            {
                dynamic value = teklaObject.StartTangent;
                dynamic value_ = Vector_.FromTSObject(value);
                return (Vector)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartTangent), ex);
            }
        }

    }

    /// <summary>
    /// Gets the unit vector which points from the center point to the start point of the arc, which defines the
    /// X axis of the arc coordinate system.
    /// </summary>
    public Vector StartDirection
    {
        get
        {
            try
            {
                dynamic value = teklaObject.StartDirection;
                dynamic value_ = Vector_.FromTSObject(value);
                return (Vector)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartDirection), ex);
            }
        }

    }

    /// <summary>
    /// Returns a copy of itself
    /// </summary>
    /// <returns>The copy</returns>
    public ICurve Clone()
    {
        return new Arc(CenterPoint, StartDirection, StartTangent, Radius, Angle);
    }

    public bool Equals(ICurve other)
    {
        Arc arc = other as Arc;
        if (arc == null)
        {
            return false;
        }
        bool flag = arc.Normal.GetAngleBetween(Normal) < GeometryConstants.ANGULAR_EPSILON;
        if (Point.AreEqual(arc.StartPoint, StartPoint) && Point.AreEqual(arc.EndPoint, EndPoint) && flag)
        {
            return Math.Abs(arc.Angle - Angle) < GeometryConstants.ANGULAR_EPSILON;
        }
        return false;
    }

    public dynamic teklaObject { get; set; }

    internal Arc() { }
    public Arc(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public Arc(Point startPoint, Point endPoint, Point pointOnArc)
    {
        if (TeklaProcess.TeklaFileVersion <= new Version("2018.1.0.0"))
            return;

        object[] args = new object[3];
        args[0] = Point_.GetTSObject(startPoint);
        args[1] = Point_.GetTSObject(endPoint);
        args[2] = Point_.GetTSObject(pointOnArc);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Arc", args);
    }
    public Arc(Point centerPoint, Point startPoint, Vector normal, double deltaAngleRadians)
    {
        if (TeklaProcess.TeklaFileVersion <= new Version("2018.1.0.0"))
            return;

        object[] args = new object[4];
        args[0] = Point_.GetTSObject(centerPoint);
        args[1] = Point_.GetTSObject(startPoint);
        args[2] = Vector_.GetTSObject(normal);
        args[3] = deltaAngleRadians;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Arc", args);
    }
    public Arc(Point centerPoint, Vector startDirection, Vector startTangent, double radius, double deltaAngleRadians)
    {
        if (TeklaProcess.TeklaFileVersion <= new Version("2018.1.0.0"))
            return;

        object[] args = new object[5];
        args[0] = Point_.GetTSObject(centerPoint);
        args[1] = Vector_.GetTSObject(startDirection);
        args[2] = Vector_.GetTSObject(startTangent);
        args[3] = radius;
        args[4] = deltaAngleRadians;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Arc", args);
    }
}
internal static class Arc_
{
    public static dynamic GetTSObject(Arc dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Arc FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Arc)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}