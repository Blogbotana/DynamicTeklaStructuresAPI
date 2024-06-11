using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;


public class ContourPlate : Part
{


    public ContourPlate.ContourPlateTypeEnum Type
    {
        get
        {
            try
            {
                var value = teklaObject.Type;
                var value_ = ContourPlate.ContourPlateTypeEnum_.FromTSObject(value);
                return (ContourPlate.ContourPlateTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex);
            }
        }

    }

    public Contour Contour
    {
        get
        {
            try
            {
                var value = teklaObject.Contour;
                var value_ = Contour_.FromTSObject(value);
                return (Contour)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Contour), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Contour_.GetTSObject(value);
                teklaObject.Contour = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Contour), ex);
            }
        }
    }




    public ContourPlate()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ContourPlate");
    }

    public ContourPlate(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }


    public bool AddContourPoint(
            ContourPoint contourPoint_)
    {
        var contourPoint = ContourPoint_.GetTSObject(contourPoint_);
        try
        {
            var result = (bool)teklaObject.AddContourPoint(contourPoint);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddContourPoint), ex);
        }
    }



    public Dynamic.Tekla.Structures.Geometry3d.Polycurve GetContourPolycurve()
    {

        try
        {
            var result = teklaObject.GetContourPolycurve();

            var _result = Dynamic.Tekla.Structures.Geometry3d.Polycurve_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetContourPolycurve), ex);
        }
    }





    public enum ContourPlateTypeEnum
    {
        UNKNOWN,
        PLATE,
        SLAB
    }

    internal static class ContourPlateTypeEnum_
    {
        public static dynamic GetTSObject(ContourPlateTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ContourPlate.ContourPlateTypeEnum").GetType();

            switch (dynEnum)
            {
                case ContourPlateTypeEnum.UNKNOWN:
                    return System.Enum.Parse(tsType, "UNKNOWN");
                case ContourPlateTypeEnum.PLATE:
                    return System.Enum.Parse(tsType, "PLATE");
                case ContourPlateTypeEnum.SLAB:
                    return System.Enum.Parse(tsType, "SLAB");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static ContourPlateTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("UNKNOWN", System.StringComparison.InvariantCulture))
                return ContourPlateTypeEnum.UNKNOWN;
            else if (tsEnumValue.Equals("PLATE", System.StringComparison.InvariantCulture))
                return ContourPlateTypeEnum.PLATE;
            else if (tsEnumValue.Equals("SLAB", System.StringComparison.InvariantCulture))
                return ContourPlateTypeEnum.SLAB;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class ContourPlate_
{
    public static dynamic GetTSObject(ContourPlate dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ContourPlate FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ContourPlate)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ContourPlateArray_
{
    public static dynamic GetTSObject(ContourPlate[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(ContourPlate_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static ContourPlate[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<ContourPlate>();
        foreach (var tsItem in tsArray)
        {
            list.Add(ContourPlate_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

