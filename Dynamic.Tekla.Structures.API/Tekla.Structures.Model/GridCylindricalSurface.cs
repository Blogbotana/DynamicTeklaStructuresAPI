using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class GridCylindricalSurface  : GridSurface
{


    public Dynamic.Tekla.Structures.Geometry3d.Arc CylinderBase
    {
        get
        {
            try
            {
            var value = teklaObject.CylinderBase;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Arc_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Arc) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CylinderBase), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(value);
            teklaObject.CylinderBase = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CylinderBase), ex); 
            }
        }
    }

    public double CylinderHeight
    {
        get
        {
            try
            {
            return teklaObject.CylinderHeight;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CylinderHeight), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.CylinderHeight = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CylinderHeight), ex); 
            }
        }
    }
    

    

		public GridCylindricalSurface()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.GridCylindricalSurface");
		}
		
		public GridCylindricalSurface(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public GridCylindricalSurface(Dynamic.Tekla.Structures.Geometry3d.Arc cylinderBase, double cylinderHeight, string label)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(cylinderBase);
			args[1] = cylinderHeight;
			args[2] = label;
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.GridCylindricalSurface", args);
		}





}

internal static class GridCylindricalSurface_
{
    public static dynamic GetTSObject(GridCylindricalSurface dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static GridCylindricalSurface FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (GridCylindricalSurface)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class GridCylindricalSurfaceArray_
{
    public static dynamic GetTSObject(GridCylindricalSurface[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(GridCylindricalSurface_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static GridCylindricalSurface[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<GridCylindricalSurface>();
        foreach(var tsItem in tsArray)
        {
            list.Add(GridCylindricalSurface_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

