using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class ControlPolycurve  : ModelObject
{


    public ControlObjectColorEnum Color
    {
        get
        {
            try
            {
            var value = teklaObject.Color;
            var value_ = ControlObjectColorEnum_.FromTSObject(value);
            return (ControlObjectColorEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Color), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = ControlObjectColorEnum_.GetTSObject(value);
            teklaObject.Color = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Color), ex); 
            }
        }
    }

    public ControlObjectLineType LineType
    {
        get
        {
            try
            {
            var value = teklaObject.LineType;
            var value_ = ControlObjectLineType_.FromTSObject(value);
            return (ControlObjectLineType) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LineType), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = ControlObjectLineType_.GetTSObject(value);
            teklaObject.LineType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LineType), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Polycurve Geometry
    {
        get
        {
            try
            {
            var value = teklaObject.Geometry;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Polycurve_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Polycurve) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Geometry), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Polycurve_.GetTSObject(value);
            teklaObject.Geometry = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Geometry), ex); 
            }
        }
    }
    

    

		public ControlPolycurve()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlPolycurve");
		}
		
		public ControlPolycurve(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public ControlPolycurve(Dynamic.Tekla.Structures.Geometry3d.Polycurve geometry)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Polycurve_.GetTSObject(geometry);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlPolycurve", args);
		}





}

internal static class ControlPolycurve_
{
    public static dynamic GetTSObject(ControlPolycurve dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ControlPolycurve FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ControlPolycurve)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ControlPolycurveArray_
{
    public static dynamic GetTSObject(ControlPolycurve[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(ControlPolycurve_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static ControlPolycurve[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<ControlPolycurve>();
        foreach(var tsItem in tsArray)
        {
            list.Add(ControlPolycurve_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

