using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;
public class ClashCheckHandler
{



    internal dynamic teklaObject;

    internal ClashCheckHandler() { }

    public ClashCheckHandler(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }


    public bool RunClashCheck()
    {

        try
        {
            var result = (bool)teklaObject.RunClashCheck();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RunClashCheck), ex);
        }
    }



    public bool RunClashCheckWithOptions(
        bool betweenReferenceModels,
        bool objectsInsideReferenceModels,
        double minDistance,
        bool betweenParts)
    {

        try
        {
            var result = (bool)teklaObject.RunClashCheckWithOptions(betweenReferenceModels, objectsInsideReferenceModels, minDistance, betweenParts);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RunClashCheckWithOptions), ex);
        }
    }



    public bool RunClashCheckWithOptions(
        bool betweenReferenceModels,
        bool betweenReferenceModelsAndComponents,
        bool objectsInsideReferenceModels,
        double minDistance,
        bool betweenParts)
    {


        try
        {
            var result = (bool)teklaObject.RunClashCheckWithOptions(betweenReferenceModels, betweenReferenceModelsAndComponents, objectsInsideReferenceModels, minDistance, betweenParts);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RunClashCheckWithOptions), ex);
        }
    }



    public bool StopClashCheck()
    {

        try
        {
            var result = (bool)teklaObject.StopClashCheck();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(StopClashCheck), ex);
        }
    }



    public System.Collections.ArrayList GetIntersectionBoundingBoxes(
        Dynamic.Tekla.Structures.Identifier ID1_,
        Dynamic.Tekla.Structures.Identifier ID2_)
    {
        var ID1 = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID1_);
        var ID2 = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID2_);
        try
        {
            var result = teklaObject.GetIntersectionBoundingBoxes(ID1, ID2);

            var _result = ArrayListConverter.FromTSObjects(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetIntersectionBoundingBoxes), ex);
        }
    }






}

internal static class ClashCheckHandler_
{
    public static dynamic GetTSObject(ClashCheckHandler dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ClashCheckHandler FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ClashCheckHandler)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}



