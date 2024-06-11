using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  sealed class CutPlane  : Boolean
{


    public Plane Plane
    {
        get
        {
            try
            {
            var value = teklaObject.Plane;
            var value_ = Plane_.FromTSObject(value);
            return (Plane) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Plane), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Plane_.GetTSObject(value);
            teklaObject.Plane = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Plane), ex); 
            }
        }
    }
    

    

		public CutPlane()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CutPlane");
		}
		
		public CutPlane(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





}

internal static class CutPlane_
{
    public static dynamic GetTSObject(CutPlane dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static CutPlane FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (CutPlane)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class CutPlaneArray_
{
    public static dynamic GetTSObject(CutPlane[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(CutPlane_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static CutPlane[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<CutPlane>();
        foreach(var tsItem in tsArray)
        {
            list.Add(CutPlane_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

