





using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;
public class PolygonWeld : BaseWeld
{


    public Polygon Polygon
    {
        get
        {
            try
            {
                var value = teklaObject.Polygon;
                var value_ = Polygon_.FromTSObject(value);
                return (Polygon)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Polygon), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Polygon_.GetTSObject(value);
                teklaObject.Polygon = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Polygon), ex);
            }
        }
    }




    public PolygonWeld()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PolygonWeld");
    }

    public PolygonWeld(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }


    public bool GetLogicalWeld(
        ref LogicalWeld LogicalWeld_)
    {
        var LogicalWeld = Dynamic.Tekla.Structures.Model.LogicalWeld_.GetTSObject(LogicalWeld_);
        try
        {
            var result = (bool)teklaObject.GetLogicalWeld(ref LogicalWeld);
            LogicalWeld_ = Dynamic.Tekla.Structures.Model.LogicalWeld_.FromTSObject(LogicalWeld);
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetLogicalWeld), ex);
        }
    }






}

internal static class PolygonWeld_
{
    public static dynamic GetTSObject(PolygonWeld dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static PolygonWeld FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (PolygonWeld)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class PolygonWeldArray_
{
    public static dynamic GetTSObject(PolygonWeld[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(PolygonWeld_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static PolygonWeld[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<PolygonWeld>();
        foreach (var tsItem in tsArray)
        {
            list.Add(PolygonWeld_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}




