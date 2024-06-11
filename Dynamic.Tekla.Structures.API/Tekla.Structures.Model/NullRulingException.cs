using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

    public  class NullRulingException  : LoftedPlateOperationException
    {

        

        

		public NullRulingException()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.NullRulingException");
		}
		
		public NullRulingException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class NullRulingException_
    {
        public static dynamic GetTSObject(NullRulingException dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static NullRulingException FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (NullRulingException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class NullRulingExceptionArray_
    {
        public static dynamic GetTSObject(NullRulingException[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(NullRulingException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static NullRulingException[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<NullRulingException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(NullRulingException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
