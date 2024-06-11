using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;


public class CustomPart : BaseComponent, IAssemblable
{


    public Position Position
    {
        get
        {
            try
            {
                var value = teklaObject.Position;
                var value_ = Position_.FromTSObject(value);
                return (Position)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Position_.GetTSObject(value);
                teklaObject.Position = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Position), ex);
            }
        }
    }

    public dynamic teklaObject { get => teklaObject; set => teklaObject = value; }

    public CustomPart()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CustomPart");
    }

    public CustomPart(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public CustomPart(Dynamic.Tekla.Structures.Geometry3d.Point StartPoint, Dynamic.Tekla.Structures.Geometry3d.Point EndPoint)
    {
        var args = new object[2];
        args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint);
        args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.CustomPart", args);
    }


    public bool SetInputPositions(
            Dynamic.Tekla.Structures.Geometry3d.Point StartPoint_,
            Dynamic.Tekla.Structures.Geometry3d.Point EndPoint_)
    {
        var StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint_);
        var EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint_);
        try
        {
            var result = (bool)teklaObject.SetInputPositions(StartPoint, EndPoint);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetInputPositions), ex);
        }
    }



    public bool GetStartAndEndPositions(
            ref Dynamic.Tekla.Structures.Geometry3d.Point StartPoint_,
            ref Dynamic.Tekla.Structures.Geometry3d.Point EndPoint_)
    {
        var StartPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(StartPoint_);
        var EndPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(EndPoint_);
        try
        {
            var result = (bool)teklaObject.GetStartAndEndPositions(ref StartPoint, ref EndPoint);
            StartPoint_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(StartPoint);
            EndPoint_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(EndPoint);
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetStartAndEndPositions), ex);
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

internal static class CustomPart_
{
    public static dynamic GetTSObject(CustomPart dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static CustomPart FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (CustomPart)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class CustomPartArray_
{
    public static dynamic GetTSObject(CustomPart[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(CustomPart_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static CustomPart[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<CustomPart>();
        foreach (var tsItem in tsArray)
        {
            list.Add(CustomPart_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

