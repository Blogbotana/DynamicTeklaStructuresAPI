using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public sealed class CurvedRebarGroup : BaseRebarGroup
{


    public Polygon Polygon
    {
        get
        {
            try
            {
            var value = teklaObject.Polygon;
            var value_ = Polygon_.FromTSObject(value);
            return (Polygon) value_;
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
    

    

		public CurvedRebarGroup()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CurvedRebarGroup");
		}
		
		public CurvedRebarGroup(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





}

internal static class CurvedRebarGroup_
{
    public static dynamic GetTSObject(CurvedRebarGroup dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static CurvedRebarGroup FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (CurvedRebarGroup)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class CurvedRebarGroupArray_
{
    public static dynamic GetTSObject(CurvedRebarGroup[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(CurvedRebarGroup_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static CurvedRebarGroup[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<CurvedRebarGroup>();
        foreach(var tsItem in tsArray)
        {
            list.Add(CurvedRebarGroup_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

