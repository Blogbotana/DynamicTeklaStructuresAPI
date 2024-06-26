using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;
public class RebarCrankingNullable
{


    public System.Nullable<double> CrankRotation
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

    public System.Nullable<double> CrankStraightLength
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

    public System.Nullable<RebarCranking.CrankedLengthTypeEnum> CrankedLengthType
    {
        get
        {
            try
            {
                var value = teklaObject.CrankedLengthType;
                var value_ = NullableConverter.FromTSObject<RebarCranking.CrankedLengthTypeEnum>(value);
                return (System.Nullable<RebarCranking.CrankedLengthTypeEnum>)value_;
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
                var value_ = NullableConverter.ToTSObjects(value);
                teklaObject.CrankedLengthType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankedLengthType), ex);
            }
        }
    }

    public System.Nullable<double> CrankedRatio
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

    public System.Nullable<double> CrankedDistance
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

    public System.Nullable<double> CrankedOffset
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

    public System.Nullable<RebarCrankingNullable.EndCrankingTypeEnum> CrankingType
    {
        get
        {
            try
            {
                var value = teklaObject.CrankingType;
                var value_ = NullableConverter.FromTSObject<RebarCrankingNullable.EndCrankingTypeEnum>(value);
                return (System.Nullable<RebarCrankingNullable.EndCrankingTypeEnum>)value_;
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
                var value_ = NullableConverter.ToTSObjects(value);
                teklaObject.CrankingType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CrankingType), ex);
            }
        }
    }


    internal dynamic teklaObject;

    public RebarCrankingNullable()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarCrankingNullable");
    }

    public RebarCrankingNullable(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }




    public enum EndCrankingTypeEnum
    {
        NO_CRANKING,
        CUSTOM_CRANKING,
        STANDARD_CRANKING
    }

    internal static class EndCrankingTypeEnum_
    {
        public static dynamic GetTSObject(EndCrankingTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarCrankingNullable.EndCrankingTypeEnum").GetType();

            switch (dynEnum)
            {
                case EndCrankingTypeEnum.NO_CRANKING:
                    return System.Enum.Parse(tsType, "NO_CRANKING");
                case EndCrankingTypeEnum.CUSTOM_CRANKING:
                    return System.Enum.Parse(tsType, "CUSTOM_CRANKING");
                case EndCrankingTypeEnum.STANDARD_CRANKING:
                    return System.Enum.Parse(tsType, "STANDARD_CRANKING");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static EndCrankingTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("NO_CRANKING", System.StringComparison.InvariantCulture))
                return EndCrankingTypeEnum.NO_CRANKING;
            else if (tsEnumValue.Equals("CUSTOM_CRANKING", System.StringComparison.InvariantCulture))
                return EndCrankingTypeEnum.CUSTOM_CRANKING;
            else if (tsEnumValue.Equals("STANDARD_CRANKING", System.StringComparison.InvariantCulture))
                return EndCrankingTypeEnum.STANDARD_CRANKING;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class RebarCrankingNullable_
{
    public static dynamic GetTSObject(RebarCrankingNullable dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static RebarCrankingNullable FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (RebarCrankingNullable)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class RebarCrankingNullableArray_
{
    public static dynamic GetTSObject(RebarCrankingNullable[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(RebarCrankingNullable_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static RebarCrankingNullable[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<RebarCrankingNullable>();
        foreach (var tsItem in tsArray)
        {
            list.Add(RebarCrankingNullable_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}




