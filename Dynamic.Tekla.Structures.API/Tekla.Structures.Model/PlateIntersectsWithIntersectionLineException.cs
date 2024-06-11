using Dynamic.Tekla.Structures.Internal;

namespace Dynamic.Tekla.Structures.Model;

public class PlateIntersectsWithIntersectionLineException : ConnectiveGeometryException
{





    public PlateIntersectsWithIntersectionLineException()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PlateIntersectsWithIntersectionLineException");
    }

    public PlateIntersectsWithIntersectionLineException(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }





}

internal static class PlateIntersectsWithIntersectionLineException_
{
    public static dynamic GetTSObject(PlateIntersectsWithIntersectionLineException dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static PlateIntersectsWithIntersectionLineException FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (PlateIntersectsWithIntersectionLineException)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class PlateIntersectsWithIntersectionLineExceptionArray_
{
    public static dynamic GetTSObject(PlateIntersectsWithIntersectionLineException[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(PlateIntersectsWithIntersectionLineException_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static PlateIntersectsWithIntersectionLineException[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<PlateIntersectsWithIntersectionLineException>();
        foreach (var tsItem in tsArray)
        {
            list.Add(PlateIntersectsWithIntersectionLineException_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}




