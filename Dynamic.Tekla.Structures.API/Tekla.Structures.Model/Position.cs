using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public class Position
{


    public double PlaneOffset
    {
        get
        {
            try
            {
                return teklaObject.PlaneOffset;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PlaneOffset), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PlaneOffset = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PlaneOffset), ex);
            }
        }
    }

    public double DepthOffset
    {
        get
        {
            try
            {
                return teklaObject.DepthOffset;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DepthOffset), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.DepthOffset = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DepthOffset), ex);
            }
        }
    }

    public double RotationOffset
    {
        get
        {
            try
            {
                return teklaObject.RotationOffset;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RotationOffset), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.RotationOffset = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RotationOffset), ex);
            }
        }
    }

    public Position.PlaneEnum Plane
    {
        get
        {
            try
            {
                var value = teklaObject.Plane;
                var value_ = Position.PlaneEnum_.FromTSObject(value);
                return (Position.PlaneEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Plane), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Position.PlaneEnum_.GetTSObject(value);
                teklaObject.Plane = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Plane), ex);
            }
        }
    }

    public Position.DepthEnum Depth
    {
        get
        {
            try
            {
                var value = teklaObject.Depth;
                var value_ = Position.DepthEnum_.FromTSObject(value);
                return (Position.DepthEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Depth), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Position.DepthEnum_.GetTSObject(value);
                teklaObject.Depth = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Depth), ex);
            }
        }
    }

    public Position.RotationEnum Rotation
    {
        get
        {
            try
            {
                var value = teklaObject.Rotation;
                var value_ = Position.RotationEnum_.FromTSObject(value);
                return (Position.RotationEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Rotation), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Position.RotationEnum_.GetTSObject(value);
                teklaObject.Rotation = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Rotation), ex);
            }
        }
    }


    internal dynamic teklaObject;

    public Position()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Position");
    }

    public Position(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }




    public enum PlaneEnum
    {
        MIDDLE,
        LEFT,
        RIGHT
    }

    internal static class PlaneEnum_
    {
        public static dynamic GetTSObject(PlaneEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Position.PlaneEnum").GetType();

            switch (dynEnum)
            {
                case PlaneEnum.MIDDLE:
                    return System.Enum.Parse(tsType, "MIDDLE");
                case PlaneEnum.LEFT:
                    return System.Enum.Parse(tsType, "LEFT");
                case PlaneEnum.RIGHT:
                    return System.Enum.Parse(tsType, "RIGHT");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static PlaneEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("MIDDLE", System.StringComparison.InvariantCulture))
                return PlaneEnum.MIDDLE;
            else if (tsEnumValue.Equals("LEFT", System.StringComparison.InvariantCulture))
                return PlaneEnum.LEFT;
            else if (tsEnumValue.Equals("RIGHT", System.StringComparison.InvariantCulture))
                return PlaneEnum.RIGHT;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum DepthEnum
    {
        MIDDLE,
        FRONT,
        BEHIND
    }

    internal static class DepthEnum_
    {
        public static dynamic GetTSObject(DepthEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Position.DepthEnum").GetType();

            switch (dynEnum)
            {
                case DepthEnum.MIDDLE:
                    return System.Enum.Parse(tsType, "MIDDLE");
                case DepthEnum.FRONT:
                    return System.Enum.Parse(tsType, "FRONT");
                case DepthEnum.BEHIND:
                    return System.Enum.Parse(tsType, "BEHIND");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static DepthEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("MIDDLE", System.StringComparison.InvariantCulture))
                return DepthEnum.MIDDLE;
            else if (tsEnumValue.Equals("FRONT", System.StringComparison.InvariantCulture))
                return DepthEnum.FRONT;
            else if (tsEnumValue.Equals("BEHIND", System.StringComparison.InvariantCulture))
                return DepthEnum.BEHIND;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum RotationEnum
    {
        FRONT,
        TOP,
        BACK,
        BELOW
    }

    internal static class RotationEnum_
    {
        public static dynamic GetTSObject(RotationEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Position.RotationEnum").GetType();

            switch (dynEnum)
            {
                case RotationEnum.FRONT:
                    return System.Enum.Parse(tsType, "FRONT");
                case RotationEnum.TOP:
                    return System.Enum.Parse(tsType, "TOP");
                case RotationEnum.BACK:
                    return System.Enum.Parse(tsType, "BACK");
                case RotationEnum.BELOW:
                    return System.Enum.Parse(tsType, "BELOW");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static RotationEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("FRONT", System.StringComparison.InvariantCulture))
                return RotationEnum.FRONT;
            else if (tsEnumValue.Equals("TOP", System.StringComparison.InvariantCulture))
                return RotationEnum.TOP;
            else if (tsEnumValue.Equals("BACK", System.StringComparison.InvariantCulture))
                return RotationEnum.BACK;
            else if (tsEnumValue.Equals("BELOW", System.StringComparison.InvariantCulture))
                return RotationEnum.BELOW;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class Position_
{
    public static dynamic GetTSObject(Position dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Position FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Position)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class PositionArray_
{
    public static dynamic GetTSObject(Position[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(Position_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static Position[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<Position>();
        foreach (var tsItem in tsArray)
        {
            list.Add(Position_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}




