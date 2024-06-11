using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;
public  class RebarPropertyModifier  : BaseRebarModifier
    {


        public bool AffectsWholeBarPlane
        {
            get
            {
                try
                {
                return teklaObject.AffectsWholeBarPlane;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AffectsWholeBarPlane), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.AffectsWholeBarPlane = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AffectsWholeBarPlane), ex); 
                }
            }
        }

        public RebarPropertiesNullable RebarProperties
        {
            get
            {
                try
                {
                var value = teklaObject.RebarProperties;
                var value_ = RebarPropertiesNullable_.FromTSObject(value);
                return (RebarPropertiesNullable) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarProperties), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarPropertiesNullable_.GetTSObject(value);
                teklaObject.RebarProperties = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarProperties), ex); 
                }
            }
        }

        public System.Nullable<RebarPropertyModifier.GroupingTypeEnum> GroupingType
        {
            get
            {
                try
                {
                var value = teklaObject.GroupingType;
                var value_ = NullableConverter.FromTSObject<RebarPropertyModifier.GroupingTypeEnum>(value);
                return (System.Nullable<RebarPropertyModifier.GroupingTypeEnum>) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(GroupingType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = NullableConverter.ToTSObjects(value);
                teklaObject.GroupingType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(GroupingType), ex); 
                }
            }
        }

        public RebarSpacing SpacingOverride
        {
            get
            {
                try
                {
                var value = teklaObject.SpacingOverride;
                var value_ = RebarSpacing_.FromTSObject(value);
                return (RebarSpacing) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SpacingOverride), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarSpacing_.GetTSObject(value);
                teklaObject.SpacingOverride = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SpacingOverride), ex); 
                }
            }
        }

        public Part FatherPart
        {
            get
            {
                try
                {
                var value = teklaObject.FatherPart;
                var value_ = Part_.FromTSObject(value);
                return (Part) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FatherPart), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Part_.GetTSObject(value);
                teklaObject.FatherPart = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FatherPart), ex); 
                }
            }
        }
        

        

		public RebarPropertyModifier()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarPropertyModifier");
		}
		
		public RebarPropertyModifier(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}


        public ModelObjectEnumerator GetAffectedBars()
        {
            
            try
            {
                var result = teklaObject.GetAffectedBars();
            
                var _result = ModelObjectEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAffectedBars), ex);
            }
        }





    public enum GroupingTypeEnum
    {
			AUTOMATIC,
			MANUAL,
			NO_GROUPING        
    }

    internal static class GroupingTypeEnum_
    {
        public static dynamic GetTSObject(GroupingTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarPropertyModifier.GroupingTypeEnum").GetType();

            switch (dynEnum)
            {
				case GroupingTypeEnum.AUTOMATIC:
					return System.Enum.Parse(tsType, "AUTOMATIC");
				case GroupingTypeEnum.MANUAL:
					return System.Enum.Parse(tsType, "MANUAL");
				case GroupingTypeEnum.NO_GROUPING:
					return System.Enum.Parse(tsType, "NO_GROUPING");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static GroupingTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("AUTOMATIC", System.StringComparison.InvariantCulture))
				return GroupingTypeEnum.AUTOMATIC;
			else if (tsEnumValue.Equals("MANUAL", System.StringComparison.InvariantCulture))
				return GroupingTypeEnum.MANUAL;
			else if (tsEnumValue.Equals("NO_GROUPING", System.StringComparison.InvariantCulture))
				return GroupingTypeEnum.NO_GROUPING;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarPropertyModifier_
    {
        public static dynamic GetTSObject(RebarPropertyModifier dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarPropertyModifier FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarPropertyModifier)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarPropertyModifierArray_
    {
        public static dynamic GetTSObject(RebarPropertyModifier[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarPropertyModifier_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarPropertyModifier[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarPropertyModifier>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarPropertyModifier_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
