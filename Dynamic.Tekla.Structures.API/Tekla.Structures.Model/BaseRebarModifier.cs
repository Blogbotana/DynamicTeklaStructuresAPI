using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
public abstract class BaseRebarModifier : ModelObject
{
    public RebarSet Father
    {
        get
        {
            try
            {
                var value = teklaObject.Father;
                var value_ = RebarSet_.FromTSObject(value);
                return (RebarSet)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Father), ex);
            }
        }
        set
        {
            try
            {
                var value_ = RebarSet_.GetTSObject(value);
                teklaObject.Father = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Father), ex);
            }
        }
    }

    public Contour Curve
    {
        get
        {
            try
            {
                var value = teklaObject.Curve;
                var value_ = Contour_.FromTSObject(value);
                return (Contour)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Curve), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Contour_.GetTSObject(value);
                teklaObject.Curve = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Curve), ex);
            }
        }
    }

    public BaseRebarModifier.BarsAffectedEnum BarsAffected
    {
        get
        {
            try
            {
                var value = teklaObject.BarsAffected;
                var value_ = BaseRebarModifier.BarsAffectedEnum_.FromTSObject(value);
                return (BaseRebarModifier.BarsAffectedEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BarsAffected), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BaseRebarModifier.BarsAffectedEnum_.GetTSObject(value);
                teklaObject.BarsAffected = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BarsAffected), ex);
            }
        }
    }

    public int FirstAffectedBar
    {
        get
        {
            try
            {
                return teklaObject.FirstAffectedBar;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FirstAffectedBar), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.FirstAffectedBar = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FirstAffectedBar), ex);
            }
        }
    }

    public bool FollowEdges
    {
        get
        {
            try
            {
                return teklaObject.FollowEdges;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FollowEdges), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.FollowEdges = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FollowEdges), ex);
            }
        }
    }








    public enum AffectedRebarEnum
    {
        START,
        END,
        EITHER
    }

    internal static class AffectedRebarEnum_
    {
        public static dynamic GetTSObject(AffectedRebarEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseRebarModifier.AffectedRebarEnum").GetType();

            switch (dynEnum)
            {
                case AffectedRebarEnum.START:
                    return System.Enum.Parse(tsType, "START");
                case AffectedRebarEnum.END:
                    return System.Enum.Parse(tsType, "END");
                case AffectedRebarEnum.EITHER:
                    return System.Enum.Parse(tsType, "EITHER");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static AffectedRebarEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("START", System.StringComparison.InvariantCulture))
                return AffectedRebarEnum.START;
            else if (tsEnumValue.Equals("END", System.StringComparison.InvariantCulture))
                return AffectedRebarEnum.END;
            else if (tsEnumValue.Equals("EITHER", System.StringComparison.InvariantCulture))
                return AffectedRebarEnum.EITHER;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum BarsAffectedEnum
    {
        ALL_BARS,
        EVERY_SECOND_BAR,
        EVERY_THIRD_BAR,
        EVERY_FOURTH_BAR
    }

    internal static class BarsAffectedEnum_
    {
        public static dynamic GetTSObject(BarsAffectedEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseRebarModifier.BarsAffectedEnum").GetType();

            switch (dynEnum)
            {
                case BarsAffectedEnum.ALL_BARS:
                    return System.Enum.Parse(tsType, "ALL_BARS");
                case BarsAffectedEnum.EVERY_SECOND_BAR:
                    return System.Enum.Parse(tsType, "EVERY_SECOND_BAR");
                case BarsAffectedEnum.EVERY_THIRD_BAR:
                    return System.Enum.Parse(tsType, "EVERY_THIRD_BAR");
                case BarsAffectedEnum.EVERY_FOURTH_BAR:
                    return System.Enum.Parse(tsType, "EVERY_FOURTH_BAR");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static BarsAffectedEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("ALL_BARS", System.StringComparison.InvariantCulture))
                return BarsAffectedEnum.ALL_BARS;
            else if (tsEnumValue.Equals("EVERY_SECOND_BAR", System.StringComparison.InvariantCulture))
                return BarsAffectedEnum.EVERY_SECOND_BAR;
            else if (tsEnumValue.Equals("EVERY_THIRD_BAR", System.StringComparison.InvariantCulture))
                return BarsAffectedEnum.EVERY_THIRD_BAR;
            else if (tsEnumValue.Equals("EVERY_FOURTH_BAR", System.StringComparison.InvariantCulture))
                return BarsAffectedEnum.EVERY_FOURTH_BAR;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class BaseRebarModifier_
{
    public static dynamic GetTSObject(BaseRebarModifier dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static BaseRebarModifier FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (BaseRebarModifier)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
