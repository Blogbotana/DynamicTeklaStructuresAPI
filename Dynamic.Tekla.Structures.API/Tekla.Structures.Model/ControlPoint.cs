using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class ControlPoint  : ModelObject
{


    public Dynamic.Tekla.Structures.Geometry3d.Point Point
    {
        get
        {
            try
            {
            var value = teklaObject.Point;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Point), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
            teklaObject.Point = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Point), ex); 
            }
        }
    }
    

    

		public ControlPoint()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlPoint");
		}
		
		public ControlPoint(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public ControlPoint(Dynamic.Tekla.Structures.Geometry3d.Point existPoint)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(existPoint);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlPoint", args);
		}





}

internal static class ControlPoint_
{
    public static dynamic GetTSObject(ControlPoint dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ControlPoint FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ControlPoint)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ControlPointArray_
{
    public static dynamic GetTSObject(ControlPoint[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(ControlPoint_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static ControlPoint[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<ControlPoint>();
        foreach(var tsItem in tsArray)
        {
            list.Add(ControlPoint_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

