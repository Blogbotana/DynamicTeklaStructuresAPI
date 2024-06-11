using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;
public class SpiralBeam : Part
{


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

    public Dynamic.Tekla.Structures.Geometry3d.Point RotationAxisBasePoint
    {
        get
        {
            try
            {
                var value = teklaObject.RotationAxisBasePoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RotationAxisBasePoint), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.RotationAxisBasePoint = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RotationAxisBasePoint), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point RotationAxisUpPoint
    {
        get
        {
            try
            {
                var value = teklaObject.RotationAxisUpPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RotationAxisUpPoint), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.RotationAxisUpPoint = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RotationAxisUpPoint), ex);
            }
        }
    }

    public double TotalRise
    {
        get
        {
            try
            {
                return teklaObject.TotalRise;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TotalRise), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.TotalRise = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TotalRise), ex);
            }
        }
    }

    public double RotationAngle
    {
        get
        {
            try
            {
                return teklaObject.RotationAngle;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RotationAngle), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.RotationAngle = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RotationAngle), ex);
            }
        }
    }

    public double TwistAngleStart
    {
        get
        {
            try
            {
                return teklaObject.TwistAngleStart;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TwistAngleStart), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.TwistAngleStart = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TwistAngleStart), ex);
            }
        }
    }

    public double TwistAngleEnd
    {
        get
        {
            try
            {
                return teklaObject.TwistAngleEnd;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TwistAngleEnd), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.TwistAngleEnd = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(TwistAngleEnd), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point RotationCenterPoint
    {
        get
        {
            try
            {
                var value = teklaObject.RotationCenterPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RotationCenterPoint), ex);
            }
        }

    }

    public Dynamic.Tekla.Structures.Geometry3d.Vector RotationAxisDirection
    {
        get
        {
            try
            {
                var value = teklaObject.RotationAxisDirection;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RotationAxisDirection), ex);
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

    }




    public SpiralBeam()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SpiralBeam");
    }

    public SpiralBeam(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public SpiralBeam(Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point rotationAxisBasePoint, Dynamic.Tekla.Structures.Geometry3d.Point rotationAxisUpPoint, double totalRise, double rotationAngle, double twistAngleAtStart, double twistAngleAtEnd)
    {
        var args = new object[7];
        args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
        args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(rotationAxisBasePoint);
        args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(rotationAxisUpPoint);
        args[3] = totalRise;
        args[4] = rotationAngle;
        args[5] = twistAngleAtStart;
        args[6] = twistAngleAtEnd;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SpiralBeam", args);
    }
    public SpiralBeam(Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point rotationAxisBasePoint, Dynamic.Tekla.Structures.Geometry3d.Point rotationAxisUpPoint, double totalRise, double rotationAngle)
    {
        var args = new object[5];
        args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
        args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(rotationAxisBasePoint);
        args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(rotationAxisUpPoint);
        args[3] = totalRise;
        args[4] = rotationAngle;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SpiralBeam", args);
    }
    public SpiralBeam(Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point rotationAxisPoint, double totalRise, double rotationAngle)
    {
        var args = new object[4];
        args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
        args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(rotationAxisPoint);
        args[2] = totalRise;
        args[3] = rotationAngle;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SpiralBeam", args);
    }




    public enum ErrorStatus
    {
        DataMissing,
        DefinitionPointsTooClose,
        DefinitionPointsCannotBeAligned,
        ZeroTotalRiseWithMore360Degrees,
        RotationAngleIs0Degrees,
        InvalidGeometry
    }

    internal static class ErrorStatus_
    {
        public static dynamic GetTSObject(ErrorStatus dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.SpiralBeam.ErrorStatus").GetType();

            switch (dynEnum)
            {
                case ErrorStatus.DataMissing:
                    return System.Enum.Parse(tsType, "DataMissing");
                case ErrorStatus.DefinitionPointsTooClose:
                    return System.Enum.Parse(tsType, "DefinitionPointsTooClose");
                case ErrorStatus.DefinitionPointsCannotBeAligned:
                    return System.Enum.Parse(tsType, "DefinitionPointsCannotBeAligned");
                case ErrorStatus.ZeroTotalRiseWithMore360Degrees:
                    return System.Enum.Parse(tsType, "ZeroTotalRiseWithMore360Degrees");
                case ErrorStatus.RotationAngleIs0Degrees:
                    return System.Enum.Parse(tsType, "RotationAngleIs0Degrees");
                case ErrorStatus.InvalidGeometry:
                    return System.Enum.Parse(tsType, "InvalidGeometry");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static ErrorStatus FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("DataMissing", System.StringComparison.InvariantCulture))
                return ErrorStatus.DataMissing;
            else if (tsEnumValue.Equals("DefinitionPointsTooClose", System.StringComparison.InvariantCulture))
                return ErrorStatus.DefinitionPointsTooClose;
            else if (tsEnumValue.Equals("DefinitionPointsCannotBeAligned", System.StringComparison.InvariantCulture))
                return ErrorStatus.DefinitionPointsCannotBeAligned;
            else if (tsEnumValue.Equals("ZeroTotalRiseWithMore360Degrees", System.StringComparison.InvariantCulture))
                return ErrorStatus.ZeroTotalRiseWithMore360Degrees;
            else if (tsEnumValue.Equals("RotationAngleIs0Degrees", System.StringComparison.InvariantCulture))
                return ErrorStatus.RotationAngleIs0Degrees;
            else if (tsEnumValue.Equals("InvalidGeometry", System.StringComparison.InvariantCulture))
                return ErrorStatus.InvalidGeometry;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class SpiralBeam_
{
    public static dynamic GetTSObject(SpiralBeam dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static SpiralBeam FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (SpiralBeam)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class SpiralBeamArray_
{
    public static dynamic GetTSObject(SpiralBeam[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(SpiralBeam_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static SpiralBeam[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<SpiralBeam>();
        foreach (var tsItem in tsArray)
        {
            list.Add(SpiralBeam_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}



