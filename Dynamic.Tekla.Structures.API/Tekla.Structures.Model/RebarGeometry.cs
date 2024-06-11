using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class RebarGeometry 
    {


        public Dynamic.Tekla.Structures.Geometry3d.PolyLine Shape
        {
            get
            {
                try
                {
                var value = teklaObject.Shape;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.PolyLine_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.PolyLine) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Shape), ex); 
                }
            }
            
        }

        public double Diameter
        {
            get
            {
                try
                {
                return teklaObject.Diameter;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Diameter), ex); 
                }
            }
            
        }

        public System.Collections.ArrayList BendingRadiuses
        {
            get
            {
                try
                {
                var value = teklaObject.BendingRadiuses;
                var value_ = ArrayListConverter.FromTSObjects(value);
                return (System.Collections.ArrayList) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BendingRadiuses), ex); 
                }
            }
            
        }
        

        internal dynamic teklaObject;

		internal RebarGeometry() {}
		
		public RebarGeometry(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class RebarGeometry_
    {
        public static dynamic GetTSObject(RebarGeometry dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarGeometry FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarGeometry)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarGeometryArray_
    {
        public static dynamic GetTSObject(RebarGeometry[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarGeometry_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarGeometry[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarGeometry>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarGeometry_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
