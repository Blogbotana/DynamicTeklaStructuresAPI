namespace Dynamic.Tekla.Structures.Geometry3d;
public class GeometryConstants
{
    /// <summary>
    /// The minimum distance used for checking if points, lines, etc. coincide.
    /// Anything smaller will be considered equivalent to 0.0.
    /// </summary>
    public const double DISTANCE_EPSILON = 0.0001;

    /// <summary>
    /// The minimum angle (radians) used for checking angular parallelism, perpendicularity, etc.
    /// Anything smaller will be considered equivalent to 0.0.
    /// </summary>
    public const double ANGULAR_EPSILON = 0.0017453292519943296;

    /// <summary>
    /// The minimum value used for comparing floating point scalar values. Any smaller difference will be considered
    /// equivalent to 0.0.
    /// </summary>
    public const double SCALAR_EPSILON = 1E-13;
}
