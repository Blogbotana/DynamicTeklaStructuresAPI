using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public class RebarCranking
{


    public RebarCranking.CrankSideEnum CrankSide
    {
        get
        {
            try
            {
                var value = teklaObject.CrankSide;
                var value_ = RebarCranking.CrankSideEnum_.FromTSObject(value);
                return (RebarCranking.CrankSideEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankSide), ex);
            }
        }
        set
        {
            try
            {
                var value_ = RebarCranking.CrankSideEnum_.GetTSObject(value);
                teklaObject.CrankSide = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankSide), ex);
            }
        }
    }

    public double CrankRotation
    {
        get
        {
            try
            {
                return teklaObject.CrankRotation;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankRotation), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.CrankRotation = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankRotation), ex);
            }
        }
    }

    public double CrankStraightLength
    {
        get
        {
            try
            {
                return teklaObject.CrankStraightLength;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankStraightLength), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.CrankStraightLength = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankStraightLength), ex);
            }
        }
    }

    public RebarCranking.CrankedLengthTypeEnum CrankedLengthType
    {
        get
        {
            try
            {
                var value = teklaObject.CrankedLengthType;
                var value_ = RebarCranking.CrankedLengthTypeEnum_.FromTSObject(value);
                return (RebarCranking.CrankedLengthTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankedLengthType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = RebarCranking.CrankedLengthTypeEnum_.GetTSObject(value);
                teklaObject.CrankedLengthType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankedLengthType), ex);
            }
        }
    }

    public double CrankedRatio
    {
        get
        {
            try
            {
                return teklaObject.CrankedRatio;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankedRatio), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.CrankedRatio = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankedRatio), ex);
            }
        }
    }

    public double CrankedDistance
    {
        get
        {
            try
            {
                return teklaObject.CrankedDistance;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankedDistance), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.CrankedDistance = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankedDistance), ex);
            }
        }
    }

    public double CrankedOffset
    {
        get
        {
            try
            {
                return teklaObject.CrankedOffset;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankedOffset), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.CrankedOffset = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankedOffset), ex);
            }
        }
    }

    public RebarCranking.CrankingTypeEnum CrankingType
    {
        get
        {
            try
            {
                var value = teklaObject.CrankingType;
                var value_ = RebarCranking.CrankingTypeEnum_.FromTSObject(value);
                return (RebarCranking.CrankingTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankingType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = RebarCranking.CrankingTypeEnum_.GetTSObject(value);
                teklaObject.CrankingType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankingType), ex);
            }
        }
    }


    internal dynamic teklaObject;

    public RebarCranking()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarCranking");
    }

    public RebarCranking(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }




    public enum CrankSideEnum
    {
        CRANK_LEFT,
        CRANK_RIGHT
    }

    internal static class CrankSideEnum_
    {
        public static dynamic GetTSObject(CrankSideEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarCranking.CrankSideEnum").GetType();

            switch (dynEnum)
            {
                case CrankSideEnum.CRANK_LEFT:
                    return System.Enum.Parse(tsType, "CRANK_LEFT");
                case CrankSideEnum.CRANK_RIGHT:
                    return System.Enum.Parse(tsType, "CRANK_RIGHT");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static CrankSideEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("CRANK_LEFT", System.StringComparison.InvariantCulture))
                return CrankSideEnum.CRANK_LEFT;
            else if (tsEnumValue.Equals("CRANK_RIGHT", System.StringComparison.InvariantCulture))
                return CrankSideEnum.CRANK_RIGHT;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum CrankedLengthTypeEnum
    {
        DIAGONAL_RATIO,
        DIAGONAL_DISTANCE,
        HORIZONTAL_RATIO,
        HORIZONTAL_DISTANCE
    }

    internal static class CrankedLengthTypeEnum_
    {
        public static dynamic GetTSObject(CrankedLengthTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarCranking.CrankedLengthTypeEnum").GetType();

            switch (dynEnum)
            {
                case CrankedLengthTypeEnum.DIAGONAL_RATIO:
                    return System.Enum.Parse(tsType, "DIAGONAL_RATIO");
                case CrankedLengthTypeEnum.DIAGONAL_DISTANCE:
                    return System.Enum.Parse(tsType, "DIAGONAL_DISTANCE");
                case CrankedLengthTypeEnum.HORIZONTAL_RATIO:
                    return System.Enum.Parse(tsType, "HORIZONTAL_RATIO");
                case CrankedLengthTypeEnum.HORIZONTAL_DISTANCE:
                    return System.Enum.Parse(tsType, "HORIZONTAL_DISTANCE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static CrankedLengthTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("DIAGONAL_RATIO", System.StringComparison.InvariantCulture))
                return CrankedLengthTypeEnum.DIAGONAL_RATIO;
            else if (tsEnumValue.Equals("DIAGONAL_DISTANCE", System.StringComparison.InvariantCulture))
                return CrankedLengthTypeEnum.DIAGONAL_DISTANCE;
            else if (tsEnumValue.Equals("HORIZONTAL_RATIO", System.StringComparison.InvariantCulture))
                return CrankedLengthTypeEnum.HORIZONTAL_RATIO;
            else if (tsEnumValue.Equals("HORIZONTAL_DISTANCE", System.StringComparison.InvariantCulture))
                return CrankedLengthTypeEnum.HORIZONTAL_DISTANCE;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum CrankingTypeEnum
    {
        CUSTOM_CRANKING,
        STANDARD_CRANKING
    }

    internal static class CrankingTypeEnum_
    {
        public static dynamic GetTSObject(CrankingTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarCranking.CrankingTypeEnum").GetType();

            switch (dynEnum)
            {
                case CrankingTypeEnum.CUSTOM_CRANKING:
                    return System.Enum.Parse(tsType, "CUSTOM_CRANKING");
                case CrankingTypeEnum.STANDARD_CRANKING:
                    return System.Enum.Parse(tsType, "STANDARD_CRANKING");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static CrankingTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("CUSTOM_CRANKING", System.StringComparison.InvariantCulture))
                return CrankingTypeEnum.CUSTOM_CRANKING;
            else if (tsEnumValue.Equals("STANDARD_CRANKING", System.StringComparison.InvariantCulture))
                return CrankingTypeEnum.STANDARD_CRANKING;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class RebarCranking_
{
    public static dynamic GetTSObject(RebarCranking dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static RebarCranking FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (RebarCranking)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class RebarCrankingArray_
{
    public static dynamic GetTSObject(RebarCranking[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(RebarCranking_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static RebarCranking[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<RebarCranking>();
        foreach (var tsItem in tsArray)
        {
            list.Add(RebarCranking_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}




