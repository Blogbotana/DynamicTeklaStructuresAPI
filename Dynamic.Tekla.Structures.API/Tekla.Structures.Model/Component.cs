using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public class Component : BaseComponent
{
    public Component()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Component");
    }

    public Component(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public Component(ComponentInput I)
    {
        var args = new object[1];
        args[0] = ComponentInput_.GetTSObject(I);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Component", args);
    }


    public bool SetComponentInput(
        ComponentInput I_)
    {
        var I = ComponentInput_.GetTSObject(I_);
        try
        {
            var result = (bool)teklaObject.SetComponentInput(I);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetComponentInput), ex);
        }
    }



    public ComponentInput GetComponentInput()
    {

        try
        {
            var result = teklaObject.GetComponentInput();

            var _result = ComponentInput_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetComponentInput), ex);
        }
    }



    public ModelObjectEnumerator GetBooleans()
    {

        try
        {
            var result = teklaObject.GetBooleans();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetBooleans), ex);
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



    public ModelObjectEnumerator GetComponents()
    {

        try
        {
            var result = teklaObject.GetComponents();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetComponents), ex);
        }
    }






}

internal static class Component_
{
    public static dynamic GetTSObject(Component dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Component FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Component)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ComponentArray_
{
    public static dynamic GetTSObject(Component[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(Component_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static Component[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<Component>();
        foreach (var tsItem in tsArray)
        {
            list.Add(Component_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

