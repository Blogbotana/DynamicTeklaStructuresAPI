using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public enum ControlObjectLineType
{
			SolidLine,
			DashedLine,
			SlashedLine,
			DashDot,
			DottedLine        
}

internal static class ControlObjectLineType_
{
    public static dynamic GetTSObject(ControlObjectLineType dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.ControlObjectLineType").GetType();

        switch (dynEnum)
        {
				case ControlObjectLineType.SolidLine:
					return System.Enum.Parse(tsType, "SolidLine");
				case ControlObjectLineType.DashedLine:
					return System.Enum.Parse(tsType, "DashedLine");
				case ControlObjectLineType.SlashedLine:
					return System.Enum.Parse(tsType, "SlashedLine");
				case ControlObjectLineType.DashDot:
					return System.Enum.Parse(tsType, "DashDot");
				case ControlObjectLineType.DottedLine:
					return System.Enum.Parse(tsType, "DottedLine");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static ControlObjectLineType FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
        
			if (tsEnumValue.Equals("SolidLine", System.StringComparison.InvariantCulture))
				return ControlObjectLineType.SolidLine;
			else if (tsEnumValue.Equals("DashedLine", System.StringComparison.InvariantCulture))
				return ControlObjectLineType.DashedLine;
			else if (tsEnumValue.Equals("SlashedLine", System.StringComparison.InvariantCulture))
				return ControlObjectLineType.SlashedLine;
			else if (tsEnumValue.Equals("DashDot", System.StringComparison.InvariantCulture))
				return ControlObjectLineType.DashDot;
			else if (tsEnumValue.Equals("DottedLine", System.StringComparison.InvariantCulture))
				return ControlObjectLineType.DottedLine;

        else 
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
        
    }
}

