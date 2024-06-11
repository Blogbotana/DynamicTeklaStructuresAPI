namespace Dynamic.Tekla.Structures.Model;
/// <summary>
/// The IGeometryNodeVisitor interface is implemented by classes visiting geometry nodes
/// </summary>
public interface IGeometryNodeVisitor
{
    /// <summary>
    /// Visits a node that is an instance of PolygonNode node
    /// </summary>
    /// <param name="node"></param>
    void Visit(PolygonNode node);

    /// <summary>
    /// Visits a node that is an instance of CylindricalSurfaceNode
    /// </summary>
    /// <param name="node"></param>
    void Visit(CylindricalSurfaceNode node);

    abstract dynamic teklaObject { get; set; }
}
internal static class IGeometryNodeVisitor_
{
    public static dynamic GetTSObject(IGeometryNodeVisitor dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static IGeometryNodeVisitor FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (IGeometryNodeVisitor)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
