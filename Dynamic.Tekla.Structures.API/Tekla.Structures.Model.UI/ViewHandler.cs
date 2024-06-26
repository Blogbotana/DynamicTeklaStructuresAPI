using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model.UI;


public sealed class ViewHandler
{



    internal dynamic teklaObject;

    public ViewHandler()
    {
        this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.ViewHandler");
    }
    
    public ViewHandler(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        this.teklaObject = tsObject;
    }


    public static Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator GetAllViews()
    {
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "GetAllViews");
        var _result = Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator GetVisibleViews()
    {
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "GetVisibleViews");
        var _result = Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator GetPermanentViews()
    {
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "GetPermanentViews");
        var _result = Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator GetTemporaryViews()
    {
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "GetTemporaryViews");
        var _result = Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator_.FromTSObject(result);
        return _result;
    }



    public static Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator GetSelectedViews()
    {
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "GetSelectedViews");
        var _result = Dynamic.Tekla.Structures.Model.UI.ModelViewEnumerator_.FromTSObject(result);
        return _result;
    }



    public static System.Boolean ShowView(
            Dynamic.Tekla.Structures.Model.UI.View view_)
    {
        var view = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(view_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "ShowView", view);
        return result;
    }



    public static System.Boolean HideView(
            Dynamic.Tekla.Structures.Model.UI.View view_)
    {
        var view = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(view_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "HideView", view);
        return result;
    }



    public static System.Boolean RedrawView(
            Dynamic.Tekla.Structures.Model.UI.View view_)
    {
        var view = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(view_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "RedrawView", view);
        return result;
    }



    public static System.Boolean ZoomToBoundingBox(
            Dynamic.Tekla.Structures.Model.UI.View view_,
            Dynamic.Tekla.Structures.Geometry3d.AABB B_)
    {
        var view = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(view_);
        var B = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(B_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "ZoomToBoundingBox", view, B);
        return result;
    }



    public static System.Boolean ZoomToBoundingBox(
            Dynamic.Tekla.Structures.Geometry3d.AABB box_)
    {
        var box = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(box_);
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "ZoomToBoundingBox", box);
        return result;
    }



    public static System.Boolean SetRepresentation(
            System.String Representation)
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "SetRepresentation", Representation);
        return result;
    }



    public static System.Boolean RedrawWorkplane()
    {
        var result = (System.Boolean)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ViewHandler", "RedrawWorkplane");
        return result;
    }
}

internal static class ViewHandler_
{
    public static dynamic GetTSObject(ViewHandler dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ViewHandler FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Model.UI.ViewHandler)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ViewHandlerArray_
{
    public static dynamic GetTSObject(ViewHandler[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(ViewHandler_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static ViewHandler[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<ViewHandler>();
        foreach (var tsItem in tsArray)
        {
            list.Add(ViewHandler_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

