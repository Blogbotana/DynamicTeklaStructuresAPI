using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class Fitting  : Boolean
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
    

    

		public Fitting()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Fitting");
		}
		
		public Fitting(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





}

internal static class Fitting_
{
    public static dynamic GetTSObject(Fitting dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Fitting FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Fitting)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class FittingArray_
{
    public static dynamic GetTSObject(Fitting[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(Fitting_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static Fitting[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<Fitting>();
        foreach(var tsItem in tsArray)
        {
            list.Add(Fitting_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

