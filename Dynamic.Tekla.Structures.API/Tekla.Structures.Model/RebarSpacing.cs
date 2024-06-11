using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class RebarSpacing 
    {


        public RebarSpacing.SpacingType Type
        {
            get
            {
                try
                {
                var value = teklaObject.Type;
                var value_ = RebarSpacing.SpacingType_.FromTSObject(value);
                return (RebarSpacing.SpacingType) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarSpacing.SpacingType_.GetTSObject(value);
                teklaObject.Type = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex); 
                }
            }
        }

        public int NumberOfBars
        {
            get
            {
                try
                {
                return teklaObject.NumberOfBars;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NumberOfBars), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.NumberOfBars = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NumberOfBars), ex); 
                }
            }
        }

        public double TargetSpace
        {
            get
            {
                try
                {
                return teklaObject.TargetSpace;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TargetSpace), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.TargetSpace = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TargetSpace), ex); 
                }
            }
        }

        public double ExactSpace
        {
            get
            {
                try
                {
                return teklaObject.ExactSpace;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExactSpace), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.ExactSpace = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExactSpace), ex); 
                }
            }
        }

        public System.Collections.Generic.List<RebarSpacing.ExactSpacing.Element> ExactElements
        {
            get
            {
                try
                {
                var value = teklaObject.ExactElements;
                var value_ = ListConverter.FromTSObjects<RebarSpacing.ExactSpacing.Element>(value);
                return (System.Collections.Generic.List<RebarSpacing.ExactSpacing.Element>) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExactElements), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = ListConverter.ToTSObjects(value);
                teklaObject.ExactElements = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExactElements), ex); 
                }
            }
        }

        public System.Collections.Generic.List<RebarSpacingZone> Zones
        {
            get
            {
                try
                {
                var value = teklaObject.Zones;
                var value_ = ListConverter.FromTSObjects<RebarSpacingZone>(value);
                return (System.Collections.Generic.List<RebarSpacingZone>) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Zones), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = ListConverter.ToTSObjects(value);
                teklaObject.Zones = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Zones), ex); 
                }
            }
        }

        public double StartOffset
        {
            get
            {
                try
                {
                return teklaObject.StartOffset;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartOffset), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.StartOffset = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartOffset), ex); 
                }
            }
        }

        public double EndOffset
        {
            get
            {
                try
                {
                return teklaObject.EndOffset;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndOffset), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.EndOffset = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndOffset), ex); 
                }
            }
        }

        public RebarSpacing.OffsetEnum StartOffsetType
        {
            get
            {
                try
                {
                var value = teklaObject.StartOffsetType;
                var value_ = RebarSpacing.OffsetEnum_.FromTSObject(value);
                return (RebarSpacing.OffsetEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartOffsetType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarSpacing.OffsetEnum_.GetTSObject(value);
                teklaObject.StartOffsetType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartOffsetType), ex); 
                }
            }
        }

        public RebarSpacing.OffsetEnum EndOffsetType
        {
            get
            {
                try
                {
                var value = teklaObject.EndOffsetType;
                var value_ = RebarSpacing.OffsetEnum_.FromTSObject(value);
                return (RebarSpacing.OffsetEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndOffsetType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarSpacing.OffsetEnum_.GetTSObject(value);
                teklaObject.EndOffsetType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndOffsetType), ex); 
                }
            }
        }

        public bool StartOffsetIsAutomatic
        {
            get
            {
                try
                {
                return teklaObject.StartOffsetIsAutomatic;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartOffsetIsAutomatic), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.StartOffsetIsAutomatic = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartOffsetIsAutomatic), ex); 
                }
            }
        }

        public bool EndOffsetIsAutomatic
        {
            get
            {
                try
                {
                return teklaObject.EndOffsetIsAutomatic;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndOffsetIsAutomatic), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.EndOffsetIsAutomatic = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndOffsetIsAutomatic), ex); 
                }
            }
        }

        public RebarSpacing.ExcludeTypeEnum ExcludeType
        {
            get
            {
                try
                {
                var value = teklaObject.ExcludeType;
                var value_ = RebarSpacing.ExcludeTypeEnum_.FromTSObject(value);
                return (RebarSpacing.ExcludeTypeEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExcludeType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarSpacing.ExcludeTypeEnum_.GetTSObject(value);
                teklaObject.ExcludeType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExcludeType), ex); 
                }
            }
        }

        public bool InheritFromPrimary
        {
            get
            {
                try
                {
                return teklaObject.InheritFromPrimary;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(InheritFromPrimary), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.InheritFromPrimary = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(InheritFromPrimary), ex); 
                }
            }
        }
        

        internal dynamic teklaObject;

		public RebarSpacing()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacing");
		}
		
		public RebarSpacing(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}


        public static RebarSpacing Create(
			RebarSpacing.Offset startOffset_,
			RebarSpacing.Offset endOffset_,
			int number)
        {
            var startOffset = RebarSpacing.Offset_.GetTSObject(startOffset_);
var endOffset = RebarSpacing.Offset_.GetTSObject(endOffset_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.RebarSpacing", "Create", startOffset, endOffset, number);
            var _result = RebarSpacing_.FromTSObject(result);
				return _result;
        }



        public static RebarSpacing Create(
			RebarSpacing.SpacingType type_,
			RebarSpacing.Offset startOffset_,
			RebarSpacing.Offset endOffset_,
			double distance)
        {
            var type = RebarSpacing.SpacingType_.GetTSObject(type_);
var startOffset = RebarSpacing.Offset_.GetTSObject(startOffset_);
var endOffset = RebarSpacing.Offset_.GetTSObject(endOffset_);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.RebarSpacing", "Create", type, startOffset, endOffset, distance);
            var _result = RebarSpacing_.FromTSObject(result);
				return _result;
        }



        public static RebarSpacing Create(
			RebarSpacing.Offset startOffset_,
			RebarSpacing.Offset endOffset_,
			System.Collections.Generic.IEnumerable<RebarSpacing.ExactSpacing.Element> elements_,
			out RebarSpacing.ExactSpacing.Validation validation_)
        {
            var startOffset = RebarSpacing.Offset_.GetTSObject(startOffset_);
var endOffset = RebarSpacing.Offset_.GetTSObject(endOffset_);
var elements = IEnumerableConverter.ToTSObjects(elements_);
var validation = RebarSpacing.ExactSpacing.Validation_.GetTSObject(0);
            var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.RebarSpacing", "Create", startOffset, endOffset, elements, ref validation);
            validation_ = RebarSpacing.ExactSpacing.Validation_.FromTSObject(validation);
            var _result = RebarSpacing_.FromTSObject(result);
				return _result;
        }



        public static bool IsExactFlexibleType(
			RebarSpacing.SpacingType type_)
        {
            var type = RebarSpacing.SpacingType_.GetTSObject(type_);
            var result = (bool) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.RebarSpacing", "IsExactFlexibleType", type);
            return result;
        }



        public RebarSpacing Clone()
        {
            
            try
            {
                var result = teklaObject.Clone();
            
                var _result = RebarSpacing_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Clone), ex);
            }
        }





    public enum OffsetEnum
    {
			EXACT,
			MINIMUM        
    }

    internal static class OffsetEnum_
    {
        public static dynamic GetTSObject(OffsetEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacing.OffsetEnum").GetType();

            switch (dynEnum)
            {
				case OffsetEnum.EXACT:
					return System.Enum.Parse(tsType, "EXACT");
				case OffsetEnum.MINIMUM:
					return System.Enum.Parse(tsType, "MINIMUM");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static OffsetEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("EXACT", System.StringComparison.InvariantCulture))
				return OffsetEnum.EXACT;
			else if (tsEnumValue.Equals("MINIMUM", System.StringComparison.InvariantCulture))
				return OffsetEnum.MINIMUM;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum SpacingType
    {
			UNDEFINED,
			EXACT_SPACINGS,
			NUMBER_BARS,
			TARGET,
			EXACT_FLEXIBLE_FIRST,
			EXACT_FLEXIBLE_LAST,
			EXACT_FLEXIBLE_FIRST_AND_LAST,
			EXACT_FLEXIBLE_MIDDLE        
    }

    internal static class SpacingType_
    {
        public static dynamic GetTSObject(SpacingType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacing.SpacingType").GetType();

            switch (dynEnum)
            {
				case SpacingType.UNDEFINED:
					return System.Enum.Parse(tsType, "UNDEFINED");
				case SpacingType.EXACT_SPACINGS:
					return System.Enum.Parse(tsType, "EXACT_SPACINGS");
				case SpacingType.NUMBER_BARS:
					return System.Enum.Parse(tsType, "NUMBER_BARS");
				case SpacingType.TARGET:
					return System.Enum.Parse(tsType, "TARGET");
				case SpacingType.EXACT_FLEXIBLE_FIRST:
					return System.Enum.Parse(tsType, "EXACT_FLEXIBLE_FIRST");
				case SpacingType.EXACT_FLEXIBLE_LAST:
					return System.Enum.Parse(tsType, "EXACT_FLEXIBLE_LAST");
				case SpacingType.EXACT_FLEXIBLE_FIRST_AND_LAST:
					return System.Enum.Parse(tsType, "EXACT_FLEXIBLE_FIRST_AND_LAST");
				case SpacingType.EXACT_FLEXIBLE_MIDDLE:
					return System.Enum.Parse(tsType, "EXACT_FLEXIBLE_MIDDLE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static SpacingType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("UNDEFINED", System.StringComparison.InvariantCulture))
				return SpacingType.UNDEFINED;
			else if (tsEnumValue.Equals("EXACT_SPACINGS", System.StringComparison.InvariantCulture))
				return SpacingType.EXACT_SPACINGS;
			else if (tsEnumValue.Equals("NUMBER_BARS", System.StringComparison.InvariantCulture))
				return SpacingType.NUMBER_BARS;
			else if (tsEnumValue.Equals("TARGET", System.StringComparison.InvariantCulture))
				return SpacingType.TARGET;
			else if (tsEnumValue.Equals("EXACT_FLEXIBLE_FIRST", System.StringComparison.InvariantCulture))
				return SpacingType.EXACT_FLEXIBLE_FIRST;
			else if (tsEnumValue.Equals("EXACT_FLEXIBLE_LAST", System.StringComparison.InvariantCulture))
				return SpacingType.EXACT_FLEXIBLE_LAST;
			else if (tsEnumValue.Equals("EXACT_FLEXIBLE_FIRST_AND_LAST", System.StringComparison.InvariantCulture))
				return SpacingType.EXACT_FLEXIBLE_FIRST_AND_LAST;
			else if (tsEnumValue.Equals("EXACT_FLEXIBLE_MIDDLE", System.StringComparison.InvariantCulture))
				return SpacingType.EXACT_FLEXIBLE_MIDDLE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum ExcludeTypeEnum
    {
			EXCLUDE_TYPE_NONE,
			EXCLUDE_TYPE_FIRST,
			EXCLUDE_TYPE_LAST,
			EXCLUDE_TYPE_BOTH        
    }

    internal static class ExcludeTypeEnum_
    {
        public static dynamic GetTSObject(ExcludeTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacing.ExcludeTypeEnum").GetType();

            switch (dynEnum)
            {
				case ExcludeTypeEnum.EXCLUDE_TYPE_NONE:
					return System.Enum.Parse(tsType, "EXCLUDE_TYPE_NONE");
				case ExcludeTypeEnum.EXCLUDE_TYPE_FIRST:
					return System.Enum.Parse(tsType, "EXCLUDE_TYPE_FIRST");
				case ExcludeTypeEnum.EXCLUDE_TYPE_LAST:
					return System.Enum.Parse(tsType, "EXCLUDE_TYPE_LAST");
				case ExcludeTypeEnum.EXCLUDE_TYPE_BOTH:
					return System.Enum.Parse(tsType, "EXCLUDE_TYPE_BOTH");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ExcludeTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("EXCLUDE_TYPE_NONE", System.StringComparison.InvariantCulture))
				return ExcludeTypeEnum.EXCLUDE_TYPE_NONE;
			else if (tsEnumValue.Equals("EXCLUDE_TYPE_FIRST", System.StringComparison.InvariantCulture))
				return ExcludeTypeEnum.EXCLUDE_TYPE_FIRST;
			else if (tsEnumValue.Equals("EXCLUDE_TYPE_LAST", System.StringComparison.InvariantCulture))
				return ExcludeTypeEnum.EXCLUDE_TYPE_LAST;
			else if (tsEnumValue.Equals("EXCLUDE_TYPE_BOTH", System.StringComparison.InvariantCulture))
				return ExcludeTypeEnum.EXCLUDE_TYPE_BOTH;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public struct Offset
    {
			public bool Automatic;
			public RebarSpacing.OffsetEnum Type;
			public double Distance;
       
    }

    internal static class Offset_
    {
        public static dynamic GetTSObject(Offset dynStruct)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Offset");
			tsType.Automatic = dynStruct.Automatic;
			tsType.Type = dynStruct.Type;
			tsType.Distance = dynStruct.Distance;

            return tsType;
        }
    
        public static Offset FromTSObject(dynamic tsStruct)
        {
            var dynStruct = new Offset();
			dynStruct.Automatic = tsStruct.Automatic;
			dynStruct.Type = tsStruct.Type;
			dynStruct.Distance = tsStruct.Distance;
 
            return dynStruct;
        }
    }


    public  class ExactSpacing 
    {

        

        internal dynamic teklaObject;

		public ExactSpacing()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacing.ExactSpacing");
		}
		
		public ExactSpacing(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}




    public enum Validation
    {
			VALID,
			EMPTY,
			ZERO_ELEMENTS,
			NEGATIVE_ELEMENTS        
    }

    internal static class Validation_
    {
        public static dynamic GetTSObject(Validation dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSpacing.ExactSpacing.Validation").GetType();

            switch (dynEnum)
            {
				case Validation.VALID:
					return System.Enum.Parse(tsType, "VALID");
				case Validation.EMPTY:
					return System.Enum.Parse(tsType, "EMPTY");
				case Validation.ZERO_ELEMENTS:
					return System.Enum.Parse(tsType, "ZERO_ELEMENTS");
				case Validation.NEGATIVE_ELEMENTS:
					return System.Enum.Parse(tsType, "NEGATIVE_ELEMENTS");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static Validation FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("VALID", System.StringComparison.InvariantCulture))
				return Validation.VALID;
			else if (tsEnumValue.Equals("EMPTY", System.StringComparison.InvariantCulture))
				return Validation.EMPTY;
			else if (tsEnumValue.Equals("ZERO_ELEMENTS", System.StringComparison.InvariantCulture))
				return Validation.ZERO_ELEMENTS;
			else if (tsEnumValue.Equals("NEGATIVE_ELEMENTS", System.StringComparison.InvariantCulture))
				return Validation.NEGATIVE_ELEMENTS;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public struct Element
    {
       
    }

    internal static class Element_
    {
        public static dynamic GetTSObject(Element dynStruct)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Element");

            return tsType;
        }
    
        public static Element FromTSObject(dynamic tsStruct)
        {
            var dynStruct = new Element();
 
            return dynStruct;
        }
    }



    }

    internal static class ExactSpacing_
    {
        public static dynamic GetTSObject(ExactSpacing dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static ExactSpacing FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarSpacing.ExactSpacing)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ExactSpacingArray_
    {
        public static dynamic GetTSObject(ExactSpacing[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(ExactSpacing_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static ExactSpacing[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<ExactSpacing>();
            foreach(var tsItem in tsArray)
            {
                list.Add(ExactSpacing_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }




    }

    internal static class RebarSpacing_
    {
        public static dynamic GetTSObject(RebarSpacing dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarSpacing FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarSpacing)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarSpacingArray_
    {
        public static dynamic GetTSObject(RebarSpacing[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarSpacing_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarSpacing[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarSpacing>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarSpacing_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
