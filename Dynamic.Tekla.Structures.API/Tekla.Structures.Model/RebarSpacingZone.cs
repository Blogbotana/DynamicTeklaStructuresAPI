using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class RebarSpacingZone 
    {


        public int NumberOfSpaces
        {
            get
            {
                try
                {
                return teklaObject.NumberOfSpaces;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NumberOfSpaces), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.NumberOfSpaces = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NumberOfSpaces), ex); 
                }
            }
        }

        public double Spacing
        {
            get
            {
                try
                {
                return teklaObject.Spacing;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Spacing), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Spacing = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Spacing), ex); 
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

        public RebarSpacingZone.SpacingEnum NumberOfSpacesType
        {
            get
            {
                try
                {
                var value = teklaObject.NumberOfSpacesType;
                var value_ = RebarSpacingZone.SpacingEnum_.FromTSObject(value);
                return (RebarSpacingZone.SpacingEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NumberOfSpacesType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarSpacingZone.SpacingEnum_.GetTSObject(value);
                teklaObject.NumberOfSpacesType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NumberOfSpacesType), ex); 
                }
            }
        }

        public RebarSpacingZone.SpacingEnum SpacingType
        {
            get
            {
                try
                {
                var value = teklaObject.SpacingType;
                var value_ = RebarSpacingZone.SpacingEnum_.FromTSObject(value);
                return (RebarSpacingZone.SpacingEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SpacingType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarSpacingZone.SpacingEnum_.GetTSObject(value);
                teklaObject.SpacingType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SpacingType), ex); 
                }
            }
        }

        public RebarSpacingZone.LengthEnum LengthType
        {
            get
            {
                try
                {
                var value = teklaObject.LengthType;
                var value_ = RebarSpacingZone.LengthEnum_.FromTSObject(value);
                return (RebarSpacingZone.LengthEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LengthType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarSpacingZone.LengthEnum_.GetTSObject(value);
                teklaObject.LengthType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LengthType), ex); 
                }
            }
        }
        

        internal dynamic teklaObject;

		public RebarSpacingZone()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacingZone");
		}
		
		public RebarSpacingZone(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}




    public enum LengthEnum
    {
			ABSOLUTE,
			RELATIVE        
    }

    internal static class LengthEnum_
    {
        public static dynamic GetTSObject(LengthEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacingZone.LengthEnum").GetType();

            switch (dynEnum)
            {
				case LengthEnum.ABSOLUTE:
					return System.Enum.Parse(tsType, "ABSOLUTE");
				case LengthEnum.RELATIVE:
					return System.Enum.Parse(tsType, "RELATIVE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static LengthEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("ABSOLUTE", System.StringComparison.InvariantCulture))
				return LengthEnum.ABSOLUTE;
			else if (tsEnumValue.Equals("RELATIVE", System.StringComparison.InvariantCulture))
				return LengthEnum.RELATIVE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum SpacingEnum
    {
			EXACT,
			TARGET        
    }

    internal static class SpacingEnum_
    {
        public static dynamic GetTSObject(SpacingEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacingZone.SpacingEnum").GetType();

            switch (dynEnum)
            {
				case SpacingEnum.EXACT:
					return System.Enum.Parse(tsType, "EXACT");
				case SpacingEnum.TARGET:
					return System.Enum.Parse(tsType, "TARGET");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static SpacingEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("EXACT", System.StringComparison.InvariantCulture))
				return SpacingEnum.EXACT;
			else if (tsEnumValue.Equals("TARGET", System.StringComparison.InvariantCulture))
				return SpacingEnum.TARGET;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarSpacingZone_
    {
        public static dynamic GetTSObject(RebarSpacingZone dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarSpacingZone FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarSpacingZone)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarSpacingZoneArray_
    {
        public static dynamic GetTSObject(RebarSpacingZone[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarSpacingZone_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarSpacingZone[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarSpacingZone>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarSpacingZone_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
