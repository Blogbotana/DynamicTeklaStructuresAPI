using System;

namespace Dynamic.Tekla.Structures.Geometry3d;
public static class Distance
{
    /// <summary>
    /// Returns the distance between the given two points.
    /// </summary>
    /// <param name="Point1">The first point to be used.</param>
    /// <param name="Point2">The second point to be used.</param>
    /// <returns>The distance between the given points.</returns>
    public static double PointToPoint(Point Point1, Point Point2)
    {
        return Math.Sqrt(Math.Pow(Point1.X - Point2.X, 2.0) + Math.Pow(Point1.Y - Point2.Y, 2.0) + Math.Pow(Point1.Z - Point2.Z, 2.0));
    }

    /// <summary>
    /// Returns the distance between the given point and line.
    /// </summary>
    /// <param name="Point">The point to be used.</param>
    /// <param name="Line">The line to be used.</param>
    /// <returns>The distance between the given point and line.</returns>
    public static double PointToLine(Point Point, Line Line)
    {
        return PointToPoint(Point, Projection.PointToLine(Point, Line));
    }

    /// <summary>
    /// Returns the distance between the given point and line segment.
    /// </summary>
    /// <param name="Point">The point to be used.</param>
    /// <param name="LineSegment">The line segment to be used.</param>
    /// <returns>The distance between the given point and line segment.</returns>
    public static double PointToLineSegment(Point Point, LineSegment LineSegment)
    {
        if (LineSegment.Point1 == LineSegment.Point2)
        {
            return PointToPoint(Point, LineSegment.Point1);
        }
        Vector vector = new Vector(LineSegment.Point2 - LineSegment.Point1);
        double num = Vector.Dot(new Vector(Point - LineSegment.Point1), vector);
        if (num <= 0.0)
        {
            return PointToPoint(Point, LineSegment.Point1);
        }
        if (Vector.Dot(vector, vector) <= num)
        {
            return PointToPoint(Point, LineSegment.Point2);
        }
        return PointToLine(Point, new Line(LineSegment));
    }

    /// <summary>
    /// Returns the distance between the given point and plane.
    /// </summary>
    /// <param name="Point">The point to be used.</param>
    /// <param name="Plane">The plane to be used.</param>
    /// <returns>The distance between the given point and plane.</returns>
    public static double PointToPlane(Point Point, GeometricPlane Plane)
    {
        return PointToPoint(Point, Projection.PointToPlane(Point, Plane));
    }
}
