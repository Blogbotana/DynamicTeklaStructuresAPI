using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class RebarThreadingDataNullable 
    {


        public string ThreadingType
        {
            get
            {
                try
                {
                return teklaObject.ThreadingType;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ThreadingType), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.ThreadingType = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ThreadingType), ex); 
                }
            }
        }

        public System.Nullable<double> Length
        {
            get
            {
                try
                {
                return teklaObject.Length;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Length), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Length = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Length), ex); 
                }
            }
        }

        public System.Nullable<double> ExtraFabricationLength
        {
            get
            {
                try
                {
                return teklaObject.ExtraFabricationLength;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtraFabricationLength), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.ExtraFabricationLength = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtraFabricationLength), ex); 
                }
            }
        }
        

        internal dynamic teklaObject;

		public RebarThreadingDataNullable()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarThreadingDataNullable");
		}
		
		public RebarThreadingDataNullable(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class RebarThreadingDataNullable_
    {
        public static dynamic GetTSObject(RebarThreadingDataNullable dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarThreadingDataNullable FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarThreadingDataNullable)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarThreadingDataNullableArray_
    {
        public static dynamic GetTSObject(RebarThreadingDataNullable[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarThreadingDataNullable_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarThreadingDataNullable[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarThreadingDataNullable>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarThreadingDataNullable_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
