using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class UndefinedCurveDirectionException  : ConnectiveGeometryException
    {

        

        

		public UndefinedCurveDirectionException()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UndefinedCurveDirectionException");
		}
		
		public UndefinedCurveDirectionException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class UndefinedCurveDirectionException_
    {
        public static dynamic GetTSObject(UndefinedCurveDirectionException dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static UndefinedCurveDirectionException FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (UndefinedCurveDirectionException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class UndefinedCurveDirectionExceptionArray_
    {
        public static dynamic GetTSObject(UndefinedCurveDirectionException[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(UndefinedCurveDirectionException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static UndefinedCurveDirectionException[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<UndefinedCurveDirectionException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(UndefinedCurveDirectionException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
