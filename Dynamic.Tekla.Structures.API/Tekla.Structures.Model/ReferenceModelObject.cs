using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class ReferenceModelObject  : ModelObject
    {

        

        

		public ReferenceModelObject()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ReferenceModelObject");
		}
		
		public ReferenceModelObject(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public ReferenceModelObject(int ReferenceModelId, Dynamic.Tekla.Structures.Identifier ID)
		{
			var args = new object[2];
			args[0] = ReferenceModelId;
			args[1] = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ReferenceModelObject", args);
		}


        public ReferenceModel GetReferenceModel()
        {
            
            try
            {
                var result = teklaObject.GetReferenceModel();
            
                var _result = ReferenceModel_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetReferenceModel), ex);
            }
        }



        public ReferenceModelObject GetFather()
        {
            
            try
            {
                var result = teklaObject.GetFather();
            
                var _result = ReferenceModelObject_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetFather), ex);
            }
        }






    }

    internal static class ReferenceModelObject_
    {
        public static dynamic GetTSObject(ReferenceModelObject dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ReferenceModelObject FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (ReferenceModelObject)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ReferenceModelObjectArray_
    {
        public static dynamic GetTSObject(ReferenceModelObject[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ReferenceModelObject_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ReferenceModelObject[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ReferenceModelObject>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ReferenceModelObject_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
