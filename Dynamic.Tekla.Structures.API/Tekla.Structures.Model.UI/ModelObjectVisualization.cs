using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model.UI;


public abstract class ModelObjectVisualization 
{

    

    internal dynamic teklaObject;



    public static System.Boolean SetTemporaryStateForAll(
			Dynamic.Tekla.Structures.Model.UI.Color color_)
    {
        var color = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color_);
        var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "SetTemporaryStateForAll", color);
        return result;
    }



    public static System.Boolean SetTemporaryState(
			System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> modelObjects_,
			Dynamic.Tekla.Structures.Model.UI.Color color_)
    {
        var modelObjects = ListConverter.ToTSObjects(modelObjects_);
var color = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color_);
        var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "SetTemporaryState", modelObjects, color);
        return result;
    }



    public static System.Boolean SetTransparencyForAll(
			Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency transparency_)
    {
        var transparency = Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency_.GetTSObject(transparency_);
        var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "SetTransparencyForAll", transparency);
        return result;
    }



    public static System.Boolean SetTransparency(
			System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> modelObjects_,
			Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency transparency_)
    {
        var modelObjects = ListConverter.ToTSObjects(modelObjects_);
var transparency = Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency_.GetTSObject(transparency_);
        var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "SetTransparency", modelObjects, transparency);
        return result;
    }



    public static System.Boolean SetTransparency(
			System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> identifiers_,
			Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency transparency_)
    {
        var identifiers = ListConverter.ToTSObjects(identifiers_);
var transparency = Dynamic.Tekla.Structures.Model.UI.TemporaryTransparency_.GetTSObject(transparency_);
        var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "SetTransparency", identifiers, transparency);
        return result;
    }



    public static System.Boolean SetTemporaryState(
			System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> identifiers_,
			Dynamic.Tekla.Structures.Model.UI.Color color_)
    {
        var identifiers = ListConverter.ToTSObjects(identifiers_);
var color = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color_);
        var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "SetTemporaryState", identifiers, color);
        return result;
    }



    public static System.Boolean GetRepresentation(
			Dynamic.Tekla.Structures.Model.ModelObject modelObject_,
			ref Dynamic.Tekla.Structures.Model.UI.Color color_)
    {
        var modelObject = Dynamic.Tekla.Structures.Model.ModelObject_.GetTSObject(modelObject_);
var color = Dynamic.Tekla.Structures.Model.UI.Color_.GetTSObject(color_);
        var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "GetRepresentation", modelObject, ref color);
        color_ = Dynamic.Tekla.Structures.Model.UI.Color_.FromTSObject(color);
        return result;
    }



    public static System.Boolean ClearAllTemporaryStates()
    {
        var result = (System.Boolean) MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.UI.ModelObjectVisualization", "ClearAllTemporaryStates");
        return result;
    }






}

internal static class ModelObjectVisualization_
{
    public static dynamic GetTSObject(ModelObjectVisualization dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ModelObjectVisualization FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Model.UI.ModelObjectVisualization)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
