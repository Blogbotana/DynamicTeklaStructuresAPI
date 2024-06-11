using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class HierarchicObject  : ModelObject
{


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

    public HierarchicDefinition Definition
    {
        get
        {
            try
            {
            var value = teklaObject.Definition;
            var value_ = HierarchicDefinition_.FromTSObject(value);
            return (HierarchicDefinition) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Definition), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = HierarchicDefinition_.GetTSObject(value);
            teklaObject.Definition = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Definition), ex); 
            }
        }
    }

    public HierarchicObject Father
    {
        get
        {
            try
            {
            var value = teklaObject.Father;
            var value_ = HierarchicObject_.FromTSObject(value);
            return (HierarchicObject) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Father), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = HierarchicObject_.GetTSObject(value);
            teklaObject.Father = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Father), ex); 
            }
        }
    }

    public System.Collections.ArrayList HierarchicChildren
    {
        get
        {
            try
            {
            var value = teklaObject.HierarchicChildren;
            var value_ = ArrayListConverter.FromTSObjects(value);
            return (System.Collections.ArrayList) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(HierarchicChildren), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = ArrayListConverter.ToTSObjects(value);
            teklaObject.HierarchicChildren = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(HierarchicChildren), ex); 
            }
        }
    }
    

    

		public HierarchicObject()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.HierarchicObject");
		}
		
		public HierarchicObject(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public HierarchicObject(Dynamic.Tekla.Structures.Identifier ID)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.HierarchicObject", args);
		}


    public bool AddObjects(
			System.Collections.ArrayList Objects_)
    {
        var Objects = ArrayListConverter.ToTSObjects(Objects_);
        try
        {
            var result = (bool) teklaObject.AddObjects(Objects);
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddObjects), ex);
        }
    }



    public bool RemoveObjects(
			System.Collections.ArrayList Objects_)
    {
        var Objects = ArrayListConverter.ToTSObjects(Objects_);
        try
        {
            var result = (bool) teklaObject.RemoveObjects(Objects);
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveObjects), ex);
        }
    }






}

internal static class HierarchicObject_
{
    public static dynamic GetTSObject(HierarchicObject dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static HierarchicObject FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (HierarchicObject)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class HierarchicObjectArray_
{
    public static dynamic GetTSObject(HierarchicObject[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(HierarchicObject_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static HierarchicObject[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<HierarchicObject>();
        foreach(var tsItem in tsArray)
        {
            list.Add(HierarchicObject_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

