using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class GeometrySection 
{


    public int Index
    {
        get
        {
            try
            {
            return teklaObject.Index;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Index), ex); 
            }
        }
        
    }

    public IGeometryNode GeometryNode
    {
        get
        {
            try
            {
            var value = teklaObject.GeometryNode;
            var value_ = IGeometryNode_.FromTSObject(value);
            return (IGeometryNode) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(GeometryNode), ex); 
            }
        }
        
    }
    

    internal dynamic teklaObject;

		internal GeometrySection() {}
		
		public GeometrySection(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





}

internal static class GeometrySection_
{
    public static dynamic GetTSObject(GeometrySection dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static GeometrySection FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (GeometrySection)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class GeometrySectionArray_
{
    public static dynamic GetTSObject(GeometrySection[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(GeometrySection_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static GeometrySection[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<GeometrySection>();
        foreach(var tsItem in tsArray)
        {
            list.Add(GeometrySection_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

