using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public  class RebarSplitter  : BaseRebarModifier
    {


        public RebarSplitter.StaggerTypeEnum StaggerType
        {
            get
            {
                try
                {
                var value = teklaObject.StaggerType;
                var value_ = RebarSplitter.StaggerTypeEnum_.FromTSObject(value);
                return (RebarSplitter.StaggerTypeEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StaggerType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarSplitter.StaggerTypeEnum_.GetTSObject(value);
                teklaObject.StaggerType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StaggerType), ex); 
                }
            }
        }

        public double StaggerOffset
        {
            get
            {
                try
                {
                return teklaObject.StaggerOffset;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StaggerOffset), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.StaggerOffset = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StaggerOffset), ex); 
                }
            }
        }

        public double SplitOffset
        {
            get
            {
                try
                {
                return teklaObject.SplitOffset;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SplitOffset), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.SplitOffset = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SplitOffset), ex); 
                }
            }
        }

        public RebarSplitter.SplitTypeEnum SplitType
        {
            get
            {
                try
                {
                var value = teklaObject.SplitType;
                var value_ = RebarSplitter.SplitTypeEnum_.FromTSObject(value);
                return (RebarSplitter.SplitTypeEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SplitType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarSplitter.SplitTypeEnum_.GetTSObject(value);
                teklaObject.SplitType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SplitType), ex); 
                }
            }
        }

        public RebarLapping Lapping
        {
            get
            {
                try
                {
                var value = teklaObject.Lapping;
                var value_ = RebarLapping_.FromTSObject(value);
                return (RebarLapping) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Lapping), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarLapping_.GetTSObject(value);
                teklaObject.Lapping = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Lapping), ex); 
                }
            }
        }

        public RebarCranking Cranking
        {
            get
            {
                try
                {
                var value = teklaObject.Cranking;
                var value_ = RebarCranking_.FromTSObject(value);
                return (RebarCranking) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Cranking), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarCranking_.GetTSObject(value);
                teklaObject.Cranking = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Cranking), ex); 
                }
            }
        }
        

        

		public RebarSplitter()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSplitter");
		}
		
		public RebarSplitter(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}


        public ModelObjectEnumerator GetAffectedBars(
			BaseRebarModifier.AffectedRebarEnum whichEnd_)
        {
            var whichEnd = BaseRebarModifier.AffectedRebarEnum_.GetTSObject(whichEnd_);
            try
            {
                var result = teklaObject.GetAffectedBars(whichEnd);
            
                var _result = ModelObjectEnumerator_.FromTSObject(result);
				return _result;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAffectedBars), ex);
            }
        }





    public enum StaggerTypeEnum
    {
			NO_STAGGER,
			STAGGER_LEFT,
			STAGGER_RIGHT,
			STAGGER_MIDDLE        
    }

    internal static class StaggerTypeEnum_
    {
        public static dynamic GetTSObject(StaggerTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSplitter.StaggerTypeEnum").GetType();

            switch (dynEnum)
            {
				case StaggerTypeEnum.NO_STAGGER:
					return System.Enum.Parse(tsType, "NO_STAGGER");
				case StaggerTypeEnum.STAGGER_LEFT:
					return System.Enum.Parse(tsType, "STAGGER_LEFT");
				case StaggerTypeEnum.STAGGER_RIGHT:
					return System.Enum.Parse(tsType, "STAGGER_RIGHT");
				case StaggerTypeEnum.STAGGER_MIDDLE:
					return System.Enum.Parse(tsType, "STAGGER_MIDDLE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static StaggerTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("NO_STAGGER", System.StringComparison.InvariantCulture))
				return StaggerTypeEnum.NO_STAGGER;
			else if (tsEnumValue.Equals("STAGGER_LEFT", System.StringComparison.InvariantCulture))
				return StaggerTypeEnum.STAGGER_LEFT;
			else if (tsEnumValue.Equals("STAGGER_RIGHT", System.StringComparison.InvariantCulture))
				return StaggerTypeEnum.STAGGER_RIGHT;
			else if (tsEnumValue.Equals("STAGGER_MIDDLE", System.StringComparison.InvariantCulture))
				return StaggerTypeEnum.STAGGER_MIDDLE;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum SplitTypeEnum
    {
			LAPPING,
			CRANKING        
    }

    internal static class SplitTypeEnum_
    {
        public static dynamic GetTSObject(SplitTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSplitter.SplitTypeEnum").GetType();

            switch (dynEnum)
            {
				case SplitTypeEnum.LAPPING:
					return System.Enum.Parse(tsType, "LAPPING");
				case SplitTypeEnum.CRANKING:
					return System.Enum.Parse(tsType, "CRANKING");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static SplitTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("LAPPING", System.StringComparison.InvariantCulture))
				return SplitTypeEnum.LAPPING;
			else if (tsEnumValue.Equals("CRANKING", System.StringComparison.InvariantCulture))
				return SplitTypeEnum.CRANKING;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarSplitter_
    {
        public static dynamic GetTSObject(RebarSplitter dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarSplitter FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarSplitter)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarSplitterArray_
    {
        public static dynamic GetTSObject(RebarSplitter[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarSplitter_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarSplitter[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarSplitter>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarSplitter_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
