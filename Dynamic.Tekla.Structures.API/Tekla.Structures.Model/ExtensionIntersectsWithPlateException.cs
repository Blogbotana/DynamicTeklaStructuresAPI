using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class ExtensionIntersectsWithPlateException  : ConnectiveGeometryException
{

    

    

		public ExtensionIntersectsWithPlateException()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ExtensionIntersectsWithPlateException");
		}
		
		public ExtensionIntersectsWithPlateException(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





}

internal static class ExtensionIntersectsWithPlateException_
{
    public static dynamic GetTSObject(ExtensionIntersectsWithPlateException dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ExtensionIntersectsWithPlateException FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ExtensionIntersectsWithPlateException)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ExtensionIntersectsWithPlateExceptionArray_
{
    public static dynamic GetTSObject(ExtensionIntersectsWithPlateException[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(ExtensionIntersectsWithPlateException_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static ExtensionIntersectsWithPlateException[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<ExtensionIntersectsWithPlateException>();
        foreach(var tsItem in tsArray)
        {
            list.Add(ExtensionIntersectsWithPlateException_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

