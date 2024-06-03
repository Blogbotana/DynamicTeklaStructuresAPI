using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Invoker;
using System.Runtime;

namespace Dynamic.Tekla.Structures.Datatype;
/// <summary>
/// The Settings class contains the currently active unit settings.
/// </summary>
public class Settings
{
    internal dynamic teklaObject;

    public Settings()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Datatype.Settings");
    }

    public Settings(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public static System.Object GetValue(string name)
    {
        var result = (System.Object)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Datatype.Settings", "GetValue", name);
        return result;
    }

    public static System.Boolean TryGetValue(string name, out System.Object obj)
    {
        obj = null;
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Datatype.Settings", "TryGetValue", name, ref obj);
        return result;
    }
    public static System.Boolean TryGetValue<T>(string name, out T obj)
    {
        obj = default(T);
        if (TryGetValue(name, out var value) && value is T)
        {
            obj = (T)value;
            return true;
        }
        return false;
    }

    public static void SetValue(string name, System.Object value)
    {
        MethodInvoker.InvokeStaticMethod("Tekla.Structures.Datatype.Settings", "SetValue", name, value);

    }
}

internal static class Settings_
{
    public static dynamic GetTSObject(Settings dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Settings FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Datatype.Settings)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
