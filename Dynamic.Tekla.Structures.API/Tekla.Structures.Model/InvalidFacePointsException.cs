using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class InvalidFacePointsException  : ConnectiveGeometryException
{

    

    

		public InvalidFacePointsException()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.InvalidFacePointsException");
		}
		
		public InvalidFacePointsException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





}

internal static class InvalidFacePointsException_
{
    public static dynamic GetTSObject(InvalidFacePointsException dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static InvalidFacePointsException FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (InvalidFacePointsException)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class InvalidFacePointsExceptionArray_
{
    public static dynamic GetTSObject(InvalidFacePointsException[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(InvalidFacePointsException_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static InvalidFacePointsException[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<InvalidFacePointsException>();
        foreach(var tsItem in tsArray)
        {
            list.Add(InvalidFacePointsException_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

