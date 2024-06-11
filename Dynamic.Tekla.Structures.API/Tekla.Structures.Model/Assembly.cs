using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;
public sealed class Assembly : ModelObject
{
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

    public NumberingSeries AssemblyNumber
    {
        get
        {
            try
            {
                var value = teklaObject.AssemblyNumber;
                var value_ = NumberingSeries_.FromTSObject(value);
                return (NumberingSeries)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AssemblyNumber), ex);
            }
        }
        set
        {
            try
            {
                var value_ = NumberingSeries_.GetTSObject(value);
                teklaObject.AssemblyNumber = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(AssemblyNumber), ex);
            }
        }
    }


    public Assembly()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Assembly");
    }

    public Assembly(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public ModelObject GetMainObject()
    {

        try
        {
            var result = teklaObject.GetMainObject();

            var _result = ModelObject_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetMainObject), ex);
        }
    }



    public ModelObject GetMainPart()
    {

        try
        {
            var result = teklaObject.GetMainPart();

            var _result = ModelObject_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetMainPart), ex);
        }
    }



    public bool SetMainObject(ModelObject mainObject_)
    {
        var mainObject = ModelObject_.GetTSObject(mainObject_);
        try
        {
            var result = (bool)teklaObject.SetMainObject(mainObject);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetMainObject), ex);
        }
    }



    public bool SetMainPart(Part Part_)
    {
        var Part = Dynamic.Tekla.Structures.Model.Part_.GetTSObject(Part_);
        try
        {
            var result = (bool)teklaObject.SetMainPart(Part);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetMainPart), ex);
        }
    }

    public System.Collections.ArrayList GetSecondaries()
    {

        try
        {
            var result = teklaObject.GetSecondaries();

            var _result = ArrayListConverter.FromTSObjects(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSecondaries), ex);
        }
    }

    public bool Add(IAssemblable Object_)
    {
        var Object = IAssemblable_.GetTSObject(Object_);
        try
        {
            var result = (bool)teklaObject.Add(Object);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Add), ex);
        }
    }

    public bool Add(System.Collections.ArrayList Assemblables_)
    {
        var Assemblables = ArrayListConverter.ToTSObjects(Assemblables_);
        try
        {
            var result = (bool)teklaObject.Add(Assemblables);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Add), ex);
        }
    }

    public bool Remove(ModelObject Object_)
    {
        var Object = ModelObject_.GetTSObject(Object_);
        try
        {
            var result = (bool)teklaObject.Remove(Object);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Remove), ex);
        }
    }

    public bool Add(Assembly Assembly_)
    {
        var Assembly = Dynamic.Tekla.Structures.Model.Assembly_.GetTSObject(Assembly_);
        try
        {
            var result = (bool)teklaObject.Add(Assembly);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Add), ex);
        }
    }

    public Assembly GetAssembly()
    {

        try
        {
            var result = teklaObject.GetAssembly();

            var _result = Assembly_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAssembly), ex);
        }
    }

    public System.Collections.ArrayList GetSubAssemblies()
    {

        try
        {
            var result = teklaObject.GetSubAssemblies();

            var _result = ArrayListConverter.FromTSObjects(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSubAssemblies), ex);
        }
    }

    public Assembly.AssemblyTypeEnum GetAssemblyType()
    {

        try
        {
            var result = teklaObject.GetAssemblyType();

            var _result = Assembly.AssemblyTypeEnum_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAssemblyType), ex);
        }
    }

    public PourObject GetFatherPour()
    {

        try
        {
            var result = teklaObject.GetFatherPour();

            var _result = PourObject_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetFatherPour), ex);
        }
    }

    public PourUnit GetFatherPourUnit()
    {

        try
        {
            var result = teklaObject.GetFatherPourUnit();

            var _result = PourUnit_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetFatherPourUnit), ex);
        }
    }

    public bool SetUserDefinedCoordSys(Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem coordinateSystem_)
    {
        var coordinateSystem = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(coordinateSystem_);
        try
        {
            var result = (bool)teklaObject.SetUserDefinedCoordSys(coordinateSystem);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetUserDefinedCoordSys), ex);
        }
    }

    public bool HasUserDefinedCoordSys()
    {

        try
        {
            var result = (bool)teklaObject.HasUserDefinedCoordSys();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(HasUserDefinedCoordSys), ex);
        }
    }

    public bool DeleteUserDefinedCoordSys()
    {

        try
        {
            var result = (bool)teklaObject.DeleteUserDefinedCoordSys();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(DeleteUserDefinedCoordSys), ex);
        }
    }

    public bool CompareTo(Assembly AssemblyToCompare_)
    {
        var AssemblyToCompare = Assembly_.GetTSObject(AssemblyToCompare_);
        try
        {
            var result = (bool)teklaObject.CompareTo(AssemblyToCompare);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CompareTo), ex);
        }
    }


    public enum AssemblyTypeEnum
    {
        STEEL_ASSEMBLY,
        PRECAST_ASSEMBLY,
        IN_SITU_ASSEMBLY,
        TIMBER_ASSEMBLY,
        UNKNOWN_ASSEMBLY,
        REBAR_ASSEMBLY
    }

    internal static class AssemblyTypeEnum_
    {
        public static dynamic GetTSObject(AssemblyTypeEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Assembly.AssemblyTypeEnum").GetType();

            switch (dynEnum)
            {
                case AssemblyTypeEnum.STEEL_ASSEMBLY:
                    return System.Enum.Parse(tsType, "STEEL_ASSEMBLY");
                case AssemblyTypeEnum.PRECAST_ASSEMBLY:
                    return System.Enum.Parse(tsType, "PRECAST_ASSEMBLY");
                case AssemblyTypeEnum.IN_SITU_ASSEMBLY:
                    return System.Enum.Parse(tsType, "IN_SITU_ASSEMBLY");
                case AssemblyTypeEnum.TIMBER_ASSEMBLY:
                    return System.Enum.Parse(tsType, "TIMBER_ASSEMBLY");
                case AssemblyTypeEnum.UNKNOWN_ASSEMBLY:
                    return System.Enum.Parse(tsType, "UNKNOWN_ASSEMBLY");
                case AssemblyTypeEnum.REBAR_ASSEMBLY:
                    return System.Enum.Parse(tsType, "REBAR_ASSEMBLY");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static AssemblyTypeEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("STEEL_ASSEMBLY", System.StringComparison.InvariantCulture))
                return AssemblyTypeEnum.STEEL_ASSEMBLY;
            else if (tsEnumValue.Equals("PRECAST_ASSEMBLY", System.StringComparison.InvariantCulture))
                return AssemblyTypeEnum.PRECAST_ASSEMBLY;
            else if (tsEnumValue.Equals("IN_SITU_ASSEMBLY", System.StringComparison.InvariantCulture))
                return AssemblyTypeEnum.IN_SITU_ASSEMBLY;
            else if (tsEnumValue.Equals("TIMBER_ASSEMBLY", System.StringComparison.InvariantCulture))
                return AssemblyTypeEnum.TIMBER_ASSEMBLY;
            else if (tsEnumValue.Equals("UNKNOWN_ASSEMBLY", System.StringComparison.InvariantCulture))
                return AssemblyTypeEnum.UNKNOWN_ASSEMBLY;
            else if (tsEnumValue.Equals("REBAR_ASSEMBLY", System.StringComparison.InvariantCulture))
                return AssemblyTypeEnum.REBAR_ASSEMBLY;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }

}

internal static class Assembly_
{
    public static dynamic GetTSObject(Assembly dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Assembly FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Assembly)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
