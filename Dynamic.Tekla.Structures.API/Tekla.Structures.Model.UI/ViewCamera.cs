using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;
namespace Dynamic.Tekla.Structures.Model.UI;


public  class ViewCamera 
{


    public Dynamic.Tekla.Structures.Geometry3d.Point Location
    {
        get
        {
            try
            {
            var value = teklaObject.Location;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Location), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
            teklaObject.Location = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Location), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Vector DirectionVector
    {
        get
        {
            try
            {
            var value = teklaObject.DirectionVector;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DirectionVector), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
            teklaObject.DirectionVector = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DirectionVector), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Vector UpVector
    {
        get
        {
            try
            {
            var value = teklaObject.UpVector;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(UpVector), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
            teklaObject.UpVector = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(UpVector), ex); 
            }
        }
    }

    public System.Double FieldOfView
    {
        get
        {
            try
            {
            return teklaObject.FieldOfView;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FieldOfView), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.FieldOfView = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FieldOfView), ex); 
            }
        }
    }

    public System.Double ZoomFactor
    {
        get
        {
            try
            {
            return teklaObject.ZoomFactor;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ZoomFactor), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.ZoomFactor = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ZoomFactor), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Model.UI.View View
    {
        get
        {
            try
            {
            var value = teklaObject.View;
            var value_ = Dynamic.Tekla.Structures.Model.UI.View_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Model.UI.View) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(View), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(value);
            teklaObject.View = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(View), ex); 
            }
        }
    }
    

    internal dynamic teklaObject;

		public ViewCamera()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.ViewCamera");
		}
		
		public ViewCamera(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}


    public System.Boolean Select()
    {
        
        try
        {
            var result = (System.Boolean) teklaObject.Select();
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
        }
    }



    public System.Boolean Modify()
    {
        
        try
        {
            var result = (System.Boolean) teklaObject.Modify();
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Modify), ex);
        }
    }






}

internal static class ViewCamera_
{
    public static dynamic GetTSObject(ViewCamera dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ViewCamera FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Model.UI.ViewCamera)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ViewCameraArray_
{
    public static dynamic GetTSObject(ViewCamera[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(ViewCamera_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static ViewCamera[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<ViewCamera>();
        foreach(var tsItem in tsArray)
        {
            list.Add(ViewCamera_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

