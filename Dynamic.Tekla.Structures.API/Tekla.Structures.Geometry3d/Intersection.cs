using System;

namespace Dynamic.Tekla.Structures.Geometry3d;
public static class Intersection
{
    /// <summary>
    /// Returns a new line segment which is the shortest path between the given lines or null if the lines are
    /// parallel. If the resulting line segment has a length of 0.0, the given lines actually intersect
    /// in 3d space.
    /// </summary>
    /// <param name="line1">The first line to be used.</param>
    /// <param name="line2">The second line to be used.</param>
    /// <returns>The shortest line segment between the given lines or null if the lines are parallel.</returns>
    public static LineSegment LineToLine(Line line1, Line line2)
    {
        Vector vector = new Vector(line1.Origin);
        Vector vector2 = new Vector(vector + line1.Direction.GetNormal() * 10.0);
        Vector vector3 = new Vector(line2.Origin);
        Vector vector4 = new Vector(vector3 + line2.Direction.GetNormal() * 10.0);
        Vector vector5 = new Vector();
        Vector vector6 = new Vector();
        Vector vector7 = new Vector();
        vector5.X = vector.X - vector3.X;
        vector5.Y = vector.Y - vector3.Y;
        vector5.Z = vector.Z - vector3.Z;
        vector6.X = vector4.X - vector3.X;
        vector6.Y = vector4.Y - vector3.Y;
        vector6.Z = vector4.Z - vector3.Z;
        if (SmallerThanEpsilon(vector6, 1E-13))
        {
            return null;
        }
        vector7.X = vector2.X - vector.X;
        vector7.Y = vector2.Y - vector.Y;
        vector7.Z = vector2.Z - vector.Z;
        if (SmallerThanEpsilon(vector7, 1E-13))
        {
            return null;
        }
        double num = vector5.X * vector6.X + vector5.Y * vector6.Y + vector5.Z * vector6.Z;
        double num2 = vector6.X * vector7.X + vector6.Y * vector7.Y + vector6.Z * vector7.Z;
        double num3 = vector5.X * vector7.X + vector5.Y * vector7.Y + vector5.Z * vector7.Z;
        double num4 = vector6.X * vector6.X + vector6.Y * vector6.Y + vector6.Z * vector6.Z;
        double num5 = (vector7.X * vector7.X + vector7.Y * vector7.Y + vector7.Z * vector7.Z) * num4 - num2 * num2;
        if (Math.Abs(num5) < 1E-13)
        {
            return null;
        }
        double num6 = (num * num2 - num3 * num4) / num5;
        double num7 = (num + num2 * num6) / num4;
        Point point = new Point();
        Point point2 = new Point();
        point.X = vector.X + num6 * vector7.X;
        point.Y = vector.Y + num6 * vector7.Y;
        point.Z = vector.Z + num6 * vector7.Z;
        point2.X = vector3.X + num7 * vector6.X;
        point2.Y = vector3.Y + num7 * vector6.Y;
        point2.Z = vector3.Z + num7 * vector6.Z;
        return new LineSegment(point, point2);
    }

    /// <summary>
    /// Returns a new point which is an intersection of the given line and plane or null if the line and the plane are
    /// parallel.
    /// </summary>
    /// <param name="line">The line to be used.</param>
    /// <param name="plane">The plane to be used.</param>
    /// <returns>The intersection point or null if no intersection was found.</returns>
    public static Point LineToPlane(Line line, GeometricPlane plane)
    {
        if (Parallel.LineToPlane(line, plane))
        {
            return null;
        }
        double num = Vector.Dot(plane.GetNormal(), new Vector(plane.Origin - line.Origin)) / Vector.Dot(plane.GetNormal(), line.Direction);
        return line.Origin + line.Direction * num;
    }

    /// <summary>
    /// Returns a new point which is an intersection of the given line segment and plane or null if
    /// the line segment and the plane are parallel or do not intersect.
    /// </summary>
    /// <param name="lineSegment">The line segment to be used.</param>
    /// <param name="plane">The plane to be used.</param>
    /// <returns>The intersection point or null if no intersection was found.</returns>
    public static Point LineSegmentToPlane(LineSegment lineSegment, GeometricPlane plane)
    {
        if (Parallel.LineSegmentToPlane(lineSegment, plane))
        {
            return null;
        }
        double num = Vector.Dot(plane.GetNormal(), new Vector(plane.Origin - lineSegment.Point1)) / Vector.Dot(plane.GetNormal(), new Vector(lineSegment.Point2 - lineSegment.Point1));
        if (num >= 0.0 && num <= 1.0)
        {
            return lineSegment.Point1 + new Vector(lineSegment.Point2 - lineSegment.Point1) * num;
        }
        return null;
    }

    /// <summary>
    /// Returns a new line which is an intersection of the given two planes or null if the planes are
    /// parallel.
    /// </summary>
    /// <param name="plane1">The first plane to be used.</param>
    /// <param name="plane2">The second plane to be used.</param>
    /// <returns>The intersection line or null if no intersection was found.</returns>
    public static Line PlaneToPlane(GeometricPlane plane1, GeometricPlane plane2)
    {
        if (Parallel.PlaneToPlane(plane1, plane2))
        {
            return null;
        }
        Vector normal = plane1.GetNormal();
        Vector normal2 = plane2.GetNormal();
        double num = Vector.Dot(normal, normal);
        double num2 = Vector.Dot(normal, normal2);
        double num3 = Vector.Dot(normal2, normal2);
        double num4 = num * num3 - num2 * num2;
        double num5 = plane1.Origin.X * normal.X + plane1.Origin.Y * normal.Y + plane1.Origin.Z * normal.Z;
        double num6 = plane2.Origin.X * normal2.X + plane2.Origin.Y * normal2.Y + plane2.Origin.Z * normal2.Z;
        double num7 = 1.0 / num4;
        double num8 = (num3 * num5 - num2 * num6) * num7;
        double num9 = (num * num6 - num2 * num5) * num7;
        return new Line(normal * num8 + normal2 * num9, Vector.Cross(normal, normal2));
    }

    /// <summary>
    /// Returns a new line segment which is an intersection of the given line and the oriented bounding box
    /// or null if the line and oriented bounding box do not intersect.
    /// </summary>
    /// <param name="line">Line to be used.</param>
    /// <param name="obb">Oriented bounding box to be used.</param>
    /// <returns>The intersection line segment or null if no intersection was found.</returns>
    public static LineSegment LineToObb(Line line, OBB obb)
    {
        LineSegment result = null;
        if (line != null && obb != null)
        {
            result = obb.IntersectionWith(line);
        }
        return result;
    }

    /// <summary>
    /// Returns a new line segment which is an intersection of the given line segment and the oriented bounding box
    /// or null if the line segment and oriented bounding box do not intersect.
    /// </summary>
    /// <param name="lineSegment">Line segment to be used.</param>
    /// <param name="obb">Oriented bounding box to be used.</param>
    /// <returns>The intersection line segment or null if no intersection was found.</returns>
    public static LineSegment LineSegmentToObb(LineSegment lineSegment, OBB obb)
    {
        LineSegment result = null;
        if (lineSegment != null && obb != null)
        {
            result = obb.IntersectionWith(lineSegment);
        }
        return result;
    }

    /// <summary>
    /// Method for zero vector evaluation.
    /// </summary>
    /// <param name="vector">Vector to be evaluated.</param>
    /// <param name="epsilon">Epsilon to be used in comparison.</param>
    /// <returns>True if all the vector points are smaller than the given epsilon.</returns>
    private static bool SmallerThanEpsilon(Vector vector, double epsilon)
    {
        bool result = false;
        if (vector != null)
        {
            result = Math.Abs(vector.X) < epsilon && Math.Abs(vector.Y) < epsilon && Math.Abs(vector.Z) < epsilon;
        }
        return result;
    }
}
