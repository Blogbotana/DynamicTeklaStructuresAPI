using Dynamic.Tekla.Structures.Internal;

namespace Dynamic.Tekla.Structures.Model;

public class SelfIntersectingSurfaceException : LoftedPlateOperationException
{
    public SelfIntersectingSurfaceException()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SelfIntersectingSurfaceException");
    }

    public SelfIntersectingSurfaceException(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }

}

internal static class SelfIntersectingSurfaceException_
{
    public static dynamic GetTSObject(SelfIntersectingSurfaceException dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static SelfIntersectingSurfaceException FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (SelfIntersectingSurfaceException)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class SelfIntersectingSurfaceExceptionArray_
{
    public static dynamic GetTSObject(SelfIntersectingSurfaceException[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(SelfIntersectingSurfaceException_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static SelfIntersectingSurfaceException[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<SelfIntersectingSurfaceException>();
        foreach (var tsItem in tsArray)
        {
            list.Add(SelfIntersectingSurfaceException_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

