namespace Dynamic.Tekla.Structures.Model;
public interface IGeometryNode
{
    /// <summary>
    /// Gets a value indicating whether this geometry node was automatically generated (i.e. false if it was originally a user-defined part)
    /// </summary>
    bool IsAutomatic { get; }

    /// <summary>
    /// Entry method for the visitor pattern
    /// </summary>
    /// <param name="visitor"></param>
    void AcceptVisitor(IGeometryNodeVisitor visitor);

    /// <summary>
    /// Creates a new object that is a copy of the current instance.
    /// </summary>
    /// <returns>A new object that is a copy of the current instance.</returns>
    IGeometryNode Clone();
    public dynamic teklaObject { get; set; }
}
internal static class IGeometryNode_
{
    public static dynamic GetTSObject(IGeometryNode dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static IGeometryNode FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (IGeometryNode)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}