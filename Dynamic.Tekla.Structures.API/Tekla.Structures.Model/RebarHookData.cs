using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class RebarHookData 
    {


        public RebarHookData.RebarHookShapeEnum Shape
        {
            get
            {
                try
                {
                var value = teklaObject.Shape;
                var value_ = RebarHookData.RebarHookShapeEnum_.FromTSObject(value);
                return (RebarHookData.RebarHookShapeEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Shape), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarHookData.RebarHookShapeEnum_.GetTSObject(value);
                teklaObject.Shape = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Shape), ex); 
                }
            }
        }

        public double Angle
        {
            get
            {
                try
                {
                return teklaObject.Angle;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Angle), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Angle = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Angle), ex); 
                }
            }
        }

        public double Radius
        {
            get
            {
                try
                {
                return teklaObject.Radius;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Radius), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Radius = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Radius), ex); 
                }
            }
        }

        public double Length
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
        

        internal dynamic teklaObject;

		public RebarHookData()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarHookData");
		}
		
		public RebarHookData(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}




    public enum RebarHookShapeEnum
    {
			NO_HOOK,
			HOOK_90_DEGREES,
			HOOK_135_DEGREES,
			HOOK_180_DEGREES,
			CUSTOM_HOOK        
    }

    internal static class RebarHookShapeEnum_
    {
        public static dynamic GetTSObject(RebarHookShapeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarHookData.RebarHookShapeEnum").GetType();

            switch (dynEnum)
            {
				case RebarHookShapeEnum.NO_HOOK:
					return System.Enum.Parse(tsType, "NO_HOOK");
				case RebarHookShapeEnum.HOOK_90_DEGREES:
					return System.Enum.Parse(tsType, "HOOK_90_DEGREES");
				case RebarHookShapeEnum.HOOK_135_DEGREES:
					return System.Enum.Parse(tsType, "HOOK_135_DEGREES");
				case RebarHookShapeEnum.HOOK_180_DEGREES:
					return System.Enum.Parse(tsType, "HOOK_180_DEGREES");
				case RebarHookShapeEnum.CUSTOM_HOOK:
					return System.Enum.Parse(tsType, "CUSTOM_HOOK");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarHookShapeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NO_HOOK", System.StringComparison.InvariantCulture))
				return RebarHookShapeEnum.NO_HOOK;
			else if (tsEnumValue.Equals("HOOK_90_DEGREES", System.StringComparison.InvariantCulture))
				return RebarHookShapeEnum.HOOK_90_DEGREES;
			else if (tsEnumValue.Equals("HOOK_135_DEGREES", System.StringComparison.InvariantCulture))
				return RebarHookShapeEnum.HOOK_135_DEGREES;
			else if (tsEnumValue.Equals("HOOK_180_DEGREES", System.StringComparison.InvariantCulture))
				return RebarHookShapeEnum.HOOK_180_DEGREES;
			else if (tsEnumValue.Equals("CUSTOM_HOOK", System.StringComparison.InvariantCulture))
				return RebarHookShapeEnum.CUSTOM_HOOK;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarHookData_
    {
        public static dynamic GetTSObject(RebarHookData dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarHookData FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarHookData)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarHookDataArray_
    {
        public static dynamic GetTSObject(RebarHookData[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarHookData_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarHookData[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarHookData>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarHookData_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
