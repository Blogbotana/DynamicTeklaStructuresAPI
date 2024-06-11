using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;
public  class RebarLengthAdjustmentDataNullable 
    {


        public System.Nullable<RebarLengthAdjustmentDataNullable.LengthAdjustmentTypeEnum> AdjustmentType
        {
            get
            {
                try
                {
                var value = teklaObject.AdjustmentType;
                var value_ = NullableConverter.FromTSObject<RebarLengthAdjustmentDataNullable.LengthAdjustmentTypeEnum>(value);
                return (System.Nullable<RebarLengthAdjustmentDataNullable.LengthAdjustmentTypeEnum>) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AdjustmentType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = NullableConverter.ToTSObjects(value);
                teklaObject.AdjustmentType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AdjustmentType), ex); 
                }
            }
        }

        public System.Nullable<double> AdjustmentLength
        {
            get
            {
                try
                {
                return teklaObject.AdjustmentLength;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AdjustmentLength), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.AdjustmentLength = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AdjustmentLength), ex); 
                }
            }
        }
        

        internal dynamic teklaObject;

		public RebarLengthAdjustmentDataNullable()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLengthAdjustmentDataNullable");
		}
		
		public RebarLengthAdjustmentDataNullable(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}




    public enum LengthAdjustmentTypeEnum
    {
			NO_ADJUSTMENT,
			END_OFFSET,
			LEG_LENGTH        
    }

    internal static class LengthAdjustmentTypeEnum_
    {
        public static dynamic GetTSObject(LengthAdjustmentTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLengthAdjustmentDataNullable.LengthAdjustmentTypeEnum").GetType();

            switch (dynEnum)
            {
				case LengthAdjustmentTypeEnum.NO_ADJUSTMENT:
					return System.Enum.Parse(tsType, "NO_ADJUSTMENT");
				case LengthAdjustmentTypeEnum.END_OFFSET:
					return System.Enum.Parse(tsType, "END_OFFSET");
				case LengthAdjustmentTypeEnum.LEG_LENGTH:
					return System.Enum.Parse(tsType, "LEG_LENGTH");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LengthAdjustmentTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NO_ADJUSTMENT", System.StringComparison.InvariantCulture))
				return LengthAdjustmentTypeEnum.NO_ADJUSTMENT;
			else if (tsEnumValue.Equals("END_OFFSET", System.StringComparison.InvariantCulture))
				return LengthAdjustmentTypeEnum.END_OFFSET;
			else if (tsEnumValue.Equals("LEG_LENGTH", System.StringComparison.InvariantCulture))
				return LengthAdjustmentTypeEnum.LEG_LENGTH;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarLengthAdjustmentDataNullable_
    {
        public static dynamic GetTSObject(RebarLengthAdjustmentDataNullable dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarLengthAdjustmentDataNullable FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarLengthAdjustmentDataNullable)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarLengthAdjustmentDataNullableArray_
    {
        public static dynamic GetTSObject(RebarLengthAdjustmentDataNullable[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarLengthAdjustmentDataNullable_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarLengthAdjustmentDataNullable[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarLengthAdjustmentDataNullable>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarLengthAdjustmentDataNullable_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
