using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;
public  class RebarLapping 
    {


        public double LapLength
        {
            get
            {
                try
                {
                return teklaObject.LapLength;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LapLength), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.LapLength = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LapLength), ex); 
                }
            }
        }

        public RebarLapping.LapSideEnum LapSide
        {
            get
            {
                try
                {
                var value = teklaObject.LapSide;
                var value_ = RebarLapping.LapSideEnum_.FromTSObject(value);
                return (RebarLapping.LapSideEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LapSide), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarLapping.LapSideEnum_.GetTSObject(value);
                teklaObject.LapSide = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LapSide), ex); 
                }
            }
        }

        public RebarLapping.LapPlacementEnum LapPlacement
        {
            get
            {
                try
                {
                var value = teklaObject.LapPlacement;
                var value_ = RebarLapping.LapPlacementEnum_.FromTSObject(value);
                return (RebarLapping.LapPlacementEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LapPlacement), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarLapping.LapPlacementEnum_.GetTSObject(value);
                teklaObject.LapPlacement = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LapPlacement), ex); 
                }
            }
        }

        public RebarLapping.LappingTypeEnum LappingType
        {
            get
            {
                try
                {
                var value = teklaObject.LappingType;
                var value_ = RebarLapping.LappingTypeEnum_.FromTSObject(value);
                return (RebarLapping.LappingTypeEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LappingType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarLapping.LappingTypeEnum_.GetTSObject(value);
                teklaObject.LappingType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LappingType), ex); 
                }
            }
        }
        

        internal dynamic teklaObject;

		public RebarLapping()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLapping");
		}
		
		public RebarLapping(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}




    public enum LapSideEnum
    {
			LAP_LEFT,
			LAP_RIGHT,
			LAP_MIDDLE        
    }

    internal static class LapSideEnum_
    {
        public static dynamic GetTSObject(LapSideEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLapping.LapSideEnum").GetType();

            switch (dynEnum)
            {
				case LapSideEnum.LAP_LEFT:
					return System.Enum.Parse(tsType, "LAP_LEFT");
				case LapSideEnum.LAP_RIGHT:
					return System.Enum.Parse(tsType, "LAP_RIGHT");
				case LapSideEnum.LAP_MIDDLE:
					return System.Enum.Parse(tsType, "LAP_MIDDLE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LapSideEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LAP_LEFT", System.StringComparison.InvariantCulture))
				return LapSideEnum.LAP_LEFT;
			else if (tsEnumValue.Equals("LAP_RIGHT", System.StringComparison.InvariantCulture))
				return LapSideEnum.LAP_RIGHT;
			else if (tsEnumValue.Equals("LAP_MIDDLE", System.StringComparison.InvariantCulture))
				return LapSideEnum.LAP_MIDDLE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum LapPlacementEnum
    {
			ON_LEG_FACE,
			PERPENDICULAR_TO_LEG_FACE        
    }

    internal static class LapPlacementEnum_
    {
        public static dynamic GetTSObject(LapPlacementEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLapping.LapPlacementEnum").GetType();

            switch (dynEnum)
            {
				case LapPlacementEnum.ON_LEG_FACE:
					return System.Enum.Parse(tsType, "ON_LEG_FACE");
				case LapPlacementEnum.PERPENDICULAR_TO_LEG_FACE:
					return System.Enum.Parse(tsType, "PERPENDICULAR_TO_LEG_FACE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LapPlacementEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("ON_LEG_FACE", System.StringComparison.InvariantCulture))
				return LapPlacementEnum.ON_LEG_FACE;
			else if (tsEnumValue.Equals("PERPENDICULAR_TO_LEG_FACE", System.StringComparison.InvariantCulture))
				return LapPlacementEnum.PERPENDICULAR_TO_LEG_FACE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum LappingTypeEnum
    {
			CUSTOM_LAPPING,
			STANDARD_LAPPING        
    }

    internal static class LappingTypeEnum_
    {
        public static dynamic GetTSObject(LappingTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLapping.LappingTypeEnum").GetType();

            switch (dynEnum)
            {
				case LappingTypeEnum.CUSTOM_LAPPING:
					return System.Enum.Parse(tsType, "CUSTOM_LAPPING");
				case LappingTypeEnum.STANDARD_LAPPING:
					return System.Enum.Parse(tsType, "STANDARD_LAPPING");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LappingTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("CUSTOM_LAPPING", System.StringComparison.InvariantCulture))
				return LappingTypeEnum.CUSTOM_LAPPING;
			else if (tsEnumValue.Equals("STANDARD_LAPPING", System.StringComparison.InvariantCulture))
				return LappingTypeEnum.STANDARD_LAPPING;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarLapping_
    {
        public static dynamic GetTSObject(RebarLapping dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarLapping FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarLapping)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarLappingArray_
    {
        public static dynamic GetTSObject(RebarLapping[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarLapping_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarLapping[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarLapping>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarLapping_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
