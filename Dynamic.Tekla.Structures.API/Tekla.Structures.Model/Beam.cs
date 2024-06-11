using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
public sealed class Beam : Part
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

    public Offset StartPointOffset
    {
        get
        {
            try
            {
                var value = teklaObject.StartPointOffset;
                var value_ = Offset_.FromTSObject(value);
                return (Offset)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPointOffset), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Offset_.GetTSObject(value);
                teklaObject.StartPointOffset = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPointOffset), ex);
            }
        }
    }

    public Offset EndPointOffset
    {
        get
        {
            try
            {
                var value = teklaObject.EndPointOffset;
                var value_ = Offset_.FromTSObject(value);
                return (Offset)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPointOffset), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Offset_.GetTSObject(value);
                teklaObject.EndPointOffset = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPointOffset), ex);
            }
        }
    }

    public Beam.BeamTypeEnum Type
    {
        get
        {
            try
            {
                var value = teklaObject.Type;
                var value_ = Beam.BeamTypeEnum_.FromTSObject(value);
                return (Beam.BeamTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex);
            }
        }

    }




    public Beam()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Beam");
    }
    
    public Beam(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public Beam(Beam.BeamTypeEnum beamType)
    {
        var args = new object[1];
        args[0] = Beam.BeamTypeEnum_.GetTSObject(beamType);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Beam", args);
    }
    public Beam(Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint)
    {
        var args = new object[2];
        args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
        args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Beam", args);
    }




    public enum BeamTypeEnum
    {
        BEAM,
        PANEL,
        STRIP_FOOTING,
        PAD_FOOTING,
        COLUMN
    }

    internal static class BeamTypeEnum_
    {
        public static dynamic GetTSObject(BeamTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Beam.BeamTypeEnum").GetType();

            switch (dynEnum)
            {
                case BeamTypeEnum.BEAM:
                    return System.Enum.Parse(tsType, "BEAM");
                case BeamTypeEnum.PANEL:
                    return System.Enum.Parse(tsType, "PANEL");
                case BeamTypeEnum.STRIP_FOOTING:
                    return System.Enum.Parse(tsType, "STRIP_FOOTING");
                case BeamTypeEnum.PAD_FOOTING:
                    return System.Enum.Parse(tsType, "PAD_FOOTING");
                case BeamTypeEnum.COLUMN:
                    return System.Enum.Parse(tsType, "COLUMN");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static BeamTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("BEAM", System.StringComparison.InvariantCulture))
                return BeamTypeEnum.BEAM;
            else if (tsEnumValue.Equals("PANEL", System.StringComparison.InvariantCulture))
                return BeamTypeEnum.PANEL;
            else if (tsEnumValue.Equals("STRIP_FOOTING", System.StringComparison.InvariantCulture))
                return BeamTypeEnum.STRIP_FOOTING;
            else if (tsEnumValue.Equals("PAD_FOOTING", System.StringComparison.InvariantCulture))
                return BeamTypeEnum.PAD_FOOTING;
            else if (tsEnumValue.Equals("COLUMN", System.StringComparison.InvariantCulture))
                return BeamTypeEnum.COLUMN;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class Beam_
{
    public static dynamic GetTSObject(Beam dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Beam FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Beam)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
