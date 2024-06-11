using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.ModelInternal;
public abstract class Operation
{
    internal dynamic teklaObject;

    public static bool dotStartCommand(string CommandName, string Parameters)
    {

        try
        {
            var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.ModelInternal.Operation", "dotStartCommand", CommandName, Parameters);
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(dotStartCommand), ex);
        }
    }
    public static bool dotStartAction(string CommandName, string Parameters)
    {

        try
        {
            var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.ModelInternal.Operation", "dotStartAction", CommandName, Parameters);
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(dotStartAction), ex);
        }
    }
}
internal static class Operation_
{
    public static dynamic GetTSObject(Operation dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Operation FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.ModelInternal.Operation)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
