using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;
public  class RebarSplice  : ModelObject
    {


        public Reinforcement RebarGroup1
        {
            get
            {
                try
                {
                var value = teklaObject.RebarGroup1;
                var value_ = Reinforcement_.FromTSObject(value);
                return (Reinforcement) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarGroup1), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Reinforcement_.GetTSObject(value);
                teklaObject.RebarGroup1 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarGroup1), ex); 
                }
            }
        }

        public Reinforcement RebarGroup2
        {
            get
            {
                try
                {
                var value = teklaObject.RebarGroup2;
                var value_ = Reinforcement_.FromTSObject(value);
                return (Reinforcement) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarGroup2), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = Reinforcement_.GetTSObject(value);
                teklaObject.RebarGroup2 = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RebarGroup2), ex); 
                }
            }
        }

        public RebarSplice.RebarSpliceTypeEnum Type
        {
            get
            {
                try
                {
                var value = teklaObject.Type;
                var value_ = RebarSplice.RebarSpliceTypeEnum_.FromTSObject(value);
                return (RebarSplice.RebarSpliceTypeEnum) value_;
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
                var value_ = RebarSplice.RebarSpliceTypeEnum_.GetTSObject(value);
                teklaObject.Type = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex); 
                }
            }
        }

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

        public double Offset
        {
            get
            {
                try
                {
                return teklaObject.Offset;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Offset), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Offset = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Offset), ex); 
                }
            }
        }

        public double Clearance
        {
            get
            {
                try
                {
                return teklaObject.Clearance;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Clearance), ex); 
                }
            }
            set
            {
                try
                {
                teklaObject.Clearance = value;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Clearance), ex); 
                }
            }
        }

        public RebarSplice.RebarSpliceBarPositionsEnum BarPositions
        {
            get
            {
                try
                {
                var value = teklaObject.BarPositions;
                var value_ = RebarSplice.RebarSpliceBarPositionsEnum_.FromTSObject(value);
                return (RebarSplice.RebarSpliceBarPositionsEnum) value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BarPositions), ex); 
                }
            }
            set
            {
                try
                {
                var value_ = RebarSplice.RebarSpliceBarPositionsEnum_.GetTSObject(value);
                teklaObject.BarPositions = value_;
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
                {
                    throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BarPositions), ex); 
                }
            }
        }
        

        

		public RebarSplice()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSplice");
		}
		
		public RebarSplice(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public RebarSplice(RebarGroup InputRebar1, RebarGroup InputRebar2)
		{
			var args = new object[2];
			args[0] = RebarGroup_.GetTSObject(InputRebar1);
			args[1] = RebarGroup_.GetTSObject(InputRebar2);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSplice", args);
		}




    public enum RebarSpliceTypeEnum
    {
			SPLICE_TYPE_LAP_RIGHT,
			SPLICE_TYPE_LAP_LEFT,
			SPLICE_TYPE_LAP_BOTH,
			SPLICE_TYPE_MUFF,
			SPLICE_TYPE_WELD        
    }

    internal static class RebarSpliceTypeEnum_
    {
        public static dynamic GetTSObject(RebarSpliceTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSplice.RebarSpliceTypeEnum").GetType();

            switch (dynEnum)
            {
				case RebarSpliceTypeEnum.SPLICE_TYPE_LAP_RIGHT:
					return System.Enum.Parse(tsType, "SPLICE_TYPE_LAP_RIGHT");
				case RebarSpliceTypeEnum.SPLICE_TYPE_LAP_LEFT:
					return System.Enum.Parse(tsType, "SPLICE_TYPE_LAP_LEFT");
				case RebarSpliceTypeEnum.SPLICE_TYPE_LAP_BOTH:
					return System.Enum.Parse(tsType, "SPLICE_TYPE_LAP_BOTH");
				case RebarSpliceTypeEnum.SPLICE_TYPE_MUFF:
					return System.Enum.Parse(tsType, "SPLICE_TYPE_MUFF");
				case RebarSpliceTypeEnum.SPLICE_TYPE_WELD:
					return System.Enum.Parse(tsType, "SPLICE_TYPE_WELD");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarSpliceTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("SPLICE_TYPE_LAP_RIGHT", System.StringComparison.InvariantCulture))
				return RebarSpliceTypeEnum.SPLICE_TYPE_LAP_RIGHT;
			else if (tsEnumValue.Equals("SPLICE_TYPE_LAP_LEFT", System.StringComparison.InvariantCulture))
				return RebarSpliceTypeEnum.SPLICE_TYPE_LAP_LEFT;
			else if (tsEnumValue.Equals("SPLICE_TYPE_LAP_BOTH", System.StringComparison.InvariantCulture))
				return RebarSpliceTypeEnum.SPLICE_TYPE_LAP_BOTH;
			else if (tsEnumValue.Equals("SPLICE_TYPE_MUFF", System.StringComparison.InvariantCulture))
				return RebarSpliceTypeEnum.SPLICE_TYPE_MUFF;
			else if (tsEnumValue.Equals("SPLICE_TYPE_WELD", System.StringComparison.InvariantCulture))
				return RebarSpliceTypeEnum.SPLICE_TYPE_WELD;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum RebarSpliceBarPositionsEnum
    {
			SPLICE_BAR_ON_TOP,
			SPLICE_BAR_PARALLEL        
    }

    internal static class RebarSpliceBarPositionsEnum_
    {
        public static dynamic GetTSObject(RebarSpliceBarPositionsEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarSplice.RebarSpliceBarPositionsEnum").GetType();

            switch (dynEnum)
            {
				case RebarSpliceBarPositionsEnum.SPLICE_BAR_ON_TOP:
					return System.Enum.Parse(tsType, "SPLICE_BAR_ON_TOP");
				case RebarSpliceBarPositionsEnum.SPLICE_BAR_PARALLEL:
					return System.Enum.Parse(tsType, "SPLICE_BAR_PARALLEL");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static RebarSpliceBarPositionsEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("SPLICE_BAR_ON_TOP", System.StringComparison.InvariantCulture))
				return RebarSpliceBarPositionsEnum.SPLICE_BAR_ON_TOP;
			else if (tsEnumValue.Equals("SPLICE_BAR_PARALLEL", System.StringComparison.InvariantCulture))
				return RebarSpliceBarPositionsEnum.SPLICE_BAR_PARALLEL;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class RebarSplice_
    {
        public static dynamic GetTSObject(RebarSplice dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static RebarSplice FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (RebarSplice)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class RebarSpliceArray_
    {
        public static dynamic GetTSObject(RebarSplice[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(RebarSplice_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static RebarSplice[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<RebarSplice>();
            foreach(var tsItem in tsArray)
            {
                list.Add(RebarSplice_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }



    
