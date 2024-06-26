using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model.UI;


public  class Mesh 
{


    public System.Collections.ArrayList Points
    {
        get
        {
            try
            {
            var value = teklaObject.Points;
            var value_ = ArrayListConverter.FromTSObjects(value);
            return (System.Collections.ArrayList) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Points), ex); 
            }
        }
        
    }

    public System.Collections.ArrayList Triangles
    {
        get
        {
            try
            {
            var value = teklaObject.Triangles;
            var value_ = ArrayListConverter.FromTSObjects(value);
            return (System.Collections.ArrayList) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Triangles), ex); 
            }
        }
        
    }

    public System.Collections.ArrayList Lines
    {
        get
        {
            try
            {
            var value = teklaObject.Lines;
            var value_ = ArrayListConverter.FromTSObjects(value);
            return (System.Collections.ArrayList) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Lines), ex); 
            }
        }
        
    }
    

    internal dynamic teklaObject;

		public Mesh()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.Mesh");
		}
		
		public Mesh(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Mesh(System.Collections.ArrayList Points, System.Collections.ArrayList Triangles, System.Collections.ArrayList Lines)
		{
			var args = new object[3];
			args[0] = Points;
			args[1] = Triangles;
			args[2] = Lines;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.Mesh", args);
		}


    public System.Int32 AddPoint(
			Dynamic.Tekla.Structures.Geometry3d.Point Point_)
    {
        var Point = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Point_);
        try
        {
            var result = (System.Int32) teklaObject.AddPoint(Point);
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddPoint), ex);
        }
    }



    public void AddTriangle(
			System.Int32 Index1,
			System.Int32 Index2,
			System.Int32 Index3)
    {

        try
        {
            teklaObject.AddTriangle(Index1, Index2, Index3);
        
            
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddTriangle), ex);
        }
    }



    public void AddLine(
			System.Int32 Index1,
			System.Int32 Index2)
    {
        try
        {
            teklaObject.AddLine(Index1, Index2);
        
            
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddLine), ex);
        }
    }






}

internal static class Mesh_
{
    public static dynamic GetTSObject(Mesh dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Mesh FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Model.UI.Mesh)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class MeshArray_
{
    public static dynamic GetTSObject(Mesh[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(Mesh_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static Mesh[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<Mesh>();
        foreach(var tsItem in tsArray)
        {
            list.Add(Mesh_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

