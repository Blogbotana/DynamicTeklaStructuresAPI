using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;
public sealed class Solid
{


    public Dynamic.Tekla.Structures.Geometry3d.Point MinimumPoint
    {
        get
        {
            try
            {
                var value = teklaObject.MinimumPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MinimumPoint), ex);
            }
        }

    }

    public Dynamic.Tekla.Structures.Geometry3d.Point MaximumPoint
    {
        get
        {
            try
            {
                var value = teklaObject.MaximumPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MaximumPoint), ex);
            }
        }

    }


    internal dynamic teklaObject;

    internal Solid() { }

    public Solid(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }


    public System.Collections.ArrayList Intersect(
        Dynamic.Tekla.Structures.Geometry3d.LineSegment line_)
    {
        var line = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(line_);
        try
        {
            var result = teklaObject.Intersect(line);

            var _result = ArrayListConverter.FromTSObjects(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Intersect), ex);
        }
    }



    public System.Collections.ArrayList Intersect(
        Dynamic.Tekla.Structures.Geometry3d.Point point1_,
        Dynamic.Tekla.Structures.Geometry3d.Point point2_)
    {
        var point1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point1_);
        var point2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point2_);
        try
        {
            var result = teklaObject.Intersect(point1, point2);

            var _result = ArrayListConverter.FromTSObjects(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Intersect), ex);
        }
    }



    public System.Collections.ArrayList Intersect(
        Dynamic.Tekla.Structures.Geometry3d.Point point1_,
        Dynamic.Tekla.Structures.Geometry3d.Point point2_,
        Dynamic.Tekla.Structures.Geometry3d.Point point3_)
    {
        var point1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point1_);
        var point2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point2_);
        var point3 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point3_);
        try
        {
            var result = teklaObject.Intersect(point1, point2, point3);

            var _result = ArrayListConverter.FromTSObjects(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Intersect), ex);
        }
    }



    public Dynamic.Tekla.Structures.Solid.FaceEnumerator GetFaceEnumerator()
    {

        try
        {
            var result = teklaObject.GetFaceEnumerator();

            var _result = Dynamic.Tekla.Structures.Solid.FaceEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetFaceEnumerator), ex);
        }
    }



    public Dynamic.Tekla.Structures.Solid.EdgeEnumerator GetEdgeEnumerator()
    {

        try
        {
            var result = teklaObject.GetEdgeEnumerator();

            var _result = Dynamic.Tekla.Structures.Solid.EdgeEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetEdgeEnumerator), ex);
        }
    }



    public Dynamic.Tekla.Structures.Solid.ShellEnumerator GetCutPart(
        Solid CuttingPart_)
    {
        var CuttingPart = Solid_.GetTSObject(CuttingPart_);
        try
        {
            var result = teklaObject.GetCutPart(CuttingPart);

            var _result = Dynamic.Tekla.Structures.Solid.ShellEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetCutPart), ex);
        }
    }



    public bool IsValid()
    {

        try
        {
            var result = (bool)teklaObject.IsValid();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsValid), ex);
        }
    }





    public enum SolidCreationTypeEnum
    {
        RAW,
        FITTED,
        NORMAL,
        HIGH_ACCURACY,
        PLANECUTTED,
        NORMAL_WITHOUT_EDGECHAMFERS,
        NORMAL_WITHOUT_WELDPREPS
    }

    internal static class SolidCreationTypeEnum_
    {
        public static dynamic GetTSObject(SolidCreationTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Solid.SolidCreationTypeEnum").GetType();

            switch (dynEnum)
            {
                case SolidCreationTypeEnum.RAW:
                    return System.Enum.Parse(tsType, "RAW");
                case SolidCreationTypeEnum.FITTED:
                    return System.Enum.Parse(tsType, "FITTED");
                case SolidCreationTypeEnum.NORMAL:
                    return System.Enum.Parse(tsType, "NORMAL");
                case SolidCreationTypeEnum.HIGH_ACCURACY:
                    return System.Enum.Parse(tsType, "HIGH_ACCURACY");
                case SolidCreationTypeEnum.PLANECUTTED:
                    return System.Enum.Parse(tsType, "PLANECUTTED");
                case SolidCreationTypeEnum.NORMAL_WITHOUT_EDGECHAMFERS:
                    return System.Enum.Parse(tsType, "NORMAL_WITHOUT_EDGECHAMFERS");
                case SolidCreationTypeEnum.NORMAL_WITHOUT_WELDPREPS:
                    return System.Enum.Parse(tsType, "NORMAL_WITHOUT_WELDPREPS");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static SolidCreationTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("RAW", System.StringComparison.InvariantCulture))
                return SolidCreationTypeEnum.RAW;
            else if (tsEnumValue.Equals("FITTED", System.StringComparison.InvariantCulture))
                return SolidCreationTypeEnum.FITTED;
            else if (tsEnumValue.Equals("NORMAL", System.StringComparison.InvariantCulture))
                return SolidCreationTypeEnum.NORMAL;
            else if (tsEnumValue.Equals("HIGH_ACCURACY", System.StringComparison.InvariantCulture))
                return SolidCreationTypeEnum.HIGH_ACCURACY;
            else if (tsEnumValue.Equals("PLANECUTTED", System.StringComparison.InvariantCulture))
                return SolidCreationTypeEnum.PLANECUTTED;
            else if (tsEnumValue.Equals("NORMAL_WITHOUT_EDGECHAMFERS", System.StringComparison.InvariantCulture))
                return SolidCreationTypeEnum.NORMAL_WITHOUT_EDGECHAMFERS;
            else if (tsEnumValue.Equals("NORMAL_WITHOUT_WELDPREPS", System.StringComparison.InvariantCulture))
                return SolidCreationTypeEnum.NORMAL_WITHOUT_WELDPREPS;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class Solid_
{
    public static dynamic GetTSObject(Solid dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Solid FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Solid)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class SolidArray_
{
    public static dynamic GetTSObject(Solid[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(Solid_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static Solid[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<Solid>();
        foreach (var tsItem in tsArray)
        {
            list.Add(Solid_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}




