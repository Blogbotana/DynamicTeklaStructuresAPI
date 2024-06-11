using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;
public sealed class BentPlate : Part
{

    public ConnectiveGeometry Geometry
    {
        get
        {
            try
            {
                var value = teklaObject.Geometry;
                var value_ = ConnectiveGeometry_.FromTSObject(value);
                return (ConnectiveGeometry)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Geometry), ex);
            }
        }
        set
        {
            try
            {
                var value_ = ConnectiveGeometry_.GetTSObject(value);
                teklaObject.Geometry = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Geometry), ex);
            }
        }
    }

    public double Thickness
    {
        get
        {
            try
            {
                return teklaObject.Thickness;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Thickness), ex);
            }
        }

    }




    public BentPlate()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BentPlate");
    }
    
    public BentPlate(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }




    public enum BendShape
    {
        Cylindrical,
        Conical
    }

    internal static class BendShape_
    {
        public static dynamic GetTSObject(BendShape dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BentPlate.BendShape").GetType();

            switch (dynEnum)
            {
                case BendShape.Cylindrical:
                    return System.Enum.Parse(tsType, "Cylindrical");
                case BendShape.Conical:
                    return System.Enum.Parse(tsType, "Conical");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static BendShape FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("Cylindrical", System.StringComparison.InvariantCulture))
                return BendShape.Cylindrical;
            else if (tsEnumValue.Equals("Conical", System.StringComparison.InvariantCulture))
                return BendShape.Conical;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class BentPlate_
{
    public static dynamic GetTSObject(BentPlate dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static BentPlate FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (BentPlate)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}


