using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public class RebarGroup : BaseRebarGroup
{


    public System.Collections.ArrayList Polygons
    {
        get
        {
            try
            {
                var value = teklaObject.Polygons;
                var value_ = ArrayListConverter.FromTSObjects(value);
                return (System.Collections.ArrayList)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Polygons), ex);
            }
        }
        set
        {
            try
            {
                var value_ = ArrayListConverter.ToTSObjects(value);
                teklaObject.Polygons = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Polygons), ex);
            }
        }
    }

    public RebarGroup.RebarGroupStirrupTypeEnum StirrupType
    {
        get
        {
            try
            {
                var value = teklaObject.StirrupType;
                var value_ = RebarGroup.RebarGroupStirrupTypeEnum_.FromTSObject(value);
                return (RebarGroup.RebarGroupStirrupTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StirrupType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = RebarGroup.RebarGroupStirrupTypeEnum_.GetTSObject(value);
                teklaObject.StirrupType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StirrupType), ex);
            }
        }
    }




    public RebarGroup()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarGroup");
    }

    public RebarGroup(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }




    public enum RebarGroupStirrupTypeEnum
    {
        STIRRUP_TYPE_POLYGONAL,
        STIRRUP_TYPE_SPIRAL,
        STIRRUP_TYPE_TAPERED_CURVED
    }

    internal static class RebarGroupStirrupTypeEnum_
    {
        public static dynamic GetTSObject(RebarGroupStirrupTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarGroup.RebarGroupStirrupTypeEnum").GetType();

            switch (dynEnum)
            {
                case RebarGroupStirrupTypeEnum.STIRRUP_TYPE_POLYGONAL:
                    return System.Enum.Parse(tsType, "STIRRUP_TYPE_POLYGONAL");
                case RebarGroupStirrupTypeEnum.STIRRUP_TYPE_SPIRAL:
                    return System.Enum.Parse(tsType, "STIRRUP_TYPE_SPIRAL");
                case RebarGroupStirrupTypeEnum.STIRRUP_TYPE_TAPERED_CURVED:
                    return System.Enum.Parse(tsType, "STIRRUP_TYPE_TAPERED_CURVED");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static RebarGroupStirrupTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("STIRRUP_TYPE_POLYGONAL", System.StringComparison.InvariantCulture))
                return RebarGroupStirrupTypeEnum.STIRRUP_TYPE_POLYGONAL;
            else if (tsEnumValue.Equals("STIRRUP_TYPE_SPIRAL", System.StringComparison.InvariantCulture))
                return RebarGroupStirrupTypeEnum.STIRRUP_TYPE_SPIRAL;
            else if (tsEnumValue.Equals("STIRRUP_TYPE_TAPERED_CURVED", System.StringComparison.InvariantCulture))
                return RebarGroupStirrupTypeEnum.STIRRUP_TYPE_TAPERED_CURVED;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class RebarGroup_
{
    public static dynamic GetTSObject(RebarGroup dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static RebarGroup FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (RebarGroup)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class RebarGroupArray_
{
    public static dynamic GetTSObject(RebarGroup[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(RebarGroup_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static RebarGroup[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<RebarGroup>();
        foreach (var tsItem in tsArray)
        {
            list.Add(RebarGroup_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}




