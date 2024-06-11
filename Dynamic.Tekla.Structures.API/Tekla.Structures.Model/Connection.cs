using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;


public sealed class Connection  : BaseComponent
{


    public int Class
    {
        get
        {
            try
            {
            return teklaObject.Class;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Class), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.Class = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Class), ex); 
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

    public Dynamic.Tekla.Structures.AutoDirectionTypeEnum AutoDirectionType
    {
        get
        {
            try
            {
            var value = teklaObject.AutoDirectionType;
            var value_ = Dynamic.Tekla.Structures.AutoDirectionTypeEnum_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.AutoDirectionTypeEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AutoDirectionType), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.AutoDirectionTypeEnum_.GetTSObject(value);
            teklaObject.AutoDirectionType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AutoDirectionType), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.PositionTypeEnum PositionType
    {
        get
        {
            try
            {
            var value = teklaObject.PositionType;
            var value_ = Dynamic.Tekla.Structures.PositionTypeEnum_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.PositionTypeEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PositionType), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.PositionTypeEnum_.GetTSObject(value);
            teklaObject.PositionType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PositionType), ex); 
            }
        }
    }

    public string Code
    {
        get
        {
            try
            {
            return teklaObject.Code;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Code), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.Code = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Code), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.ConnectionStatusEnum Status
    {
        get
        {
            try
            {
            var value = teklaObject.Status;
            var value_ = Dynamic.Tekla.Structures.ConnectionStatusEnum_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.ConnectionStatusEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Status), ex); 
            }
        }
        
    }
    

    

		public Connection()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Connection");
		}
		
		public Connection(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}


    public bool SetPrimaryObject(
			ModelObject M_)
    {
        var M = ModelObject_.GetTSObject(M_);
        try
        {
            var result = (bool) teklaObject.SetPrimaryObject(M);
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetPrimaryObject), ex);
        }
    }



    public ModelObject GetPrimaryObject()
    {
        
        try
        {
            var result = teklaObject.GetPrimaryObject();
        
            var _result = ModelObject_.FromTSObject(result);
				return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPrimaryObject), ex);
        }
    }



    public bool SetSecondaryObject(
			ModelObject M_)
    {
        var M = ModelObject_.GetTSObject(M_);
        try
        {
            var result = (bool) teklaObject.SetSecondaryObject(M);
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetSecondaryObject), ex);
        }
    }



    public bool SetSecondaryObjects(
			System.Collections.ArrayList Secondaries_)
    {
        var Secondaries = ArrayListConverter.ToTSObjects(Secondaries_);
        try
        {
            var result = (bool) teklaObject.SetSecondaryObjects(Secondaries);
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetSecondaryObjects), ex);
        }
    }



    public System.Collections.ArrayList GetSecondaryObjects()
    {
        
        try
        {
            var result = teklaObject.GetSecondaryObjects();
        
            var _result = ArrayListConverter.FromTSObjects(result);
				return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSecondaryObjects), ex);
        }
    }






}

internal static class Connection_
{
    public static dynamic GetTSObject(Connection dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Connection FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Connection)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ConnectionArray_
{
    public static dynamic GetTSObject(Connection[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(Connection_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static Connection[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<Connection>();
        foreach(var tsItem in tsArray)
        {
            list.Add(Connection_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

