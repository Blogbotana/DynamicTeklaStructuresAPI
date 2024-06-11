using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public sealed class ControlPlane : ModelObject
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

    public bool IsMagnetic
    {
        get
        {
            try
            {
            return teklaObject.IsMagnetic;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsMagnetic), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.IsMagnetic = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsMagnetic), ex); 
            }
        }
    }

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
    

    

		public ControlPlane()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlPlane");
		}
		
		public ControlPlane(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public ControlPlane(Plane P, bool IsMagnetic)
		{
			var args = new object[2];
			args[0] = Plane_.GetTSObject(P);
			args[1] = IsMagnetic;
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlPlane", args);
		}





}

internal static class ControlPlane_
{
    public static dynamic GetTSObject(ControlPlane dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ControlPlane FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ControlPlane)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ControlPlaneArray_
{
    public static dynamic GetTSObject(ControlPlane[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(ControlPlane_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static ControlPlane[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<ControlPlane>();
        foreach(var tsItem in tsArray)
        {
            list.Add(ControlPlane_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

