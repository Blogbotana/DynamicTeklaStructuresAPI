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
    public dynamic teklaObject { get; set; }
}
internal static class ICurve_
{
    public static dynamic GetTSObject(ICurve dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ICurve FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ICurve)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
