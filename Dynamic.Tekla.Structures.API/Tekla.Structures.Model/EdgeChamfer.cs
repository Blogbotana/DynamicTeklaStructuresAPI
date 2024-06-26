using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class EdgeChamfer  : Boolean
{


    public Chamfer Chamfer
    {
        get
        {
            try
            {
            var value = teklaObject.Chamfer;
            var value_ = Chamfer_.FromTSObject(value);
            return (Chamfer) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Chamfer), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Chamfer_.GetTSObject(value);
            teklaObject.Chamfer = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Chamfer), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point FirstEnd
    {
        get
        {
            try
            {
            var value = teklaObject.FirstEnd;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FirstEnd), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
            teklaObject.FirstEnd = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FirstEnd), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point SecondEnd
    {
        get
        {
            try
            {
            var value = teklaObject.SecondEnd;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SecondEnd), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
            teklaObject.SecondEnd = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SecondEnd), ex); 
            }
        }
    }

    public EdgeChamfer.ChamferEndTypeEnum FirstChamferEndType
    {
        get
        {
            try
            {
            var value = teklaObject.FirstChamferEndType;
            var value_ = EdgeChamfer.ChamferEndTypeEnum_.FromTSObject(value);
            return (EdgeChamfer.ChamferEndTypeEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FirstChamferEndType), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = EdgeChamfer.ChamferEndTypeEnum_.GetTSObject(value);
            teklaObject.FirstChamferEndType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FirstChamferEndType), ex); 
            }
        }
    }

    public EdgeChamfer.ChamferEndTypeEnum SecondChamferEndType
    {
        get
        {
            try
            {
            var value = teklaObject.SecondChamferEndType;
            var value_ = EdgeChamfer.ChamferEndTypeEnum_.FromTSObject(value);
            return (EdgeChamfer.ChamferEndTypeEnum) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SecondChamferEndType), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = EdgeChamfer.ChamferEndTypeEnum_.GetTSObject(value);
            teklaObject.SecondChamferEndType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SecondChamferEndType), ex); 
            }
        }
    }

    public double SecondBevelDimension
    {
        get
        {
            try
            {
            return teklaObject.SecondBevelDimension;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SecondBevelDimension), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.SecondBevelDimension = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SecondBevelDimension), ex); 
            }
        }
    }

    public double FirstBevelDimension
    {
        get
        {
            try
            {
            return teklaObject.FirstBevelDimension;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FirstBevelDimension), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.FirstBevelDimension = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FirstBevelDimension), ex); 
            }
        }
    }

    public string Name
    {
        get
        {
            try
            {
            return teklaObject.Name;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.Name = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex); 
            }
        }
    }
    

    

		public EdgeChamfer()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.EdgeChamfer");
		}
		
		public EdgeChamfer(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}
		public EdgeChamfer(Dynamic.Tekla.Structures.Geometry3d.Point FirstEnd, Dynamic.Tekla.Structures.Geometry3d.Point SecondEnd)
		{
			var args = new object[2];
			args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(FirstEnd);
			args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(SecondEnd);
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.EdgeChamfer", args);
		}




public enum ChamferEndTypeEnum
{
			FULL,
			STRAIGHT,
			BEVELLED        
}

internal static class ChamferEndTypeEnum_
{
    public static dynamic GetTSObject(ChamferEndTypeEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.EdgeChamfer.ChamferEndTypeEnum").GetType();

        switch (dynEnum)
        {
				case ChamferEndTypeEnum.FULL:
					return System.Enum.Parse(tsType, "FULL");
				case ChamferEndTypeEnum.STRAIGHT:
					return System.Enum.Parse(tsType, "STRAIGHT");
				case ChamferEndTypeEnum.BEVELLED:
					return System.Enum.Parse(tsType, "BEVELLED");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static ChamferEndTypeEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
        
			if (tsEnumValue.Equals("FULL", System.StringComparison.InvariantCulture))
				return ChamferEndTypeEnum.FULL;
			else if (tsEnumValue.Equals("STRAIGHT", System.StringComparison.InvariantCulture))
				return ChamferEndTypeEnum.STRAIGHT;
			else if (tsEnumValue.Equals("BEVELLED", System.StringComparison.InvariantCulture))
				return ChamferEndTypeEnum.BEVELLED;

        else 
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
        
    }
}



}

internal static class EdgeChamfer_
{
    public static dynamic GetTSObject(EdgeChamfer dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static EdgeChamfer FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (EdgeChamfer)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class EdgeChamferArray_
{
    public static dynamic GetTSObject(EdgeChamfer[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(EdgeChamfer_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static EdgeChamfer[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<EdgeChamfer>();
        foreach(var tsItem in tsArray)
        {
            list.Add(EdgeChamfer_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

