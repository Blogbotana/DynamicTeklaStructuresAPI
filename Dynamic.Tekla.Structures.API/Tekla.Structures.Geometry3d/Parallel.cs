using System;

namespace Dynamic.Tekla.Structures.Geometry3d;
public static class Parallel
{/// <summary>
 /// Returns true if the given vectors are parallel.
 /// </summary>
 /// <param name="Vector1">The first vector to be used.</param>
 /// <param name="Vector2">The second vector to be used.</param>
 /// <returns>True if the given vectors are parallel.</returns>
    public static bool VectorToVector(Vector Vector1, Vector Vector2)
    {
        return VectorToVector(Vector1, Vector2, GeometryConstants.ANGULAR_EPSILON);
    }

    /// <summary>
    /// Returns true if the given vectors are parallel within the given angular tolerance.
    /// </summary>
    /// <param name="Vector1">The first vector to be used.</param>
    /// <param name="Vector2">The second vector to be used.</param>
    /// <param name="Tolerance">The angular tolerance (in radians) to be used.</param>
    /// <returns>True if the given vectors are parallel within the given tolerance.</returns>
    public static bool VectorToVector(Vector Vector1, Vector Vector2, double Tolerance)
    {
        Vector normal = Vector1.GetNormal();
        Vector normal2 = Vector2.GetNormal();
        double num = Vector.Dot(normal, normal2);
        if (num > 1.0)
        {
            num = 1.0;
        }
        else if (num < -1.0)
        {
            num = -1.0;
        }
        return Math.Acos(Math.Abs(num)) <= Tolerance;
    }

    /// <summary>
    /// Returns true if the given lines are parallel.
    /// </summary>
    /// <param name="Line1">The first line to be used.</param>
    /// <param name="Line2">The second line to be used.</param>
    /// <returns>True if the given lines are parallel.</returns>
    public static bool LineToLine(Line Line1, Line Line2)
    {
        return LineToLine(Line1, Line2, GeometryConstants.ANGULAR_EPSILON);
    }

    /// <summary>
    /// Returns true if the given lines are parallel within the given angular tolerance.
    /// </summary>
    /// <param name="Line1">The first line to be used.</param>
    /// <param name="Line2">The second line to be used.</param>
    /// <param name="Tolerance">The angular tolerance (in radians) to be used.</param>
    /// <returns>True if the given lines are parallel within the given tolerance.</returns>
    public static bool LineToLine(Line Line1, Line Line2, double Tolerance)
    {
        return VectorToVector(Line1.Direction, Line2.Direction, Tolerance);
    }

    /// <summary>
    /// Returns true if the given line segments are parallel.
    /// </summary>
    /// <param name="LineSegment1">The first line segment to be used.</param>
    /// <param name="LineSegment2">The second line segment to be used.</param>
    /// <returns>True if the given line segments are parallel.</returns>
    public static bool LineSegmentToLineSegment(LineSegment LineSegment1, LineSegment LineSegment2)
    {
        return LineSegmentToLineSegment(LineSegment1, LineSegment2, GeometryConstants.ANGULAR_EPSILON);
    }

    /// <summary>
    /// Returns true if the given line segments are parallel within the given angular tolerance.
    /// </summary>
    /// <param name="LineSegment1">The first line segment to be used.</param>
    /// <param name="LineSegment2">The second line segment to be used.</param>
    /// <param name="Tolerance">The angular tolerance (in radians) to be used.</param>
    /// <returns>True if the given line segments are parallel within the given tolerance.</returns>
    public static bool LineSegmentToLineSegment(LineSegment LineSegment1, LineSegment LineSegment2, double Tolerance)
    {
        return VectorToVector(LineSegment1.GetDirectionVector(), LineSegment2.GetDirectionVector(), Tolerance);
    }

    /// <summary>
    /// Returns true if the given planes are parallel.
    /// </summary>
    /// <param name="Plane1">The first plane to be used.</param>
    /// <param name="Plane2">The second plane to be used.</param>
    /// <returns>True if the given planes are parallel.</returns>
    public static bool PlaneToPlane(GeometricPlane Plane1, GeometricPlane Plane2)
    {
        return PlaneToPlane(Plane1, Plane2, GeometryConstants.ANGULAR_EPSILON);
    }

    /// <summary>
    /// Returns true if the given planes are parallel within the given angular tolerance.
    /// </summary>
    /// <param name="Plane1">The first plane to be used.</param>
    /// <param name="Plane2">The second plane to be used.</param>
    /// <param name="Tolerance">The angular tolerance (in radians) to be used.</param>
    /// <returns>True if the given planes are parallel within the given tolerance.</returns>
    public static bool PlaneToPlane(GeometricPlane Plane1, GeometricPlane Plane2, double Tolerance)
    {
        return VectorToVector(Plane1.GetNormal(), Plane2.GetNormal(), Tolerance);
    }

    /// <summary>
    /// Returns true if the given vector and plane are parallel.
    /// </summary>
    /// <param name="Vector">The vector to be used.</param>
    /// <param name="Plane">The plane to be used.</param>
    /// <returns>True if the given vector and plane are parallel.</returns>
    public static bool VectorToPlane(Vector Vector, GeometricPlane Plane)
    {
        return VectorToPlane(Vector, Plane, GeometryConstants.ANGULAR_EPSILON);
    }

    /// <summary>
    /// Returns true if the given vector and plane are parallel within the given angular tolerance.
    /// </summary>
    /// <param name="Vector">The vector to be used.</param>
    /// <param name="Plane">The plane to be used.</param>
    /// <param name="Tolerance">The angular tolerance (in radians) to be used.</param>
    /// <returns>True if the given vector and plane are parallel within the given tolerance.</returns>
    public static bool VectorToPlane(Vector Vector, GeometricPlane Plane, double Tolerance)
    {
        Vector normal = Plane.GetNormal();
        Vector normal2 = Vector.GetNormal();
        double num = Vector.Dot(normal, normal2);
        if (num > 1.0)
        {
            num = 1.0;
        }
        else if (num < -1.0)
        {
            num = -1.0;
        }
        return Math.Abs(Math.PI / 2.0 - Math.Acos(num)) <= Tolerance;
    }

    /// <summary>
    /// Returns true if the given line and plane are parallel.
    /// </summary>
    /// <param name="Line">The line to be used.</param>
    /// <param name="Plane">The plane to be used.</param>
    /// <returns>True if the given line and plane are parallel.</returns>
    public static bool LineToPlane(Line Line, GeometricPlane Plane)
    {
        return LineToPlane(Line, Plane, GeometryConstants.ANGULAR_EPSILON);
    }

    /// <summary>
    /// Returns true if the given line and plane are parallel within the given angular tolerance.
    /// </summary>
    /// <param name="Line">The line to be used.</param>
    /// <param name="Plane">The plane to be used.</param>
    /// <param name="Tolerance">The angular tolerance (in radians) to be used.</param>
    /// <returns>True if the given line and plane are parallel within the given tolerance.</returns>
    public static bool LineToPlane(Line Line, GeometricPlane Plane, double Tolerance)
    {
        return VectorToPlane(Line.Direction, Plane, Tolerance);
    }

    /// <summary>
    /// Returns true if the given line segment and plane are parallel.
    /// </summary>
    /// <param name="LineSegment">The line segment to be used.</param>
    /// <param name="Plane">The plane to be used.</param>
    /// <returns>True if the given line segment and plane are parallel.</returns>
    public static bool LineSegmentToPlane(LineSegment LineSegment, GeometricPlane Plane)
    {
        return LineSegmentToPlane(LineSegment, Plane, GeometryConstants.ANGULAR_EPSILON);
    }

    /// <summary>
    /// Returns true if the given line segment and plane are parallel within the given angular tolerance.
    /// </summary>
    /// <param name="LineSegment">The line segment to be used.</param>
    /// <param name="Plane">The plane to be used.</param>
    /// <param name="Tolerance">The angular tolerance (in radians) to be used.</param>
    /// <returns>True if the given line segment and plane are parallel within the given tolerance.</returns>
    public static bool LineSegmentToPlane(LineSegment LineSegment, GeometricPlane Plane, double Tolerance)
    {
        return VectorToPlane(LineSegment.GetDirectionVector(), Plane, Tolerance);
    }
}
