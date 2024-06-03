using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures;
public abstract class TeklaStructuresVariables
{
    internal dynamic teklaObject;

    public static System.String PourManagementOptionName
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.TeklaStructuresVariables", "PourManagementOptionName");
            return (System.String)value;
        }

    }

    public static void Add(System.String key)
    {
        MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresVariables", "Add", key);
    }

    public static System.String Get(System.String key)
    {
        var result = (System.String)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresVariables", "Get", key);
        return result;
    }

    public static bool ContainsVariable(System.String key)
    {
        var result = (bool)MethodInvoker.InvokeStaticMethod("Tekla.Structures.TeklaStructuresVariables", "ContainsVariable", key);
        return result;
    }
}

internal static class TeklaStructuresVariables_
{
    public static dynamic GetTSObject(TeklaStructuresVariables dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static TeklaStructuresVariables FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Dynamic.Tekla.Structures.TeklaStructuresVariables)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

