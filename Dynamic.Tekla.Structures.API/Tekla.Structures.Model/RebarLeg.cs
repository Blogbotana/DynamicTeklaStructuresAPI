using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public class RebarLeg
{


    public Dynamic.Tekla.Structures.Geometry3d.ICurve Curve
    {
        get
        {
            try
            {
                var value = teklaObject.Curve;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.ICurve_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.ICurve)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Curve), ex);
            }
        }

    }

    public RebarLeg.OriginEnum Origin
    {
        get
        {
            try
            {
                var value = teklaObject.Origin;
                var value_ = RebarLeg.OriginEnum_.FromTSObject(value);
                return (RebarLeg.OriginEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Origin), ex);
            }
        }

    }


    internal dynamic teklaObject;

    internal RebarLeg() { }

    public RebarLeg(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }




    public enum OriginEnum
    {
        NORMAL,
        HOOK,
        CRANK
    }

    internal static class OriginEnum_
    {
        public static dynamic GetTSObject(OriginEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLeg.OriginEnum").GetType();

            switch (dynEnum)
            {
                case OriginEnum.NORMAL:
                    return System.Enum.Parse(tsType, "NORMAL");
                case OriginEnum.HOOK:
                    return System.Enum.Parse(tsType, "HOOK");
                case OriginEnum.CRANK:
                    return System.Enum.Parse(tsType, "CRANK");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static OriginEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("NORMAL", System.StringComparison.InvariantCulture))
                return OriginEnum.NORMAL;
            else if (tsEnumValue.Equals("HOOK", System.StringComparison.InvariantCulture))
                return OriginEnum.HOOK;
            else if (tsEnumValue.Equals("CRANK", System.StringComparison.InvariantCulture))
                return OriginEnum.CRANK;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class RebarLeg_
{
    public static dynamic GetTSObject(RebarLeg dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static RebarLeg FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (RebarLeg)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class RebarLegArray_
{
    public static dynamic GetTSObject(RebarLeg[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(RebarLeg_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static RebarLeg[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<RebarLeg>();
        foreach (var tsItem in tsArray)
        {
            list.Add(RebarLeg_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}




