using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Geometry3d;
public class AABB : IBoundingVolume
{
    public Point MinPoint
    {
        get
        {
            try
            {
                var value = teklaObject.MinPoint;
                var value_ = Point_.FromTSObject(value);
                return (Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MinPoint), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Point_.GetTSObject(value);
                teklaObject.MinPoint = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MinPoint), ex);
            }
        }
    }

    public Point MaxPoint
    {
        get
        {
            try
            {
                var value = teklaObject.MaxPoint;
                var value_ = Point_.FromTSObject(value);
                return (Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MaxPoint), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Point_.GetTSObject(value);
                teklaObject.MaxPoint = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MaxPoint), ex);
            }
        }
    }

    internal dynamic teklaObject;

    public AABB()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.AABB");
    }

    public AABB(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public AABB(Point MinPoint, Point MaxPoint)
    {
        var args = new object[2];
        args[0] = Point_.GetTSObject(MinPoint);
        args[1] = Point_.GetTSObject(MaxPoint);
        this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.AABB", args);
    }
    public AABB(System.Collections.Generic.IEnumerable<Point> Points)
    {
        var args = new object[1];
        args[0] = Points;
        this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.AABB", args);
    }
    public AABB(AABB AABB)
    {
        var args = new object[1];
        args[0] = AABB_.GetTSObject(AABB);
        this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.AABB", args);
    }



    /// <summary>
    /// Checks if the given point is inside the current axis-aligned 3d bounding box.
    /// </summary>
    /// <param name="Point">The point to be checked.</param>
    /// <returns>True if the point is inside the current axis-aligned 3d bounding box.</returns>
    public bool IsInside(Point Point)
    {
        bool result = false;
        if (Point.X > MinPoint.X - 0.0001 && Point.Y > MinPoint.Y - 0.0001 && Point.Z > MinPoint.Z - 0.0001 && Point.X < MaxPoint.X + 0.0001 && Point.Y < MaxPoint.Y + 0.0001 && Point.Z < MaxPoint.Z + 0.0001)
        {
            result = true;
        }
        return result;
    }

    /// <summary>
    /// Checks if the given line segment is inside the current axis-aligned 3d bounding box.
    /// </summary>
    /// <param name="LineSegment">The line segment to be checked.</param>
    /// <returns>True if the point is inside the current axis-aligned 3d bounding box.</returns>
    public bool IsInside(LineSegment LineSegment)
    {
        bool result = false;
        if ((!(LineSegment.Point1.X < MinPoint.X) || !(LineSegment.Point2.X < MinPoint.X)) && (!(LineSegment.Point1.X > MaxPoint.X) || !(LineSegment.Point2.X > MaxPoint.X)) && (!(LineSegment.Point1.Y < MinPoint.Y) || !(LineSegment.Point2.Y < MinPoint.Y)) && (!(LineSegment.Point1.Y > MaxPoint.Y) || !(LineSegment.Point2.Y > MaxPoint.Y)) && (!(LineSegment.Point1.Z < MinPoint.Z) || !(LineSegment.Point2.Z < MinPoint.Z)) && (!(LineSegment.Point1.Z > MaxPoint.Z) || !(LineSegment.Point2.Z > MaxPoint.Z)))
        {
            result = true;
        }
        return result;
    }

    /// <summary>
    /// Returns the geometric center point of the current axis-aligned 3d bounding box.
    /// </summary>
    /// <returns>The geometric center point of the current axis-aligned 3d bounding box.</returns>
    public Point GetCenterPoint()
    {
        return new Point((MaxPoint.X + MinPoint.X) * 0.5, (MaxPoint.Y + MinPoint.Y) * 0.5, (MaxPoint.Z + MinPoint.Z) * 0.5);
    }

    /// <summary>
    /// Returns all corner points of the current axis-aligned 3d bounding box.
    /// </summary>
    /// <returns>All corner points of the current axis-aligned 3d bounding box.</returns>
    public Point[] GetCornerPoints()
    {
        return new Point[8]
        {
            new Point(MinPoint.X, MinPoint.Y, MinPoint.Z),
            new Point(MaxPoint.X, MinPoint.Y, MinPoint.Z),
            new Point(MinPoint.X, MaxPoint.Y, MinPoint.Z),
            new Point(MaxPoint.X, MaxPoint.Y, MinPoint.Z),
            new Point(MinPoint.X, MinPoint.Y, MaxPoint.Z),
            new Point(MaxPoint.X, MinPoint.Y, MaxPoint.Z),
            new Point(MinPoint.X, MaxPoint.Y, MaxPoint.Z),
            new Point(MaxPoint.X, MaxPoint.Y, MaxPoint.Z)
        };
    }

    /// <summary>
    /// Checks if the current axis-aligned 3d bounding box collides with
    /// another given axis-aligned 3d bounding box. Both axis-aligned 3d
    /// bounding boxes need to be in the same coordinate system or in the
    /// same workplane, so that they are defined using the same axes.
    /// </summary>
    /// <param name="Other">Another axis-aligned 3d bounding box to be used in the collision check.</param>
    /// <returns>True if the axis-aligned 3d bounding boxes collide.</returns>
    public bool Collide(AABB Other)
    {
        if (!(MaxPoint.X < Other.MinPoint.X) && !(MinPoint.X > Other.MaxPoint.X) && !(MaxPoint.Y < Other.MinPoint.Y) && !(MinPoint.Y > Other.MaxPoint.Y) && !(MaxPoint.Z < Other.MinPoint.Z))
        {
            return !(MinPoint.Z > Other.MaxPoint.Z);
        }
        return false;
    }
    /// <summary>
	/// Combines (adds) the given two axis-aligned 3d bounding boxes.
	/// </summary>
	/// <param name="AABB1">The first axis-aligned 3d bounding box to combine.</param>
	/// <param name="AABB2">The second axis-aligned 3d bounding box to combine.</param>
	/// <returns>The new combined axis-aligned 3d bounding box.</returns>
	public static AABB operator +(AABB AABB1, AABB AABB2)
    {
        AABB aABB = new AABB(AABB1);
        if (AABB2.MinPoint.X < AABB1.MinPoint.X)
        {
            aABB.MinPoint.X = AABB2.MinPoint.X;
        }
        if (AABB2.MinPoint.Y < AABB1.MinPoint.Y)
        {
            aABB.MinPoint.Y = AABB2.MinPoint.Y;
        }
        if (AABB2.MinPoint.Z < AABB1.MinPoint.Z)
        {
            aABB.MinPoint.Z = AABB2.MinPoint.Z;
        }
        if (AABB2.MaxPoint.X > AABB1.MaxPoint.X)
        {
            aABB.MaxPoint.X = AABB2.MaxPoint.X;
        }
        if (AABB2.MaxPoint.Y > AABB1.MaxPoint.Y)
        {
            aABB.MaxPoint.Y = AABB2.MaxPoint.Y;
        }
        if (AABB2.MaxPoint.Z > AABB1.MaxPoint.Z)
        {
            aABB.MaxPoint.Z = AABB2.MaxPoint.Z;
        }
        return aABB;
    }

    /// <summary>
    /// Adds the given point to the given axis-aligned 3d bounding box.
    /// </summary>
    /// <param name="AABB">The axis-aligned 3d bounding box to add to.</param>
    /// <param name="Point">The point to be added.</param>
    /// <returns>The new axis-aligned 3d bounding box which includes the
    /// given axis-aligned 3d bounding box and the given point.</returns>
    public static AABB operator +(AABB AABB, Point Point)
    {
        AABB aABB = new AABB(AABB);
        if (Point.X < AABB.MinPoint.X)
        {
            aABB.MinPoint.X = Point.X;
        }
        if (Point.Y < AABB.MinPoint.Y)
        {
            aABB.MinPoint.Y = Point.Y;
        }
        if (Point.Z < AABB.MinPoint.Z)
        {
            aABB.MinPoint.Z = Point.Z;
        }
        if (Point.X > AABB.MaxPoint.X)
        {
            aABB.MaxPoint.X = Point.X;
        }
        if (Point.Y > AABB.MaxPoint.Y)
        {
            aABB.MaxPoint.Y = Point.Y;
        }
        if (Point.Z > AABB.MaxPoint.Z)
        {
            aABB.MaxPoint.Z = Point.Z;
        }
        return aABB;
    }

    /// <summary>
    /// Adds the given point to the given axis-aligned 3d bounding box.
    /// </summary>
    /// <param name="Point">The point to be added.</param>
    /// <param name="AABB">The axis-aligned 3d bounding box to add to.</param>
    /// <returns>The new axis-aligned 3d bounding box which includes the given
    /// axis-aligned 3d bounding box and the given point.</returns>
    public static AABB operator +(Point Point, AABB AABB)
    {
        return AABB + Point;
    }
}
internal static class AABB_
{
    public static dynamic GetTSObject(AABB dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static AABB FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (AABB)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}