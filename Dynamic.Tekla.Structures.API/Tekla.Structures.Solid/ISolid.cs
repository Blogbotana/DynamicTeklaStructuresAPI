using Dynamic.Tekla.Structures.Geometry3d;

namespace Dynamic.Tekla.Structures.Solid;
/// <summary>
/// The ISolid interface represents a physical object in the model or a drawing created by a part instance.
/// The solid instance can be used to query the actual geometry of the part.
/// </summary>
public interface ISolid
{
    /// <summary>
    /// The minimum axis-aligned point of the solid in the current plane.
    /// </summary>
    Point MinimumPoint { get; }

    /// <summary>
    /// The maximum axis-aligned point of the solid in the current plane.
    /// </summary>
    Point MaximumPoint { get; }

    /// <summary>
    /// Returns a new face enumerator in the current plane.
    /// </summary>
    /// <returns>A face enumerator to enumerate through the solid's faces.</returns>
    FaceEnumerator GetFaceEnumerator();

    /// <summary>
    /// Returns a new edge enumerator in the current plane.
    /// </summary>
    /// <returns>An edge enumerator to enumerate through the solid's global edges.</returns>
    EdgeEnumerator GetEdgeEnumerator();
}
