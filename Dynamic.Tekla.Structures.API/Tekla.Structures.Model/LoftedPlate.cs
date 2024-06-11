using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections.Generic;

namespace Dynamic.Tekla.Structures.Model;

public class LoftedPlate : Part
{

    public List<Dynamic.Tekla.Structures.Geometry3d.ICurve> BaseCurves
    {
        get
        {
            try
            {
                var value = teklaObject.BaseCurves;
                var value_ = ListConverter.FromTSObjects<Dynamic.Tekla.Structures.Geometry3d.ICurve>(value);
                return (System.Collections.Generic.List<Dynamic.Tekla.Structures.Geometry3d.ICurve>)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BaseCurves), ex);
            }
        }
        set
        {
            try
            {
                var value_ = ListConverter.ToTSObjects(value);
                teklaObject.BaseCurves = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BaseCurves), ex);
            }
        }
    }

    public LoftedPlate.LoftedPlateFaceTypeEnum FaceType
    {
        get
        {
            try
            {
                var value = teklaObject.FaceType;
                var value_ = LoftedPlate.LoftedPlateFaceTypeEnum_.FromTSObject(value);
                return (LoftedPlate.LoftedPlateFaceTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FaceType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = LoftedPlate.LoftedPlateFaceTypeEnum_.GetTSObject(value);
                teklaObject.FaceType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FaceType), ex);
            }
        }
    }

    public LoftedPlate()
    {
        if (TeklaProcess.TeklaFileVersion < new Version("2019.1.0.0"))
            return;

        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LoftedPlate");
    }

    public LoftedPlate(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }

    public enum LoftedPlateFaceTypeEnum
    {
        Perpendicular,
        BoundedByCurvePlanes
    }

    internal static class LoftedPlateFaceTypeEnum_
    {
        public static dynamic GetTSObject(LoftedPlateFaceTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LoftedPlate.LoftedPlateFaceTypeEnum").GetType();

            switch (dynEnum)
            {
                case LoftedPlateFaceTypeEnum.Perpendicular:
                    return System.Enum.Parse(tsType, "Perpendicular");
                case LoftedPlateFaceTypeEnum.BoundedByCurvePlanes:
                    return System.Enum.Parse(tsType, "BoundedByCurvePlanes");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static LoftedPlateFaceTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("Perpendicular", System.StringComparison.InvariantCulture))
                return LoftedPlateFaceTypeEnum.Perpendicular;
            else if (tsEnumValue.Equals("BoundedByCurvePlanes", System.StringComparison.InvariantCulture))
                return LoftedPlateFaceTypeEnum.BoundedByCurvePlanes;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }
}

internal static class LoftedPlate_
{
    public static dynamic GetTSObject(LoftedPlate dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static LoftedPlate FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (LoftedPlate)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}


