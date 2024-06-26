using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class LoadLine  : Load
{


    public Dynamic.Tekla.Structures.Geometry3d.Point Position1
    {
        get
        {
            try
            {
            var value = teklaObject.Position1;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position1), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
            teklaObject.Position1 = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position1), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point Position2
    {
        get
        {
            try
            {
            var value = teklaObject.Position2;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position2), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
            teklaObject.Position2 = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position2), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Vector P1
    {
        get
        {
            try
            {
            var value = teklaObject.P1;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(P1), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
            teklaObject.P1 = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(P1), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Vector P2
    {
        get
        {
            try
            {
            var value = teklaObject.P2;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Vector) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(P2), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
            teklaObject.P2 = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(P2), ex); 
            }
        }
    }

    public double Torsion1
    {
        get
        {
            try
            {
            return teklaObject.Torsion1;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Torsion1), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.Torsion1 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Torsion1), ex); 
            }
        }
    }

    public double Torsion2
    {
        get
        {
            try
            {
            return teklaObject.Torsion2;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Torsion2), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.Torsion2 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Torsion2), ex); 
            }
        }
    }

    public LoadLine.LineLoadFormEnum LoadForm
    {
        get
        {
            try
            {
            var value = teklaObject.LoadForm;
            var value_ = LoadLine.LineLoadFormEnum_.FromTSObject(value);
            return (LoadLine.LineLoadFormEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LoadForm), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = LoadLine.LineLoadFormEnum_.GetTSObject(value);
            teklaObject.LoadForm = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LoadForm), ex); 
            }
        }
    }

    public double DistanceA
    {
        get
        {
            try
            {
            return teklaObject.DistanceA;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DistanceA), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.DistanceA = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DistanceA), ex); 
            }
        }
    }

    public double DistanceB
    {
        get
        {
            try
            {
            return teklaObject.DistanceB;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DistanceB), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.DistanceB = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DistanceB), ex); 
            }
        }
    }
    

    

		public LoadLine()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LoadLine");
		}
		
		public LoadLine(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}




public enum LineLoadFormEnum
{
			LOAD_FORM_LINE_1,
			LOAD_FORM_LINE_2,
			LOAD_FORM_LINE_3,
			LOAD_FORM_LINE_4        
}

internal static class LineLoadFormEnum_
{
    public static dynamic GetTSObject(LineLoadFormEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.LoadLine.LineLoadFormEnum").GetType();

        switch (dynEnum)
        {
				case LineLoadFormEnum.LOAD_FORM_LINE_1:
					return System.Enum.Parse(tsType, "LOAD_FORM_LINE_1");
				case LineLoadFormEnum.LOAD_FORM_LINE_2:
					return System.Enum.Parse(tsType, "LOAD_FORM_LINE_2");
				case LineLoadFormEnum.LOAD_FORM_LINE_3:
					return System.Enum.Parse(tsType, "LOAD_FORM_LINE_3");
				case LineLoadFormEnum.LOAD_FORM_LINE_4:
					return System.Enum.Parse(tsType, "LOAD_FORM_LINE_4");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static LineLoadFormEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
        
			if (tsEnumValue.Equals("LOAD_FORM_LINE_1", System.StringComparison.InvariantCulture))
				return LineLoadFormEnum.LOAD_FORM_LINE_1;
			else if (tsEnumValue.Equals("LOAD_FORM_LINE_2", System.StringComparison.InvariantCulture))
				return LineLoadFormEnum.LOAD_FORM_LINE_2;
			else if (tsEnumValue.Equals("LOAD_FORM_LINE_3", System.StringComparison.InvariantCulture))
				return LineLoadFormEnum.LOAD_FORM_LINE_3;
			else if (tsEnumValue.Equals("LOAD_FORM_LINE_4", System.StringComparison.InvariantCulture))
				return LineLoadFormEnum.LOAD_FORM_LINE_4;

        else 
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
        
    }
}



}

internal static class LoadLine_
{
    public static dynamic GetTSObject(LoadLine dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static LoadLine FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (LoadLine)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class LoadLineArray_
{
    public static dynamic GetTSObject(LoadLine[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(LoadLine_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static LoadLine[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<LoadLine>();
        foreach(var tsItem in tsArray)
        {
            list.Add(LoadLine_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

