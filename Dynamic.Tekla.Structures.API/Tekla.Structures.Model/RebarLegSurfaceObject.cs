using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public class RebarLegSurfaceObject : SurfaceObject
{


    public RebarSet RebarSet
    {
        get
        {
            try
            {
                var value = teklaObject.RebarSet;
                var value_ = RebarSet_.FromTSObject(value);
                return (RebarSet)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarSet), ex);
            }
        }
        set
        {
            try
            {
                var value_ = RebarSet_.GetTSObject(value);
                teklaObject.RebarSet = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarSet), ex);
            }
        }
    }

    public int LayerNumber
    {
        get
        {
            try
            {
                return teklaObject.LayerNumber;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LayerNumber), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.LayerNumber = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LayerNumber), ex);
            }
        }
    }

    public double AdditionalOffset
    {
        get
        {
            try
            {
                return teklaObject.AdditionalOffset;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AdditionalOffset), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.AdditionalOffset = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AdditionalOffset), ex);
            }
        }
    }




    public RebarLegSurfaceObject()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLegSurfaceObject");
    }

    public RebarLegSurfaceObject(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }





}

internal static class RebarLegSurfaceObject_
{
    public static dynamic GetTSObject(RebarLegSurfaceObject dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static RebarLegSurfaceObject FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (RebarLegSurfaceObject)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class RebarLegSurfaceObjectArray_
{
    public static dynamic GetTSObject(RebarLegSurfaceObject[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(RebarLegSurfaceObject_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static RebarLegSurfaceObject[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<RebarLegSurfaceObject>();
        foreach (var tsItem in tsArray)
        {
            list.Add(RebarLegSurfaceObject_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}




