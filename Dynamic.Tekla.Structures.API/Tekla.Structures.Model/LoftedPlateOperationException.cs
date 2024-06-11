using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

    public abstract class LoftedPlateOperationException  : System.Exception
    {

        

        internal dynamic teklaObject;






    }

    internal static class LoftedPlateOperationException_
    {
        public static dynamic GetTSObject(LoftedPlateOperationException dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static LoftedPlateOperationException FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (LoftedPlateOperationException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class LoftedPlateOperationExceptionArray_
    {
        public static dynamic GetTSObject(LoftedPlateOperationException[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(LoftedPlateOperationException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static LoftedPlateOperationException[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<LoftedPlateOperationException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(LoftedPlateOperationException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }

