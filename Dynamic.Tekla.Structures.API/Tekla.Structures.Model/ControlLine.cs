using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class ControlLine  : ModelObject
{


    public Dynamic.Tekla.Structures.Geometry3d.LineSegment Line
    {
        get
        {
            try
            {
            var value = teklaObject.Line;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.LineSegment) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Line), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(value);
            teklaObject.Line = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Line), ex); 
            }
        }
    }

    public bool IsMagnetic
    {
        get
        {
            try
            {
            return teklaObject.IsMagnetic;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsMagnetic), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.IsMagnetic = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsMagnetic), ex); 
            }
        }
    }

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

    public ControlLine.ControlLineColorEnum Color
    {
        get
        {
            try
            {
            var value = teklaObject.Color;
            var value_ = ControlLine.ControlLineColorEnum_.FromTSObject(value);
            return (ControlLine.ControlLineColorEnum) value_;
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
            var value_ = ControlLine.ControlLineColorEnum_.GetTSObject(value);
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
    

    

		public ControlLine()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlLine");
		}
		
		public ControlLine(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public ControlLine(Dynamic.Tekla.Structures.Geometry3d.LineSegment Line, bool IsMagnetic)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.LineSegment_.GetTSObject(Line);
			args[1] = IsMagnetic;
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ControlLine", args);
		}




public enum ControlLineColorEnum
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

internal static class ControlLineColorEnum_
{
    public static dynamic GetTSObject(ControlLineColorEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ControlLine.ControlLineColorEnum").GetType();

        switch (dynEnum)
        {
				case ControlLineColorEnum.BLACK:
					return System.Enum.Parse(tsType, "BLACK");
				case ControlLineColorEnum.WHITE:
					return System.Enum.Parse(tsType, "WHITE");
				case ControlLineColorEnum.RED:
					return System.Enum.Parse(tsType, "RED");
				case ControlLineColorEnum.GREEN:
					return System.Enum.Parse(tsType, "GREEN");
				case ControlLineColorEnum.BLUE:
					return System.Enum.Parse(tsType, "BLUE");
				case ControlLineColorEnum.CYAN:
					return System.Enum.Parse(tsType, "CYAN");
				case ControlLineColorEnum.YELLOW:
					return System.Enum.Parse(tsType, "YELLOW");
				case ControlLineColorEnum.MAGENTA:
					return System.Enum.Parse(tsType, "MAGENTA");
				case ControlLineColorEnum.YELLOW_RED:
					return System.Enum.Parse(tsType, "YELLOW_RED");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static ControlLineColorEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
        
			if (tsEnumValue.Equals("BLACK", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.BLACK;
			else if (tsEnumValue.Equals("WHITE", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.WHITE;
			else if (tsEnumValue.Equals("RED", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.RED;
			else if (tsEnumValue.Equals("GREEN", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.GREEN;
			else if (tsEnumValue.Equals("BLUE", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.BLUE;
			else if (tsEnumValue.Equals("CYAN", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.CYAN;
			else if (tsEnumValue.Equals("YELLOW", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.YELLOW;
			else if (tsEnumValue.Equals("MAGENTA", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.MAGENTA;
			else if (tsEnumValue.Equals("YELLOW_RED", System.StringComparison.InvariantCulture))
				return ControlLineColorEnum.YELLOW_RED;

        else 
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
        
    }
}



}

internal static class ControlLine_
{
    public static dynamic GetTSObject(ControlLine dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ControlLine FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ControlLine)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ControlLineArray_
{
    public static dynamic GetTSObject(ControlLine[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(ControlLine_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static ControlLine[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<ControlLine>();
        foreach(var tsItem in tsArray)
        {
            list.Add(ControlLine_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

