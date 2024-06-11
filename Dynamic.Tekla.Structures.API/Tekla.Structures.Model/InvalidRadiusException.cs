using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;

public  class InvalidRadiusException  : ConnectiveGeometryException
    {

        

        

		public InvalidRadiusException()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.InvalidRadiusException");
		}
		
		public InvalidRadiusException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class InvalidRadiusException_
    {
        public static dynamic GetTSObject(InvalidRadiusException dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static InvalidRadiusException FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (InvalidRadiusException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class InvalidRadiusExceptionArray_
    {
        public static dynamic GetTSObject(InvalidRadiusException[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(InvalidRadiusException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static InvalidRadiusException[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<InvalidRadiusException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(InvalidRadiusException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
