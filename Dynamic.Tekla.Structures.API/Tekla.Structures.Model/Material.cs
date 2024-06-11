using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
namespace Dynamic.Tekla.Structures.Model;

public class Material
{


    public string MaterialString
    {
        get
        {
            try
            {
                return teklaObject.MaterialString;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MaterialString), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.MaterialString = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MaterialString), ex);
            }
        }
    }


    internal dynamic teklaObject;

    public Material()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Material");
    }

    public Material(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }





}

internal static class Material_
{
    public static dynamic GetTSObject(Material dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Material FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Material)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class MaterialArray_
{
    public static dynamic GetTSObject(Material[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(Material_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static Material[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<Material>();
        foreach (var tsItem in tsArray)
        {
            list.Add(Material_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}



    
