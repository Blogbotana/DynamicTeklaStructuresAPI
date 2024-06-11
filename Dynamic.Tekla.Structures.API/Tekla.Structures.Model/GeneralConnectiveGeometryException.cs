using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class GeneralConnectiveGeometryException  : ConnectiveGeometryException
{

    

    

		public GeneralConnectiveGeometryException()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.GeneralConnectiveGeometryException");
		}
		
		public GeneralConnectiveGeometryException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





}

internal static class GeneralConnectiveGeometryException_
{
    public static dynamic GetTSObject(GeneralConnectiveGeometryException dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static GeneralConnectiveGeometryException FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (GeneralConnectiveGeometryException)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class GeneralConnectiveGeometryExceptionArray_
{
    public static dynamic GetTSObject(GeneralConnectiveGeometryException[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(GeneralConnectiveGeometryException_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static GeneralConnectiveGeometryException[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<GeneralConnectiveGeometryException>();
        foreach(var tsItem in tsArray)
        {
            list.Add(GeneralConnectiveGeometryException_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

