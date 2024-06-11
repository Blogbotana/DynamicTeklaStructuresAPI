using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
public sealed class Chamfer
{

    public Chamfer.ChamferTypeEnum Type
    {
        get
        {
            try
            {
                var value = teklaObject.Type;
                var value_ = Chamfer.ChamferTypeEnum_.FromTSObject(value);
                return (Chamfer.ChamferTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Chamfer.ChamferTypeEnum_.GetTSObject(value);
                teklaObject.Type = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex);
            }
        }
    }

    public double X
    {
        get
        {
            try
            {
                return teklaObject.X;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(X), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.X = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(X), ex);
            }
        }
    }

    public double Y
    {
        get
        {
            try
            {
                return teklaObject.Y;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Y), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Y = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Y), ex);
            }
        }
    }

    public double DZ1
    {
        get
        {
            try
            {
                return teklaObject.DZ1;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DZ1), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.DZ1 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DZ1), ex);
            }
        }
    }

    public double DZ2
    {
        get
        {
            try
            {
                return teklaObject.DZ2;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DZ2), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.DZ2 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DZ2), ex);
            }
        }
    }


    internal dynamic teklaObject;

    public Chamfer()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Chamfer");
    }
    
    public Chamfer(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public Chamfer(double X, double Y, Chamfer.ChamferTypeEnum Type)
    {
        var args = new object[3];
        args[0] = X;
        args[1] = Y;
        args[2] = Chamfer.ChamferTypeEnum_.GetTSObject(Type);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Chamfer", args);
    }




    public enum ChamferTypeEnum
    {
        CHAMFER_NONE,
        CHAMFER_LINE,
        CHAMFER_ROUNDING,
        CHAMFER_ARC,
        CHAMFER_ARC_POINT,
        CHAMFER_SQUARE,
        CHAMFER_SQUARE_PARALLEL,
        CHAMFER_LINE_AND_ARC
    }

    internal static class ChamferTypeEnum_
    {
        public static dynamic GetTSObject(ChamferTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Chamfer.ChamferTypeEnum").GetType();

            switch (dynEnum)
            {
                case ChamferTypeEnum.CHAMFER_NONE:
                    return System.Enum.Parse(tsType, "CHAMFER_NONE");
                case ChamferTypeEnum.CHAMFER_LINE:
                    return System.Enum.Parse(tsType, "CHAMFER_LINE");
                case ChamferTypeEnum.CHAMFER_ROUNDING:
                    return System.Enum.Parse(tsType, "CHAMFER_ROUNDING");
                case ChamferTypeEnum.CHAMFER_ARC:
                    return System.Enum.Parse(tsType, "CHAMFER_ARC");
                case ChamferTypeEnum.CHAMFER_ARC_POINT:
                    return System.Enum.Parse(tsType, "CHAMFER_ARC_POINT");
                case ChamferTypeEnum.CHAMFER_SQUARE:
                    return System.Enum.Parse(tsType, "CHAMFER_SQUARE");
                case ChamferTypeEnum.CHAMFER_SQUARE_PARALLEL:
                    return System.Enum.Parse(tsType, "CHAMFER_SQUARE_PARALLEL");
                case ChamferTypeEnum.CHAMFER_LINE_AND_ARC:
                    return System.Enum.Parse(tsType, "CHAMFER_LINE_AND_ARC");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static ChamferTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("CHAMFER_NONE", System.StringComparison.InvariantCulture))
                return ChamferTypeEnum.CHAMFER_NONE;
            else if (tsEnumValue.Equals("CHAMFER_LINE", System.StringComparison.InvariantCulture))
                return ChamferTypeEnum.CHAMFER_LINE;
            else if (tsEnumValue.Equals("CHAMFER_ROUNDING", System.StringComparison.InvariantCulture))
                return ChamferTypeEnum.CHAMFER_ROUNDING;
            else if (tsEnumValue.Equals("CHAMFER_ARC", System.StringComparison.InvariantCulture))
                return ChamferTypeEnum.CHAMFER_ARC;
            else if (tsEnumValue.Equals("CHAMFER_ARC_POINT", System.StringComparison.InvariantCulture))
                return ChamferTypeEnum.CHAMFER_ARC_POINT;
            else if (tsEnumValue.Equals("CHAMFER_SQUARE", System.StringComparison.InvariantCulture))
                return ChamferTypeEnum.CHAMFER_SQUARE;
            else if (tsEnumValue.Equals("CHAMFER_SQUARE_PARALLEL", System.StringComparison.InvariantCulture))
                return ChamferTypeEnum.CHAMFER_SQUARE_PARALLEL;
            else if (tsEnumValue.Equals("CHAMFER_LINE_AND_ARC", System.StringComparison.InvariantCulture))
                return ChamferTypeEnum.CHAMFER_LINE_AND_ARC;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class Chamfer_
{
    public static dynamic GetTSObject(Chamfer dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Chamfer FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Chamfer)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

