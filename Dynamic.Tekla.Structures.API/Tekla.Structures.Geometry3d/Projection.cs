namespace Dynamic.Tekla.Structures.Geometry3d;
/// <summary>
/// The Projection class contains methods for calculating the projection of geometric objects on
/// other geometric objects.
/// </summary>
public static class Projection
{
    /// <summary>
    /// Returns a new point which is a projection of the given point onto the given line.
    /// </summary>
    /// <param name="Point">The point to be used.</param>
    /// <param name="Line">The line to be used.</param>
    /// <returns>The new projection point.</returns>
    public static Point PointToLine(Point Point, Line Line)
    {
        Vector direction = Line.Direction;
        double num = Vector.Dot(new Vector(Point - Line.Origin), direction) / Vector.Dot(direction, direction);
        return new Point(Line.Origin + num * direction);
    }

    /// <summary>
    /// Returns a new point which is a projection of the given point onto the given plane.
    /// </summary>
    /// <param name="Point">The point to be used.</param>
    /// <param name="Plane">The plane to be used.</param>
    /// <returns>The new projection point.</returns>
    public static Point PointToPlane(Point Point, GeometricPlane Plane)
    {
        Vector normal = Plane.GetNormal();
        double num = 0.0 - Vector.Dot(normal, new Vector(Point - Plane.Origin));
        double num2 = Vector.Dot(normal, normal);
        double num3 = num / num2;
        return new Point(Point + num3 * normal);
    }

    /// <summary>
    /// Returns a new line which is a projection of the given line onto the given plane.
    /// </summary>
    /// <param name="Line">The line to be used.</param>
    /// <param name="Plane">The plane to be used.</param>
    /// <returns>The new projection line.</returns>
    public static Line LineToPlane(Line Line, GeometricPlane Plane)
    {
        return new Line(PointToPlane(Line.Origin, Plane), PointToPlane(Line.Origin + Line.Direction, Plane));
    }

    /// <summary>
    /// Returns a new line segment which is a projection of the given line segment onto the given plane.
    /// </summary>
    /// <param name="LineSegment">The line segment to be used.</param>
    /// <param name="Plane">The plane to be used.</param>
    /// <returns>The new projection line segment.</returns>
    public static LineSegment LineSegmentToPlane(LineSegment LineSegment, GeometricPlane Plane)
    {
        return new LineSegment(PointToPlane(LineSegment.Point1, Plane), PointToPlane(LineSegment.Point2, Plane));
    }
}
