using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
public abstract class BaseRebarGroup : Reinforcement
{
    public string Size
    {
        get
        {
            try
            {
                return teklaObject.Size;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Size), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Size = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Size), ex);
            }
        }
    }

    public RebarHookData StartHook
    {
        get
        {
            try
            {
                var value = teklaObject.StartHook;
                var value_ = RebarHookData_.FromTSObject(value);
                return (RebarHookData)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartHook), ex);
            }
        }
        set
        {
            try
            {
                var value_ = RebarHookData_.GetTSObject(value);
                teklaObject.StartHook = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartHook), ex);
            }
        }
    }

    public RebarHookData EndHook
    {
        get
        {
            try
            {
                var value = teklaObject.EndHook;
                var value_ = RebarHookData_.FromTSObject(value);
                return (RebarHookData)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndHook), ex);
            }
        }
        set
        {
            try
            {
                var value_ = RebarHookData_.GetTSObject(value);
                teklaObject.EndHook = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndHook), ex);
            }
        }
    }

    public double FromPlaneOffset
    {
        get
        {
            try
            {
                return teklaObject.FromPlaneOffset;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FromPlaneOffset), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.FromPlaneOffset = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FromPlaneOffset), ex);
            }
        }
    }

    public double StartFromPlaneOffset
    {
        get
        {
            try
            {
                return teklaObject.StartFromPlaneOffset;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartFromPlaneOffset), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.StartFromPlaneOffset = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartFromPlaneOffset), ex);
            }
        }
    }

    public double EndFromPlaneOffset
    {
        get
        {
            try
            {
                return teklaObject.EndFromPlaneOffset;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndFromPlaneOffset), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.EndFromPlaneOffset = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndFromPlaneOffset), ex);
            }
        }
    }

    public BaseRebarGroup.ExcludeTypeEnum ExcludeType
    {
        get
        {
            try
            {
                var value = teklaObject.ExcludeType;
                var value_ = BaseRebarGroup.ExcludeTypeEnum_.FromTSObject(value);
                return (BaseRebarGroup.ExcludeTypeEnum)value_;
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
                var value_ = BaseRebarGroup.ExcludeTypeEnum_.GetTSObject(value);
                teklaObject.ExcludeType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExcludeType), ex);
            }
        }
    }

    public BaseRebarGroup.RebarGroupSpacingTypeEnum SpacingType
    {
        get
        {
            try
            {
                var value = teklaObject.SpacingType;
                var value_ = BaseRebarGroup.RebarGroupSpacingTypeEnum_.FromTSObject(value);
                return (BaseRebarGroup.RebarGroupSpacingTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SpacingType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BaseRebarGroup.RebarGroupSpacingTypeEnum_.GetTSObject(value);
                teklaObject.SpacingType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SpacingType), ex);
            }
        }
    }

    public System.Collections.ArrayList Spacings
    {
        get
        {
            try
            {
                var value = teklaObject.Spacings;
                var value_ = ArrayListConverter.FromTSObjects(value);
                return (System.Collections.ArrayList)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Spacings), ex);
            }
        }
        set
        {
            try
            {
                var value_ = ArrayListConverter.ToTSObjects(value);
                teklaObject.Spacings = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Spacings), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
    {
        get
        {
            try
            {
                var value = teklaObject.StartPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPoint), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.StartPoint = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPoint), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
    {
        get
        {
            try
            {
                var value = teklaObject.EndPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPoint), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.EndPoint = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPoint), ex);
            }
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
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseRebarGroup.ExcludeTypeEnum").GetType();

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


    /// <summary>
    /// The ways to distribute the reinforcing bars with different spacings.
    /// </summary>
    public enum RebarGroupSpacingTypeEnum
    {
        /// <summary>
        /// The undefined spacing type.
        /// </summary>
        SPACING_TYPE_UNDEFINED,
        /// <summary>
        /// The bars are distributed using the spacing values.
        /// </summary>
        SPACING_TYPE_EXACT_SPACINGS,
        /// <summary>
        /// Equal distribution by the number of reinforcing bars.
        /// </summary>
        SPACING_TYPE_EXACT_NUMBER,
        /// <summary>
        /// Equal distribution by the target spacing value.
        /// </summary>
        SPACING_TYPE_TARGET_SPACE,
        /// <summary>
        /// Distribution by the exact spacing value with a flexible first space.
        /// </summary>
        SPACING_TYPE_EXACT_SPACE_FLEX_AT_START,
        /// <summary>
        /// Distribution by the exact spacing value with a flexible last space.
        /// </summary>
        SPACING_TYPE_EXACT_SPACE_FLEX_AT_END,
        /// <summary>
        /// Distribution by the exact spacing value with flexible first and last spaces.
        /// </summary>
        SPACING_TYPE_EXACT_SPACE_FLEX_AT_BOTH,
        /// <summary>
        /// Distribution by the exact spacing value with a flexible middle space.
        /// </summary>
        SPACING_TYPE_EXACT_SPACE_FLEX_AT_MIDDLE
    }

    internal static class RebarGroupSpacingTypeEnum_
    {
        public static dynamic GetTSObject(RebarGroupSpacingTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BaseRebarGroup.RebarGroupSpacingTypeEnum").GetType();

            switch (dynEnum)
            {
                case RebarGroupSpacingTypeEnum.SPACING_TYPE_UNDEFINED:
                    return System.Enum.Parse(tsType, "SPACING_TYPE_UNDEFINED");
                case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACINGS:
                    return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_SPACINGS");
                case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_NUMBER:
                    return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_NUMBER");
                case RebarGroupSpacingTypeEnum.SPACING_TYPE_TARGET_SPACE:
                    return System.Enum.Parse(tsType, "SPACING_TYPE_TARGET_SPACE");
                case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_START:
                    return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_SPACE_FLEX_AT_START");
                case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_END:
                    return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_SPACE_FLEX_AT_END");
                case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_BOTH:
                    return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_SPACE_FLEX_AT_BOTH");
                case RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_MIDDLE:
                    return System.Enum.Parse(tsType, "SPACING_TYPE_EXACT_SPACE_FLEX_AT_MIDDLE");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static RebarGroupSpacingTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("SPACING_TYPE_UNDEFINED", System.StringComparison.InvariantCulture))
                return RebarGroupSpacingTypeEnum.SPACING_TYPE_UNDEFINED;
            else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_SPACINGS", System.StringComparison.InvariantCulture))
                return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACINGS;
            else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_NUMBER", System.StringComparison.InvariantCulture))
                return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_NUMBER;
            else if (tsEnumValue.Equals("SPACING_TYPE_TARGET_SPACE", System.StringComparison.InvariantCulture))
                return RebarGroupSpacingTypeEnum.SPACING_TYPE_TARGET_SPACE;
            else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_SPACE_FLEX_AT_START", System.StringComparison.InvariantCulture))
                return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_START;
            else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_SPACE_FLEX_AT_END", System.StringComparison.InvariantCulture))
                return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_END;
            else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_SPACE_FLEX_AT_BOTH", System.StringComparison.InvariantCulture))
                return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_BOTH;
            else if (tsEnumValue.Equals("SPACING_TYPE_EXACT_SPACE_FLEX_AT_MIDDLE", System.StringComparison.InvariantCulture))
                return RebarGroupSpacingTypeEnum.SPACING_TYPE_EXACT_SPACE_FLEX_AT_MIDDLE;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }

}

internal static class BaseRebarGroup_
{
    public static dynamic GetTSObject(BaseRebarGroup dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static BaseRebarGroup FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (BaseRebarGroup)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
