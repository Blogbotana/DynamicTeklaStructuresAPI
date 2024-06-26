using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public enum ControlObjectColorEnum
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

    internal static class ControlObjectColorEnum_
    {
        public static dynamic GetTSObject(ControlObjectColorEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ControlObjectColorEnum").GetType();

            switch (dynEnum)
            {
			case ControlObjectColorEnum.BLACK:
				return System.Enum.Parse(tsType, "BLACK");
			case ControlObjectColorEnum.WHITE:
				return System.Enum.Parse(tsType, "WHITE");
			case ControlObjectColorEnum.RED:
				return System.Enum.Parse(tsType, "RED");
			case ControlObjectColorEnum.GREEN:
				return System.Enum.Parse(tsType, "GREEN");
			case ControlObjectColorEnum.BLUE:
				return System.Enum.Parse(tsType, "BLUE");
			case ControlObjectColorEnum.CYAN:
				return System.Enum.Parse(tsType, "CYAN");
			case ControlObjectColorEnum.YELLOW:
				return System.Enum.Parse(tsType, "YELLOW");
			case ControlObjectColorEnum.MAGENTA:
				return System.Enum.Parse(tsType, "MAGENTA");
			case ControlObjectColorEnum.YELLOW_RED:
				return System.Enum.Parse(tsType, "YELLOW_RED");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static ControlObjectColorEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
		if (tsEnumValue.Equals("BLACK", System.StringComparison.InvariantCulture))
			return ControlObjectColorEnum.BLACK;
		else if (tsEnumValue.Equals("WHITE", System.StringComparison.InvariantCulture))
			return ControlObjectColorEnum.WHITE;
		else if (tsEnumValue.Equals("RED", System.StringComparison.InvariantCulture))
			return ControlObjectColorEnum.RED;
		else if (tsEnumValue.Equals("GREEN", System.StringComparison.InvariantCulture))
			return ControlObjectColorEnum.GREEN;
		else if (tsEnumValue.Equals("BLUE", System.StringComparison.InvariantCulture))
			return ControlObjectColorEnum.BLUE;
		else if (tsEnumValue.Equals("CYAN", System.StringComparison.InvariantCulture))
			return ControlObjectColorEnum.CYAN;
		else if (tsEnumValue.Equals("YELLOW", System.StringComparison.InvariantCulture))
			return ControlObjectColorEnum.YELLOW;
		else if (tsEnumValue.Equals("MAGENTA", System.StringComparison.InvariantCulture))
			return ControlObjectColorEnum.MAGENTA;
		else if (tsEnumValue.Equals("YELLOW_RED", System.StringComparison.InvariantCulture))
			return ControlObjectColorEnum.YELLOW_RED;

            else 
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
            
        }
    }
    
