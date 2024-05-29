using Dynamic.Tekla.Structures.Geometry3d;
using System;

namespace Dynamic.Tekla.Structures.Geometry3d;
public interface ICurve : IEquatable<ICurve>
{
    /// <summary>
    /// Gets the start point of the curve
    /// </summary>
    Point StartPoint { get; }

    /// <summary>
    /// Gets the end point of the curve. May be the same as <see cref="StartPoint" /> if the curve is closed.
    /// </summary>
    Point EndPoint { get; }

    /// <summary>
    /// Gets the length of the curve
    /// </summary>
    double Length { get; }

    /// <summary>
    /// Returns a deep copy of the geometry
    /// </summary>
    /// <returns>Copy of self</returns>
    ICurve Clone();
}
