using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;
public  class StrandUnbondingData 
    {


        public int StrandIndex
        {
            get
            {
                try
                {
                return teklaObject.StrandIndex;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StrandIndex), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.StrandIndex = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StrandIndex), ex); 
                }
            }
        }

        public double FromStart
        {
            get
            {
                try
                {
                return teklaObject.FromStart;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FromStart), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.FromStart = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FromStart), ex); 
                }
            }
        }

        public double MiddleToStart
        {
            get
            {
                try
                {
                return teklaObject.MiddleToStart;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MiddleToStart), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.MiddleToStart = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MiddleToStart), ex); 
                }
            }
        }

        public double MiddleToEnd
        {
            get
            {
                try
                {
                return teklaObject.MiddleToEnd;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MiddleToEnd), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.MiddleToEnd = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MiddleToEnd), ex); 
                }
            }
        }

        public double FromEnd
        {
            get
            {
                try
                {
                return teklaObject.FromEnd;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FromEnd), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.FromEnd = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FromEnd), ex); 
                }
            }
        }
        

        internal dynamic teklaObject;

		public StrandUnbondingData()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.StrandUnbondingData");
		}
		
		public StrandUnbondingData(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





    }

    internal static class StrandUnbondingData_
    {
        public static dynamic GetTSObject(StrandUnbondingData dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static StrandUnbondingData FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (StrandUnbondingData)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class StrandUnbondingDataArray_
    {
        public static dynamic GetTSObject(StrandUnbondingData[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(StrandUnbondingData_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static StrandUnbondingData[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<StrandUnbondingData>();
            foreach(var tsItem in tsArray)
            {
                list.Add(StrandUnbondingData_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
