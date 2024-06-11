using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public sealed class ControlArc : ModelObject
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

    public Dynamic.Tekla.Structures.Geometry3d.Arc Geometry
    {
        get
        {
            try
            {
            var value = teklaObject.Geometry;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Arc_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Arc) value_;
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
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(value);
            teklaObject.Geometry = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Geometry), ex); 
            }
        }
    }
    

    

		public ControlArc()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlArc");
		}
		
		public ControlArc(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public ControlArc(Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint, Dynamic.Tekla.Structures.Geometry3d.Point pointOnArc)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(pointOnArc);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlArc", args);
		}





}

internal static class ControlArc_
{
    public static dynamic GetTSObject(ControlArc dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ControlArc FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ControlArc)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ControlArcArray_
{
    public static dynamic GetTSObject(ControlArc[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(ControlArc_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static ControlArc[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<ControlArc>();
        foreach(var tsItem in tsArray)
        {
            list.Add(ControlArc_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

