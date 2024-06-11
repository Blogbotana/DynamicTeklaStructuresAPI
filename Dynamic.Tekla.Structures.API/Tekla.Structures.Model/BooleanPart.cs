using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;
public sealed class BooleanPart : Boolean
{

    public BooleanPart.BooleanTypeEnum Type
    {
        get
        {
            try
            {
                var value = teklaObject.Type;
                var value_ = BooleanPart.BooleanTypeEnum_.FromTSObject(value);
                return (BooleanPart.BooleanTypeEnum)value_;
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
                var value_ = BooleanPart.BooleanTypeEnum_.GetTSObject(value);
                teklaObject.Type = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Type), ex);
            }
        }
    }

    public Part OperativePart
    {
        get
        {
            try
            {
                var value = teklaObject.OperativePart;
                var value_ = Part_.FromTSObject(value);
                return (Part)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OperativePart), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Part_.GetTSObject(value);
                teklaObject.OperativePart = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OperativePart), ex);
            }
        }
    }

    public static string BooleanOperativeClassName
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Model.BooleanPart", "BooleanOperativeClassName");
            return (string)value;
        }

    }



    public BooleanPart()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BooleanPart");
    }
    
    public BooleanPart(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }


    public bool SetOperativePart(
        Part Part_)
    {
        var Part = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(Part_);
        try
        {
            var result = (bool)teklaObject.SetOperativePart(Part);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetOperativePart), ex);
        }
    }





    public enum BooleanTypeEnum
    {
        BOOLEAN_ADD,
        BOOLEAN_CUT,
        BOOLEAN_WELDPREP
    }

    internal static class BooleanTypeEnum_
    {
        public static dynamic GetTSObject(BooleanTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.BooleanPart.BooleanTypeEnum").GetType();

            switch (dynEnum)
            {
                case BooleanTypeEnum.BOOLEAN_ADD:
                    return System.Enum.Parse(tsType, "BOOLEAN_ADD");
                case BooleanTypeEnum.BOOLEAN_CUT:
                    return System.Enum.Parse(tsType, "BOOLEAN_CUT");
                case BooleanTypeEnum.BOOLEAN_WELDPREP:
                    return System.Enum.Parse(tsType, "BOOLEAN_WELDPREP");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static BooleanTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("BOOLEAN_ADD", System.StringComparison.InvariantCulture))
                return BooleanTypeEnum.BOOLEAN_ADD;
            else if (tsEnumValue.Equals("BOOLEAN_CUT", System.StringComparison.InvariantCulture))
                return BooleanTypeEnum.BOOLEAN_CUT;
            else if (tsEnumValue.Equals("BOOLEAN_WELDPREP", System.StringComparison.InvariantCulture))
                return BooleanTypeEnum.BOOLEAN_WELDPREP;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class BooleanPart_
{
    public static dynamic GetTSObject(BooleanPart dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static BooleanPart FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (BooleanPart)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

