using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;

public sealed class InputItem 
{

    

    internal dynamic teklaObject;

		internal InputItem() {}
		
		public InputItem(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}


    public InputItem.InputTypeEnum GetInputType()
    {
        
        try
        {
            var result = teklaObject.GetInputType();
        
            var _result = InputItem.InputTypeEnum_.FromTSObject(result);
				return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetInputType), ex);
        }
    }



    public System.Object GetData()
    {
        
        try
        {
            var result = (System.Object) teklaObject.GetData();
        
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetData), ex);
        }
    }





public enum InputTypeEnum
{
			INPUT_1_POINT,
			INPUT_2_POINTS,
			INPUT_POLYGON,
			INPUT_1_OBJECT,
			INPUT_N_OBJECTS        
}

internal static class InputTypeEnum_
{
    public static dynamic GetTSObject(InputTypeEnum dynEnum)
    {
        var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.InputItem.InputTypeEnum").GetType();

        switch (dynEnum)
        {
				case InputTypeEnum.INPUT_1_POINT:
					return System.Enum.Parse(tsType, "INPUT_1_POINT");
				case InputTypeEnum.INPUT_2_POINTS:
					return System.Enum.Parse(tsType, "INPUT_2_POINTS");
				case InputTypeEnum.INPUT_POLYGON:
					return System.Enum.Parse(tsType, "INPUT_POLYGON");
				case InputTypeEnum.INPUT_1_OBJECT:
					return System.Enum.Parse(tsType, "INPUT_1_OBJECT");
				case InputTypeEnum.INPUT_N_OBJECTS:
					return System.Enum.Parse(tsType, "INPUT_N_OBJECTS");

            default:
                throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
        }
    }

    public static InputTypeEnum FromTSObject(dynamic tsEnum)
    {
        string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
        
			if (tsEnumValue.Equals("INPUT_1_POINT", System.StringComparison.InvariantCulture))
				return InputTypeEnum.INPUT_1_POINT;
			else if (tsEnumValue.Equals("INPUT_2_POINTS", System.StringComparison.InvariantCulture))
				return InputTypeEnum.INPUT_2_POINTS;
			else if (tsEnumValue.Equals("INPUT_POLYGON", System.StringComparison.InvariantCulture))
				return InputTypeEnum.INPUT_POLYGON;
			else if (tsEnumValue.Equals("INPUT_1_OBJECT", System.StringComparison.InvariantCulture))
				return InputTypeEnum.INPUT_1_OBJECT;
			else if (tsEnumValue.Equals("INPUT_N_OBJECTS", System.StringComparison.InvariantCulture))
				return InputTypeEnum.INPUT_N_OBJECTS;

        else 
            throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");
        
    }
}



}

internal static class InputItem_
{
    public static dynamic GetTSObject(InputItem dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static InputItem FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (InputItem)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class InputItemArray_
{
    public static dynamic GetTSObject(InputItem[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(InputItem_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static InputItem[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<InputItem>();
        foreach(var tsItem in tsArray)
        {
            list.Add(InputItem_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

