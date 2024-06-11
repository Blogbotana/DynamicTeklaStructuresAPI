using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class UnknownLoftedPlateErrorException  : LoftedPlateOperationException
    {

        

        

		public UnknownLoftedPlateErrorException()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UnknownLoftedPlateErrorException");
		}
		
		public UnknownLoftedPlateErrorException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class UnknownLoftedPlateErrorException_
    {
        public static dynamic GetTSObject(UnknownLoftedPlateErrorException dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static UnknownLoftedPlateErrorException FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (UnknownLoftedPlateErrorException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class UnknownLoftedPlateErrorExceptionArray_
    {
        public static dynamic GetTSObject(UnknownLoftedPlateErrorException[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(UnknownLoftedPlateErrorException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static UnknownLoftedPlateErrorException[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<UnknownLoftedPlateErrorException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(UnknownLoftedPlateErrorException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
