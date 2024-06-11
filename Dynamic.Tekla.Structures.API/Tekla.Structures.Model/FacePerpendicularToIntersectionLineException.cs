using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class FacePerpendicularToIntersectionLineException  : ConnectiveGeometryException
{

    

    

		public FacePerpendicularToIntersectionLineException()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.FacePerpendicularToIntersectionLineException");
		}
		
		public FacePerpendicularToIntersectionLineException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





}

internal static class FacePerpendicularToIntersectionLineException_
{
    public static dynamic GetTSObject(FacePerpendicularToIntersectionLineException dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static FacePerpendicularToIntersectionLineException FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (FacePerpendicularToIntersectionLineException)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class FacePerpendicularToIntersectionLineExceptionArray_
{
    public static dynamic GetTSObject(FacePerpendicularToIntersectionLineException[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(FacePerpendicularToIntersectionLineException_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static FacePerpendicularToIntersectionLineException[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<FacePerpendicularToIntersectionLineException>();
        foreach(var tsItem in tsArray)
        {
            list.Add(FacePerpendicularToIntersectionLineException_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

