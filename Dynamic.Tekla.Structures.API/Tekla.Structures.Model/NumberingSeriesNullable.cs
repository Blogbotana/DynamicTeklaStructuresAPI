using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

    public  class NumberingSeriesNullable 
    {


        public string Prefix
        {
            get
            {
                try
                {
                return teklaObject.Prefix;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Prefix), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Prefix = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Prefix), ex); 
                }
            }
        }

        public System.Nullable<int> StartNumber
        {
            get
            {
                try
                {
                return teklaObject.StartNumber;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartNumber), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.StartNumber = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartNumber), ex); 
                }
            }
        }
        

        internal dynamic teklaObject;

		public NumberingSeriesNullable()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.NumberingSeriesNullable");
		}
		
		public NumberingSeriesNullable(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public NumberingSeriesNullable(string prefix, int number)
		{
			var args = new object[2];
			args[0] = prefix;
			args[1] = number;
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.NumberingSeriesNullable", args);
		}





    }

    internal static class NumberingSeriesNullable_
    {
        public static dynamic GetTSObject(NumberingSeriesNullable dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static NumberingSeriesNullable FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (NumberingSeriesNullable)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class NumberingSeriesNullableArray_
    {
        public static dynamic GetTSObject(NumberingSeriesNullable[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(NumberingSeriesNullable_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static NumberingSeriesNullable[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<NumberingSeriesNullable>();
            foreach(var tsItem in tsArray)
            {
                list.Add(NumberingSeriesNullable_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
