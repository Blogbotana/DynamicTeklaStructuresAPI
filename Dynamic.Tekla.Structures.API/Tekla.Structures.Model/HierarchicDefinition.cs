using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public sealed class HierarchicDefinition  : ModelObject
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

    public string CustomType
    {
        get
        {
            try
            {
            return teklaObject.CustomType;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CustomType), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.CustomType = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CustomType), ex); 
            }
        }
    }

    public HierarchicDefinitionTypeEnum HierarchyType
    {
        get
        {
            try
            {
            var value = teklaObject.HierarchyType;
            var value_ = HierarchicDefinitionTypeEnum_.FromTSObject(value);
            return (HierarchicDefinitionTypeEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(HierarchyType), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = HierarchicDefinitionTypeEnum_.GetTSObject(value);
            teklaObject.HierarchyType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(HierarchyType), ex); 
            }
        }
    }

    public HierarchicDefinition Father
    {
        get
        {
            try
            {
            var value = teklaObject.Father;
            var value_ = HierarchicDefinition_.FromTSObject(value);
            return (HierarchicDefinition) value_;
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
            var value_ = HierarchicDefinition_.GetTSObject(value);
            teklaObject.Father = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Father), ex); 
            }
        }
    }

    public string HierarchyIdentifier
    {
        get
        {
            try
            {
            return teklaObject.HierarchyIdentifier;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(HierarchyIdentifier), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.HierarchyIdentifier = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(HierarchyIdentifier), ex); 
            }
        }
    }

    public bool Drawable
    {
        get
        {
            try
            {
            return teklaObject.Drawable;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Drawable), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.Drawable = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Drawable), ex); 
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
    

    

		public HierarchicDefinition()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.HierarchicDefinition");
		}
		
		public HierarchicDefinition(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public HierarchicDefinition(Dynamic.Tekla.Structures.Identifier ID)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.HierarchicDefinition", args);
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

internal static class HierarchicDefinition_
{
    public static dynamic GetTSObject(HierarchicDefinition dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static HierarchicDefinition FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (HierarchicDefinition)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class HierarchicDefinitionArray_
{
    public static dynamic GetTSObject(HierarchicDefinition[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(HierarchicDefinition_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static HierarchicDefinition[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<HierarchicDefinition>();
        foreach(var tsItem in tsArray)
        {
            list.Add(HierarchicDefinition_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

