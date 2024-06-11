using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public class PourUnit : ModelObject
{


    public string Name
    {
        get
        {
            try
            {
                return teklaObject.Name;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Name = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex);
            }
        }
    }




    public PourUnit()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PourUnit");
    }

    public PourUnit(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }


    public ModelObjectEnumerator GetObjects()
    {

        try
        {
            var result = teklaObject.GetObjects();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetObjects), ex);
        }
    }



    public PourObject GetPourObject()
    {

        try
        {
            var result = teklaObject.GetPourObject();

            var _result = PourObject_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPourObject), ex);
        }
    }






}

internal static class PourUnit_
{
    public static dynamic GetTSObject(PourUnit dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static PourUnit FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (PourUnit)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class PourUnitArray_
{
    public static dynamic GetTSObject(PourUnit[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(PourUnit_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static PourUnit[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<PourUnit>();
        foreach (var tsItem in tsArray)
        {
            list.Add(PourUnit_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}




