using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public  class RebarEndDetailModifier  : BaseRebarModifier
    {


        public RebarHookDataNullable RebarHook
        {
            get
            {
                try
                {
                var value = teklaObject.RebarHook;
                var value_ = RebarHookDataNullable_.FromTSObject(value);
                return (RebarHookDataNullable) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarHook), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarHookDataNullable_.GetTSObject(value);
                teklaObject.RebarHook = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarHook), ex); 
                }
            }
        }

        public RebarThreadingDataNullable RebarThreading
        {
            get
            {
                try
                {
                var value = teklaObject.RebarThreading;
                var value_ = RebarThreadingDataNullable_.FromTSObject(value);
                return (RebarThreadingDataNullable) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarThreading), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarThreadingDataNullable_.GetTSObject(value);
                teklaObject.RebarThreading = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarThreading), ex); 
                }
            }
        }

        public RebarLengthAdjustmentDataNullable RebarLengthAdjustment
        {
            get
            {
                try
                {
                var value = teklaObject.RebarLengthAdjustment;
                var value_ = RebarLengthAdjustmentDataNullable_.FromTSObject(value);
                return (RebarLengthAdjustmentDataNullable) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarLengthAdjustment), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarLengthAdjustmentDataNullable_.GetTSObject(value);
                teklaObject.RebarLengthAdjustment = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarLengthAdjustment), ex); 
                }
            }
        }

        public RebarCrankingNullable RebarCranking
        {
            get
            {
                try
                {
                var value = teklaObject.RebarCranking;
                var value_ = RebarCrankingNullable_.FromTSObject(value);
                return (RebarCrankingNullable) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarCranking), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarCrankingNullable_.GetTSObject(value);
                teklaObject.RebarCranking = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarCranking), ex); 
                }
            }
        }

        public System.Nullable<RebarEndDetailModifier.EndTypeEnum> EndType
        {
            get
            {
                try
                {
                var value = teklaObject.EndType;
                var value_ = NullableConverter.FromTSObject<RebarEndDetailModifier.EndTypeEnum>(value);
                return (System.Nullable<RebarEndDetailModifier.EndTypeEnum>) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndType), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = NullableConverter.ToTSObjects(value);
                teklaObject.EndType = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndType), ex); 
                }
            }
        }
        

        

		public RebarEndDetailModifier()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarEndDetailModifier");
		}
		
		public RebarEndDetailModifier(dynamic tsObject, System.DateTime nonConflictParameter)
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





    public enum EndTypeEnum
    {
			HOOK,
			CRANKING        
    }

    internal static class EndTypeEnum_
    {
        public static dynamic GetTSObject(EndTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarEndDetailModifier.EndTypeEnum").GetType();

            switch (dynEnum)
            {
				case EndTypeEnum.HOOK:
					return System.Enum.Parse(tsType, "HOOK");
				case EndTypeEnum.CRANKING:
					return System.Enum.Parse(tsType, "CRANKING");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static EndTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("HOOK", System.StringComparison.InvariantCulture))
				return EndTypeEnum.HOOK;
			else if (tsEnumValue.Equals("CRANKING", System.StringComparison.InvariantCulture))
				return EndTypeEnum.CRANKING;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarEndDetailModifier_
    {
        public static dynamic GetTSObject(RebarEndDetailModifier dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarEndDetailModifier FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarEndDetailModifier)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarEndDetailModifierArray_
    {
        public static dynamic GetTSObject(RebarEndDetailModifier[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarEndDetailModifier_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarEndDetailModifier[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarEndDetailModifier>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarEndDetailModifier_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
