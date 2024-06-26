using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class ControlCircle  : ModelObject
{


    public double Extension
    {
        get
        {
            try
            {
            return teklaObject.Extension;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Extension), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.Extension = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Extension), ex); 
            }
        }
    }

    public ControlCircle.ControlCircleColorEnum Color
    {
        get
        {
            try
            {
            var value = teklaObject.Color;
            var value_ = ControlCircle.ControlCircleColorEnum_.FromTSObject(value);
            return (ControlCircle.ControlCircleColorEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Color), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = ControlCircle.ControlCircleColorEnum_.GetTSObject(value);
            teklaObject.Color = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Color), ex); 
            }
        }
    }

    public ControlObjectLineType LineType
    {
        get
        {
            try
            {
            var value = teklaObject.LineType;
            var value_ = ControlObjectLineType_.FromTSObject(value);
            return (ControlObjectLineType) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LineType), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = ControlObjectLineType_.GetTSObject(value);
            teklaObject.LineType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LineType), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point Point1
    {
        get
        {
            try
            {
            var value = teklaObject.Point1;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Point1), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
            teklaObject.Point1 = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Point1), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point Point2
    {
        get
        {
            try
            {
            var value = teklaObject.Point2;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Point2), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
            teklaObject.Point2 = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Point2), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point Point3
    {
        get
        {
            try
            {
            var value = teklaObject.Point3;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Point3), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
            teklaObject.Point3 = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Point3), ex); 
            }
        }
    }
    

    

		public ControlCircle()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlCircle");
		}
		
		public ControlCircle(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public ControlCircle(Dynamic.Tekla.Structures.Geometry3d.Point point1, Dynamic.Tekla.Structures.Geometry3d.Point point2, Dynamic.Tekla.Structures.Geometry3d.Point point3)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point1);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point2);
			args[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(point3);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlCircle", args);
		}




public enum ControlCircleColorEnum
{
			BLACK,
			WHITE,
			RED,
			GREEN,
			BLUE,
			CYAN,
			YELLOW,
			MAGENTA,
			YELLOW_RED        
}

internal static class ControlCircleColorEnum_
{
    public static dynamic GetTSObject(ControlCircleColorEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ControlCircle.ControlCircleColorEnum").GetType();

        switch (dynEnum)
        {
				case ControlCircleColorEnum.BLACK:
					return System.Enum.Parse(tsType, "BLACK");
				case ControlCircleColorEnum.WHITE:
					return System.Enum.Parse(tsType, "WHITE");
				case ControlCircleColorEnum.RED:
					return System.Enum.Parse(tsType, "RED");
				case ControlCircleColorEnum.GREEN:
					return System.Enum.Parse(tsType, "GREEN");
				case ControlCircleColorEnum.BLUE:
					return System.Enum.Parse(tsType, "BLUE");
				case ControlCircleColorEnum.CYAN:
					return System.Enum.Parse(tsType, "CYAN");
				case ControlCircleColorEnum.YELLOW:
					return System.Enum.Parse(tsType, "YELLOW");
				case ControlCircleColorEnum.MAGENTA:
					return System.Enum.Parse(tsType, "MAGENTA");
				case ControlCircleColorEnum.YELLOW_RED:
					return System.Enum.Parse(tsType, "YELLOW_RED");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static ControlCircleColorEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
        
			if (tsEnumValue.Equals("BLACK", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.BLACK;
			else if (tsEnumValue.Equals("WHITE", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.WHITE;
			else if (tsEnumValue.Equals("RED", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.RED;
			else if (tsEnumValue.Equals("GREEN", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.GREEN;
			else if (tsEnumValue.Equals("BLUE", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.BLUE;
			else if (tsEnumValue.Equals("CYAN", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.CYAN;
			else if (tsEnumValue.Equals("YELLOW", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.YELLOW;
			else if (tsEnumValue.Equals("MAGENTA", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.MAGENTA;
			else if (tsEnumValue.Equals("YELLOW_RED", System.StringComparison.InvariantCulture))
				return ControlCircleColorEnum.YELLOW_RED;

        else 
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
        
    }
}



}

internal static class ControlCircle_
{
    public static dynamic GetTSObject(ControlCircle dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ControlCircle FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ControlCircle)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ControlCircleArray_
{
    public static dynamic GetTSObject(ControlCircle[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(ControlCircle_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static ControlCircle[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<ControlCircle>();
        foreach(var tsItem in tsArray)
        {
            list.Add(ControlCircle_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

