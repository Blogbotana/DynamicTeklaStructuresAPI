using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public  class WorkPlaneHandler 
    {

        

        internal dynamic teklaObject;

		internal WorkPlaneHandler() {}
		
		public WorkPlaneHandler(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}


        public TransformationPlane GetCurrentTransformationPlane()
        {
            
            try
            {
                var result = teklaObject.GetCurrentTransformationPlane();
            
                var _result = TransformationPlane_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetCurrentTransformationPlane), ex);
            }
        }



        public bool SetCurrentTransformationPlane(
			TransformationPlane TransformationPlane_)
        {
            var TransformationPlane = Dynamic.Tekla.Structures.Model.TransformationPlane_.GetTSObject(TransformationPlane_);
            try
            {
                var result = (bool) teklaObject.SetCurrentTransformationPlane(TransformationPlane);
            
                return result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetCurrentTransformationPlane), ex);
            }
        }






    }

    internal static class WorkPlaneHandler_
    {
        public static dynamic GetTSObject(WorkPlaneHandler dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static WorkPlaneHandler FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (WorkPlaneHandler)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class WorkPlaneHandlerArray_
    {
        public static dynamic GetTSObject(WorkPlaneHandler[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(WorkPlaneHandler_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static WorkPlaneHandler[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<WorkPlaneHandler>();
            foreach(var tsItem in tsArray)
            {
                list.Add(WorkPlaneHandler_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
