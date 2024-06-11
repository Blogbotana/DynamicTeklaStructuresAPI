using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;
public  class SpiralBeamDataException  : System.Exception
    {


        public SpiralBeam.ErrorStatus ErrorStatus
        {
            get
            {
                try
                {
                var value = teklaObject.ErrorStatus;
                var value_ = SpiralBeam.ErrorStatus_.FromTSObject(value);
                return (SpiralBeam.ErrorStatus) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ErrorStatus), ex); 
                }
            }
            
        }
        

        internal dynamic teklaObject;

		internal SpiralBeamDataException() {}
		
		public SpiralBeamDataException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public SpiralBeamDataException(SpiralBeam.ErrorStatus status, string message)
		{
			var args = new object[2];
			args[0] = SpiralBeam.ErrorStatus_.GetTSObject(status);
			args[1] = message;
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SpiralBeamDataException", args);
		}





    }

    internal static class SpiralBeamDataException_
    {
        public static dynamic GetTSObject(SpiralBeamDataException dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static SpiralBeamDataException FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (SpiralBeamDataException)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SpiralBeamDataExceptionArray_
    {
        public static dynamic GetTSObject(SpiralBeamDataException[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SpiralBeamDataException_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SpiralBeamDataException[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<SpiralBeamDataException>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SpiralBeamDataException_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
