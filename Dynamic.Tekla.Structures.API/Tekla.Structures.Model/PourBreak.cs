using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public class PourBreak : ModelObject
{


    public Dynamic.Tekla.Structures.Geometry3d.FacetedBrep Polymesh
    {
        get
        {
            try
            {
                var value = teklaObject.Polymesh;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.FacetedBrep)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Polymesh), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.GetTSObject(value);
                teklaObject.Polymesh = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Polymesh), ex);
            }
        }
    }




    public PourBreak()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PourBreak");
    }

    public PourBreak(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }





}

internal static class PourBreak_
{
    public static dynamic GetTSObject(PourBreak dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static PourBreak FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (PourBreak)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}


