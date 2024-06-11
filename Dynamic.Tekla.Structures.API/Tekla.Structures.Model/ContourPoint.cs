using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class ContourPoint  : Dynamic.Tekla.Structures.Geometry3d.Point
{


    public Chamfer Chamfer
    {
        get
        {
            try
            {
            var value = teklaObject.Chamfer;
            var value_ = Chamfer_.FromTSObject(value);
            return (Chamfer) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Chamfer), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Chamfer_.GetTSObject(value);
            teklaObject.Chamfer = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Chamfer), ex); 
            }
        }
    }
    

    

		public ContourPoint()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ContourPoint");
		}
		
		public ContourPoint(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public ContourPoint(Dynamic.Tekla.Structures.Geometry3d.Point P, Chamfer C)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(P);
			args[1] = Chamfer_.GetTSObject(C);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ContourPoint", args);
		}


    public void SetPoint(
			Dynamic.Tekla.Structures.Geometry3d.Point P_)
    {
        var P = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(P_);
        try
        {
            teklaObject.SetPoint(P);
        
            
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetPoint), ex);
        }
    }






}

internal static class ContourPoint_
{
    public static dynamic GetTSObject(ContourPoint dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ContourPoint FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ContourPoint)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ContourPointArray_
{
    public static dynamic GetTSObject(ContourPoint[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(ContourPoint_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static ContourPoint[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<ContourPoint>();
        foreach(var tsItem in tsArray)
        {
            list.Add(ContourPoint_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

