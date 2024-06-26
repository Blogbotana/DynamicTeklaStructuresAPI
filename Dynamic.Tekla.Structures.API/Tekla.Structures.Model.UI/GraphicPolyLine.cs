using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model.UI;


public  class GraphicPolyLine 
{


    public Dynamic.Tekla.Structures.Geometry3d.PolyLine PolyLine
    {
        get
        {
            try
            {
            var value = teklaObject.PolyLine;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.PolyLine_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.PolyLine) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PolyLine), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.PolyLine_.GetTSObject(value);
            teklaObject.PolyLine = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PolyLine), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Model.UI.Color Color
    {
        get
        {
            try
            {
            var value = teklaObject.Color;
            var value_ = Dynamic.Tekla.Structures.Model.UI.Color_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Model.UI.Color) value_;
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
            var value_ = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(value);
            teklaObject.Color = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Color), ex); 
            }
        }
    }

    public System.Int32 Width
    {
        get
        {
            try
            {
            return teklaObject.Width;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Width), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.Width = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Width), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine.LineType Type
    {
        get
        {
            try
            {
            var value = teklaObject.Type;
            var value_ = Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine.LineType_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine.LineType) value_;
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
            var value_ = Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine.LineType_.GetTSObject(value);
            teklaObject.Type = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex); 
            }
        }
    }
    

    internal dynamic teklaObject;

		public GraphicPolyLine()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.GraphicPolyLine");
		}
		
		public GraphicPolyLine(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public GraphicPolyLine(Dynamic.Tekla.Structures.Model.UI.Color color, System.Int32 width, Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine.LineType type)
		{
			var args = new object[3];
			args[0] = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color);
			args[1] = width;
			args[2] = Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine.LineType_.GetTSObject(type);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.GraphicPolyLine", args);
		}
		public GraphicPolyLine(Dynamic.Tekla.Structures.Geometry3d.PolyLine polyLine, Dynamic.Tekla.Structures.Model.UI.Color color, System.Int32 width, Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine.LineType type)
		{
			var args = new object[4];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.PolyLine_.GetTSObject(polyLine);
			args[1] = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color);
			args[2] = width;
			args[3] = Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine.LineType_.GetTSObject(type);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.GraphicPolyLine", args);
		}




public enum LineType
{
			Solid,
			Dashed1,
			Dashed2,
			DashedAndDotted,
			Dotted        
}

internal static class LineType_
{
    public static dynamic GetTSObject(LineType dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.GraphicPolyLine.LineType").GetType();

        switch (dynEnum)
        {
				case LineType.Solid:
					return System.Enum.Parse(tsType, "Solid");
				case LineType.Dashed1:
					return System.Enum.Parse(tsType, "Dashed1");
				case LineType.Dashed2:
					return System.Enum.Parse(tsType, "Dashed2");
				case LineType.DashedAndDotted:
					return System.Enum.Parse(tsType, "DashedAndDotted");
				case LineType.Dotted:
					return System.Enum.Parse(tsType, "Dotted");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static LineType FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
        
			if (tsEnumValue.Equals("Solid", System.StringComparison.InvariantCulture))
				return LineType.Solid;
			else if (tsEnumValue.Equals("Dashed1", System.StringComparison.InvariantCulture))
				return LineType.Dashed1;
			else if (tsEnumValue.Equals("Dashed2", System.StringComparison.InvariantCulture))
				return LineType.Dashed2;
			else if (tsEnumValue.Equals("DashedAndDotted", System.StringComparison.InvariantCulture))
				return LineType.DashedAndDotted;
			else if (tsEnumValue.Equals("Dotted", System.StringComparison.InvariantCulture))
				return LineType.Dotted;

        else 
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
        
    }
}



}

internal static class GraphicPolyLine_
{
    public static dynamic GetTSObject(GraphicPolyLine dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static GraphicPolyLine FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Model.UI.GraphicPolyLine)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class GraphicPolyLineArray_
{
    public static dynamic GetTSObject(GraphicPolyLine[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(GraphicPolyLine_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static GraphicPolyLine[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<GraphicPolyLine>();
        foreach(var tsItem in tsArray)
        {
            list.Add(GraphicPolyLine_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

