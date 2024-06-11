using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;
public abstract class BaseComponent : ModelObject
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

    public int Number
    {
        get
        {
            try
            {
                return teklaObject.Number;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Number), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Number = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Number), ex);
            }
        }
    }

    public static int CUSTOM_OBJECT_NUMBER
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Model.BaseComponent", "CUSTOM_OBJECT_NUMBER");
            return (int)value;
        }

    }
    public static int PLUGIN_OBJECT_NUMBER
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Model.BaseComponent", "PLUGIN_OBJECT_NUMBER");
            return (int)value;
        }

    }
    public static string ConnectionCodeFromAttributeFile
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Model.BaseComponent", "ConnectionCodeFromAttributeFile");
            return (string)value;
        }

    }
    public static int ClassFromAttributeFile
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Model.BaseComponent", "ClassFromAttributeFile");
            return (int)value;
        }

    }

    public void SetAttribute(string AttrName, string StrValue)
    {
        try
        {
            teklaObject.SetAttribute(AttrName, StrValue);


        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetAttribute), ex);
        }
    }



    public void SetAttribute(string AttrName, int Value)
    {
        try
        {
            teklaObject.SetAttribute(AttrName, Value);


        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetAttribute), ex);
        }
    }



    public void SetAttribute(string AttrName, double DValue)
    {
        try
        {
            teklaObject.SetAttribute(AttrName, DValue);


        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetAttribute), ex);
        }
    }



    public bool GetAttribute(string AttrName, ref string StrValue)
    {
        try
        {
            var result = (bool)teklaObject.GetAttribute(AttrName, ref StrValue);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAttribute), ex);
        }
    }



    public bool GetAttribute(string AttrName, ref int Value)
    {
        try
        {
            var result = (bool)teklaObject.GetAttribute(AttrName, ref Value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAttribute), ex);
        }
    }



    public bool GetAttribute(string AttrName, ref double DValue)
    {
        try
        {
            var result = (bool)teklaObject.GetAttribute(AttrName, ref DValue);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAttribute), ex);
        }
    }



    public bool LoadAttributesFromFile(string Filename)
    {

        try
        {
            var result = (bool)teklaObject.LoadAttributesFromFile(Filename);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(LoadAttributesFromFile), ex);
        }
    }

}
internal static class BaseComponent_
{
    public static dynamic GetTSObject(BaseComponent dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static BaseComponent FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (BaseComponent)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}