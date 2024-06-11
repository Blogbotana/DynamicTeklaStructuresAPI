

namespace Dynamic.Tekla.Structures.Model;
/// <summary>
/// The IAssemblable interface dictates which model objects are capabable of belonging to an assembly at the leaf level.
/// </summary>
public interface IAssemblable
{
    /// <summary>
    /// Returns the assembly that the assemblable belongs to.
    /// </summary>
    /// <returns>The assembly that the assemblable belongs to.</returns>
    Assembly GetAssembly();
    dynamic teklaObject1 { get; set; }
}

internal static class IAssemblable_
{
    public static dynamic GetTSObject(IAssemblable dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject1;
    }

    public static IAssemblable FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Model.IAssemblable)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject1 = tsObject;
        return dynObject;
    }
}