using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public class ClashCheckData
{


    public ModelObject Object1
    {
        get
        {
            try
            {
                var value = teklaObject.Object1;
                var value_ = ModelObject_.FromTSObject(value);
                return (ModelObject)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Object1), ex);
            }
        }

    }

    public ModelObject Object2
    {
        get
        {
            try
            {
                var value = teklaObject.Object2;
                var value_ = ModelObject_.FromTSObject(value);
                return (ModelObject)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Object2), ex);
            }
        }

    }

    public ClashCheckData.ClashTypeEnum Type
    {
        get
        {
            try
            {
                var value = teklaObject.Type;
                var value_ = ClashCheckData.ClashTypeEnum_.FromTSObject(value);
                return (ClashCheckData.ClashTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex);
            }
        }

    }

    public double Overlap
    {
        get
        {
            try
            {
                return teklaObject.Overlap;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Overlap), ex);
            }
        }

    }


    internal dynamic teklaObject;

    public ClashCheckData()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ClashCheckData");
    }
    
    public ClashCheckData(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }




    public enum ClashTypeEnum
    {
        CLASH_TYPE_INVALID,
        CLASH_TYPE_ISINSIDE,
        CLASH_TYPE_EXACTMATCH,
        CLASH_TYPE_CLASH,
        CLASH_TYPE_MINDISTANCE,
        CLASH_TYPE_FAILEDSOLID,
        CLASH_TYPE_CUTTHROUGH,
        CLASH_TYPE_COMPLEXCLASH,
        CLASH_TYPE_FAILEDTEST
    }

    internal static class ClashTypeEnum_
    {
        public static dynamic GetTSObject(ClashTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ClashCheckData.ClashTypeEnum").GetType();

            switch (dynEnum)
            {
                case ClashTypeEnum.CLASH_TYPE_INVALID:
                    return System.Enum.Parse(tsType, "CLASH_TYPE_INVALID");
                case ClashTypeEnum.CLASH_TYPE_ISINSIDE:
                    return System.Enum.Parse(tsType, "CLASH_TYPE_ISINSIDE");
                case ClashTypeEnum.CLASH_TYPE_EXACTMATCH:
                    return System.Enum.Parse(tsType, "CLASH_TYPE_EXACTMATCH");
                case ClashTypeEnum.CLASH_TYPE_CLASH:
                    return System.Enum.Parse(tsType, "CLASH_TYPE_CLASH");
                case ClashTypeEnum.CLASH_TYPE_MINDISTANCE:
                    return System.Enum.Parse(tsType, "CLASH_TYPE_MINDISTANCE");
                case ClashTypeEnum.CLASH_TYPE_FAILEDSOLID:
                    return System.Enum.Parse(tsType, "CLASH_TYPE_FAILEDSOLID");
                case ClashTypeEnum.CLASH_TYPE_CUTTHROUGH:
                    return System.Enum.Parse(tsType, "CLASH_TYPE_CUTTHROUGH");
                case ClashTypeEnum.CLASH_TYPE_COMPLEXCLASH:
                    return System.Enum.Parse(tsType, "CLASH_TYPE_COMPLEXCLASH");
                case ClashTypeEnum.CLASH_TYPE_FAILEDTEST:
                    return System.Enum.Parse(tsType, "CLASH_TYPE_FAILEDTEST");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static ClashTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("CLASH_TYPE_INVALID", System.StringComparison.InvariantCulture))
                return ClashTypeEnum.CLASH_TYPE_INVALID;
            else if (tsEnumValue.Equals("CLASH_TYPE_ISINSIDE", System.StringComparison.InvariantCulture))
                return ClashTypeEnum.CLASH_TYPE_ISINSIDE;
            else if (tsEnumValue.Equals("CLASH_TYPE_EXACTMATCH", System.StringComparison.InvariantCulture))
                return ClashTypeEnum.CLASH_TYPE_EXACTMATCH;
            else if (tsEnumValue.Equals("CLASH_TYPE_CLASH", System.StringComparison.InvariantCulture))
                return ClashTypeEnum.CLASH_TYPE_CLASH;
            else if (tsEnumValue.Equals("CLASH_TYPE_MINDISTANCE", System.StringComparison.InvariantCulture))
                return ClashTypeEnum.CLASH_TYPE_MINDISTANCE;
            else if (tsEnumValue.Equals("CLASH_TYPE_FAILEDSOLID", System.StringComparison.InvariantCulture))
                return ClashTypeEnum.CLASH_TYPE_FAILEDSOLID;
            else if (tsEnumValue.Equals("CLASH_TYPE_CUTTHROUGH", System.StringComparison.InvariantCulture))
                return ClashTypeEnum.CLASH_TYPE_CUTTHROUGH;
            else if (tsEnumValue.Equals("CLASH_TYPE_COMPLEXCLASH", System.StringComparison.InvariantCulture))
                return ClashTypeEnum.CLASH_TYPE_COMPLEXCLASH;
            else if (tsEnumValue.Equals("CLASH_TYPE_FAILEDTEST", System.StringComparison.InvariantCulture))
                return ClashTypeEnum.CLASH_TYPE_FAILEDTEST;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class ClashCheckData_
{
    public static dynamic GetTSObject(ClashCheckData dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ClashCheckData FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ClashCheckData)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

