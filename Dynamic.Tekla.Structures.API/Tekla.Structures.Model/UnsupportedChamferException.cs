using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class UnsupportedChamferException  : ConnectiveGeometryException
    {

        

        

		public UnsupportedChamferException()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UnsupportedChamferException");
		}
		
		public UnsupportedChamferException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class UnsupportedChamferException_
    {
        public static dynamic GetTSObject(UnsupportedChamferException dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static UnsupportedChamferException FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (UnsupportedChamferException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class UnsupportedChamferExceptionArray_
    {
        public static dynamic GetTSObject(UnsupportedChamferException[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(UnsupportedChamferException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static UnsupportedChamferException[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<UnsupportedChamferException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(UnsupportedChamferException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
