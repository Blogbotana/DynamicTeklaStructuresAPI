using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;
using System.Collections;

namespace Dynamic.Tekla.Structures.Model;


public  class GeometrySectionEnumerator  : IEnumerator
{


    public GeometrySection Current
    {
        get
        {
            try
            {
            var value = teklaObject.Current;
            var value_ = GeometrySection_.FromTSObject(value);
            return (GeometrySection) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Current), ex); 
            }
        }
        
    }
    object IEnumerator.Current => Current;

    internal dynamic teklaObject;

		internal GeometrySectionEnumerator() {}
		
		public GeometrySectionEnumerator(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}


    public bool MoveNext()
    {
        
        try
        {
            var result = (bool) teklaObject.MoveNext();
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(MoveNext), ex);
        }
    }



    public void Reset()
    {
        
        try
        {
            teklaObject.Reset();
        
            
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Reset), ex);
        }
    }






}

internal static class GeometrySectionEnumerator_
{
    public static dynamic GetTSObject(GeometrySectionEnumerator dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static GeometrySectionEnumerator FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (GeometrySectionEnumerator)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class GeometrySectionEnumeratorArray_
{
    public static dynamic GetTSObject(GeometrySectionEnumerator[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(GeometrySectionEnumerator_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static GeometrySectionEnumerator[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<GeometrySectionEnumerator>();
        foreach(var tsItem in tsArray)
        {
            list.Add(GeometrySectionEnumerator_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

