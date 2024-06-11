using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public sealed class Contour
{


    public System.Collections.ArrayList ContourPoints
    {
        get
        {
            try
            {
            var value = teklaObject.ContourPoints;
            var value_ = ArrayListConverter.FromTSObjects(value);
            return (System.Collections.ArrayList) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ContourPoints), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = ArrayListConverter.ToTSObjects(value);
            teklaObject.ContourPoints = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ContourPoints), ex); 
            }
        }
    }

    public static int MAX_CONTOUR_POINTS
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Model.Contour", "MAX_CONTOUR_POINTS");
            return (int) value;
        }
        
    }
    public static int MIN_CONTOUR_POINTS
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Model.Contour", "MIN_CONTOUR_POINTS");
            return (int) value;
        }
        
    }        

    internal dynamic teklaObject;

		public Contour()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Contour");
		}
		
		public Contour(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}


    public void AddContourPoint(
			ContourPoint Point_)
    {
        var Point = ContourPoint_.GetTSObject(Point_);
        try
        {
            teklaObject.AddContourPoint(Point);
        
            
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddContourPoint), ex);
        }
    }



    public bool CalculatePolygon(
			out Polygon polygon_)
    {
        var polygon = Polygon_.GetTSObject(null);
        try
        {
            var result = (bool) MethodInvoker.InvokeMethod("Tekla.Structures.Model.Contour", "CalculatePolygon", teklaObject, out polygon);
        polygon_ = Polygon_.FromTSObject(polygon);
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CalculatePolygon), ex);
        }
    }



    public Dynamic.Tekla.Structures.Geometry3d.Polycurve GetPolycurve()
    {
        
        try
        {
            var result = teklaObject.GetPolycurve();
        
            var _result = Dynamic.Tekla.Structures.Geometry3d.Polycurve_.FromTSObject(result);
				return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPolycurve), ex);
        }
    }






}

internal static class Contour_
{
    public static dynamic GetTSObject(Contour dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Contour FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Contour)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ContourArray_
{
    public static dynamic GetTSObject(Contour[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(Contour_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static Contour[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<Contour>();
        foreach(var tsItem in tsArray)
        {
            list.Add(Contour_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

