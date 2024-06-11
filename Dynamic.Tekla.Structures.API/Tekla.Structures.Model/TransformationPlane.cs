using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public  class TransformationPlane 
    {


        public Dynamic.Tekla.Structures.Geometry3d.Matrix TransformationMatrixToGlobal
        {
            get
            {
                try
                {
                var value = teklaObject.TransformationMatrixToGlobal;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Matrix) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TransformationMatrixToGlobal), ex); 
                }
            }
            
        }

        public Dynamic.Tekla.Structures.Geometry3d.Matrix TransformationMatrixToLocal
        {
            get
            {
                try
                {
                var value = teklaObject.TransformationMatrixToLocal;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Matrix_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Matrix) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TransformationMatrixToLocal), ex); 
                }
            }
            
        }
        

        internal dynamic teklaObject;

		public TransformationPlane()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.TransformationPlane");
		}
		
		public TransformationPlane(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public TransformationPlane(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem CoordinateSystem)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(CoordinateSystem);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.TransformationPlane", args);
		}
		public TransformationPlane(Dynamic.Tekla.Structures.Geometry3d.Point Origo, Dynamic.Tekla.Structures.Geometry3d.Vector Xvector, Dynamic.Tekla.Structures.Geometry3d.Vector Yvector)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(Origo);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Xvector);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(Yvector);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.TransformationPlane", args);
		}





    }

    internal static class TransformationPlane_
    {
        public static dynamic GetTSObject(TransformationPlane dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static TransformationPlane FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (TransformationPlane)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class TransformationPlaneArray_
    {
        public static dynamic GetTSObject(TransformationPlane[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(TransformationPlane_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static TransformationPlane[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<TransformationPlane>();
            foreach(var tsItem in tsArray)
            {
                list.Add(TransformationPlane_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



