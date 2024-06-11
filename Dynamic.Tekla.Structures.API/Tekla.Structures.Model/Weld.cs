using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;
public class Weld : BaseWeld
{


    public Weld.WeldPositionEnum Position
    {
        get
        {
            try
            {
                var value = teklaObject.Position;
                var value_ = Weld.WeldPositionEnum_.FromTSObject(value);
                return (Weld.WeldPositionEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Weld.WeldPositionEnum_.GetTSObject(value);
                teklaObject.Position = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Vector Direction
    {
        get
        {
            try
            {
                var value = teklaObject.Direction;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Direction), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
                teklaObject.Direction = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Direction), ex);
            }
        }
    }




    public Weld()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Weld");
    }

    public Weld(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }


    public bool GetLogicalWeld(ref LogicalWeld LogicalWeld_)
    {
        var LogicalWeld = Dynamic.Tekla.Structures.Model.LogicalWeld_.GetTSObject(LogicalWeld_);
        try
        {
            var result = (bool)teklaObject.GetLogicalWeld(ref LogicalWeld);
            LogicalWeld_ = Dynamic.Tekla.Structures.Model.LogicalWeld_.FromTSObject(LogicalWeld);
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetLogicalWeld), ex);
        }
    }

    public enum WeldPositionEnum
    {
        WELD_POSITION_PLUS_X,
        WELD_POSITION_MINUS_X,
        WELD_POSITION_PLUS_Y,
        WELD_POSITION_MINUS_Y,
        WELD_POSITION_PLUS_Z,
        WELD_POSITION_MINUS_Z
    }

    internal static class WeldPositionEnum_
    {
        public static dynamic GetTSObject(WeldPositionEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Weld.WeldPositionEnum").GetType();

            switch (dynEnum)
            {
                case WeldPositionEnum.WELD_POSITION_PLUS_X:
                    return System.Enum.Parse(tsType, "WELD_POSITION_PLUS_X");
                case WeldPositionEnum.WELD_POSITION_MINUS_X:
                    return System.Enum.Parse(tsType, "WELD_POSITION_MINUS_X");
                case WeldPositionEnum.WELD_POSITION_PLUS_Y:
                    return System.Enum.Parse(tsType, "WELD_POSITION_PLUS_Y");
                case WeldPositionEnum.WELD_POSITION_MINUS_Y:
                    return System.Enum.Parse(tsType, "WELD_POSITION_MINUS_Y");
                case WeldPositionEnum.WELD_POSITION_PLUS_Z:
                    return System.Enum.Parse(tsType, "WELD_POSITION_PLUS_Z");
                case WeldPositionEnum.WELD_POSITION_MINUS_Z:
                    return System.Enum.Parse(tsType, "WELD_POSITION_MINUS_Z");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static WeldPositionEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("WELD_POSITION_PLUS_X", System.StringComparison.InvariantCulture))
                return WeldPositionEnum.WELD_POSITION_PLUS_X;
            else if (tsEnumValue.Equals("WELD_POSITION_MINUS_X", System.StringComparison.InvariantCulture))
                return WeldPositionEnum.WELD_POSITION_MINUS_X;
            else if (tsEnumValue.Equals("WELD_POSITION_PLUS_Y", System.StringComparison.InvariantCulture))
                return WeldPositionEnum.WELD_POSITION_PLUS_Y;
            else if (tsEnumValue.Equals("WELD_POSITION_MINUS_Y", System.StringComparison.InvariantCulture))
                return WeldPositionEnum.WELD_POSITION_MINUS_Y;
            else if (tsEnumValue.Equals("WELD_POSITION_PLUS_Z", System.StringComparison.InvariantCulture))
                return WeldPositionEnum.WELD_POSITION_PLUS_Z;
            else if (tsEnumValue.Equals("WELD_POSITION_MINUS_Z", System.StringComparison.InvariantCulture))
                return WeldPositionEnum.WELD_POSITION_MINUS_Z;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class Weld_
{
    public static dynamic GetTSObject(Weld dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Weld FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Weld)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class WeldArray_
{
    public static dynamic GetTSObject(Weld[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(Weld_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static Weld[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<Weld>();
        foreach (var tsItem in tsArray)
        {
            list.Add(Weld_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}




