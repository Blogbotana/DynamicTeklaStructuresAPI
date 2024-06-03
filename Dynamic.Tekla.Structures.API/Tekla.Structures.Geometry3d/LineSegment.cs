using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Geometry3d;
public class LineSegment : ICurve, IEquatable<ICurve>
{
    public Point Point1
    {
        get
        {
            try
            {
                var value = teklaObject.Point1;
                var value_ = Point_.FromTSObject(value);
                return (Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Point1), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Point_.GetTSObject(value);
                teklaObject.Point1 = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Point1), ex);
            }
        }
    }

    public Point Point2
    {
        get
        {
            try
            {
                var value = teklaObject.Point2;
                var value_ = Point_.FromTSObject(value);
                return (Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Point2), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Point_.GetTSObject(value);
                teklaObject.Point2 = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Point2), ex);
            }
        }
    }
    /// <summary>
    /// Gets the start point of the line segment
    /// </summary>
    public Point StartPoint => Point1;

    /// <summary>
    /// Gets the end point of the line segment
    /// </summary>
    public Point EndPoint => Point2;

    internal dynamic teklaObject;

    public LineSegment()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.LineSegment");
    }
    
    public LineSegment(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public LineSegment(Point Point1, Point Point2)
    {
        var args = new object[2];
        args[0] = Point_.GetTSObject(Point1);
        args[1] = Point_.GetTSObject(Point2);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.LineSegment", args);
    }

    /// <summary>
    /// Gets the
    /// </summary>
    double ICurve.Length => Length();

    /// <summary>
	/// Creates a copy of itself
	/// </summary>
	/// <returns>The copy</returns>
	public ICurve Clone()
    {
        return new LineSegment(Point1, Point2);
    }
    /// <summary>
    /// Returns true if the objects are equal.
    /// </summary>
    /// <param name="o">The object that equality is wished to be checked with.</param>
    /// <returns>True if the objects are equal.</returns>
    public override bool Equals(object o)
    {
        if (o == null || GetType() != o.GetType())
        {
            return false;
        }
        LineSegment lineSegment = (LineSegment)o;
        return this == lineSegment;
    }

    /// <summary>
    /// Returns true if the other curve is a line segment equal to this
    /// </summary>
    /// <param name="other">The curve to check equality against</param>
    /// <returns>True if the curves are equal</returns>
    public bool Equals(ICurve other)
    {
        return Equals((object)other);
    }

    /// <summary>
    /// Returns the length of a line segment.
    /// </summary>
    /// <returns>The length of the line segment.</returns>
    public double Length()
    {
        return Distance.PointToPoint(Point1, Point2);
    }

    /// <summary>
    /// Returns a new unit direction vector of a line segment.
    /// </summary>
    /// <returns>The unit direction vector of the line segment.</returns>
    public Vector GetDirectionVector()
    {
        Vector vector = new Vector(Point2 - Point1);
        vector.Normalize();
        return vector;
    }

    /// <summary>
    /// Returns a hash code for a line segment.
    /// Notice, in extremely rare cases, you might not get the same
    /// hash code for two line segments even though they are considered equal! This
    /// should, however, happen only in extremely rare cases!
    /// </summary>
    /// <returns>The hash code for the line segment.</returns>
    public override int GetHashCode()
    {
        return Point1.GetHashCode() ^ Point2.GetHashCode();
    }

    /// <summary>
    /// Checks the equality of two line segments.
    /// </summary>
    /// <param name="Segment1">The first line segment to be used.</param>
    /// <param name="Segment2">The second line segment to be used.</param>
    /// <returns>True if the two line segments are equal.
    /// False otherwise.</returns>
    public static bool operator ==(LineSegment Segment1, LineSegment Segment2)
    {
        bool flag = (object)Segment1 == null;
        bool flag2 = (object)Segment2 == null;
        if (flag && flag2)
        {
            return true;
        }
        if (flag || flag2)
        {
            return false;
        }
        if (Segment1.Point1 == Segment2.Point1)
        {
            return Segment1.Point2 == Segment2.Point2;
        }
        return false;
    }

    /// <summary>
    /// Checks the inequality of two line segments.
    /// </summary>
    /// <param name="Segment1">The first line segment to be used.</param>
    /// <param name="Segment2">The second line segment to be used.</param>
    /// <returns>True if the two line segments are not equal.
    /// False otherwise.</returns>
    public static bool operator !=(LineSegment Segment1, LineSegment Segment2)
    {
        return !(Segment1 == Segment2);
    }
}
internal static class LineSegment_
{
    public static dynamic GetTSObject(LineSegment dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static LineSegment FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (LineSegment)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

