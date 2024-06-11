using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;


public  class ConicalSurface  : BendSurface
{


    public System.Tuple<double, double> Radiuses
    {
        get
        {
            try
            {
            var value = teklaObject.Radiuses;
            var value_ = TupleConverter.FromTSObject<double, double>(value);
            return (System.Tuple<double, double>) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Radiuses), ex); 
            }
        }
        
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point Apex
    {
        get
        {
            try
            {
            var value = teklaObject.Apex;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Apex), ex); 
            }
        }
        
    }
    

    

		internal ConicalSurface() {}
		
		public ConicalSurface(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public ConicalSurface(Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal1, Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal2, Dynamic.Tekla.Structures.Geometry3d.LineSegment sideBoundary1, Dynamic.Tekla.Structures.Geometry3d.LineSegment sideBoundary2)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal1);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal2);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(sideBoundary1);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(sideBoundary2);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConicalSurface", args);
		}
		public ConicalSurface(Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal1, Dynamic.Tekla.Structures.Geometry3d.Vector endFaceNormal2, System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary1, System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary2)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal1);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(endFaceNormal2);
			args[2] = lateralBoundary1;
			args[3] = lateralBoundary2;
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConicalSurface", args);
		}
		public ConicalSurface(Dynamic.Tekla.Structures.Geometry3d.Arc baseArc, double height, double radiusAtHeight)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Arc_.GetTSObject(baseArc);
			args[1] = height;
			args[2] = radiusAtHeight;
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConicalSurface", args);
		}
		public ConicalSurface(System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary1, System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.Point> lateralBoundary2, Dynamic.Tekla.Structures.Geometry3d.Line centerLine, Dynamic.Tekla.Structures.Geometry3d.Vector rotationAxis)
		{
			var args = new object[4];
			args[0] = lateralBoundary1;
			args[1] = lateralBoundary2;
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Line_.GetTSObject(centerLine);
			args[3] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(rotationAxis);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConicalSurface", args);
		}





}

internal static class ConicalSurface_
{
    public static dynamic GetTSObject(ConicalSurface dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ConicalSurface FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ConicalSurface)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

