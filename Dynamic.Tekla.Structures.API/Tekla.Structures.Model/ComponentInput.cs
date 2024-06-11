using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;
public  class ComponentInput 
{


    public int Count
    {
        get
        {
            try
            {
            return teklaObject.Count;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Count), ex); 
            }
        }
        
    }

    public bool IsSynchronized
    {
        get
        {
            try
            {
            return teklaObject.IsSynchronized;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsSynchronized), ex); 
            }
        }
        
    }

    public System.Object SyncRoot
    {
        get
        {
            try
            {
            return teklaObject.SyncRoot;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SyncRoot), ex); 
            }
        }
        
    }
    

    internal dynamic teklaObject;

		public ComponentInput()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ComponentInput");
		}
		
		public ComponentInput(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}


    public bool AddOneInputPosition(
			Dynamic.Tekla.Structures.Geometry3d.Point P_)
    {
        var P = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(P_);
        try
        {
            var result = (bool) teklaObject.AddOneInputPosition(P);
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddOneInputPosition), ex);
        }
    }



    public bool AddTwoInputPositions(
			Dynamic.Tekla.Structures.Geometry3d.Point Position1_,
			Dynamic.Tekla.Structures.Geometry3d.Point Position2_)
    {
        var Position1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Position1_);
var Position2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Position2_);
        try
        {
            var result = (bool) teklaObject.AddTwoInputPositions(Position1, Position2);
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddTwoInputPositions), ex);
        }
    }



    public bool AddInputPolygon(
			Polygon P_)
    {
        var P = Polygon_.GetTSObject(P_);
        try
        {
            var result = (bool) teklaObject.AddInputPolygon(P);
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddInputPolygon), ex);
        }
    }



    public bool AddInputObject(
			ModelObject M_)
    {
        var M = ModelObject_.GetTSObject(M_);
        try
        {
            var result = (bool) teklaObject.AddInputObject(M);
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddInputObject), ex);
        }
    }



    public bool AddInputObjects(
			System.Collections.ArrayList Objects_)
    {
        var Objects = ArrayListConverter.ToTSObjects(Objects_);
        try
        {
            var result = (bool) teklaObject.AddInputObjects(Objects);
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddInputObjects), ex);
        }
    }






}

internal static class ComponentInput_
{
    public static dynamic GetTSObject(ComponentInput dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ComponentInput FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ComponentInput)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ComponentInputArray_
{
    public static dynamic GetTSObject(ComponentInput[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(ComponentInput_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static ComponentInput[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<ComponentInput>();
        foreach(var tsItem in tsArray)
        {
            list.Add(ComponentInput_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

