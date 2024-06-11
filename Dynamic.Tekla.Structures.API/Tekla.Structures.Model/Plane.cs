using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public class Plane
{


    public Dynamic.Tekla.Structures.Geometry3d.Point Origin
    {
        get
        {
            try
            {
                var value = teklaObject.Origin;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Origin), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.Origin = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Origin), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Vector AxisX
    {
        get
        {
            try
            {
                var value = teklaObject.AxisX;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AxisX), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
                teklaObject.AxisX = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AxisX), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Vector AxisY
    {
        get
        {
            try
            {
                var value = teklaObject.AxisY;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AxisY), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
                teklaObject.AxisY = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AxisY), ex);
            }
        }
    }


    internal dynamic teklaObject;

    public Plane()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Plane");
    }

    public Plane(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }





}

internal static class Plane_
{
    public static dynamic GetTSObject(Plane dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Plane FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Plane)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class PlaneArray_
{
    public static dynamic GetTSObject(Plane[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(Plane_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static Plane[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<Plane>();
        foreach (var tsItem in tsArray)
        {
            list.Add(Plane_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}




