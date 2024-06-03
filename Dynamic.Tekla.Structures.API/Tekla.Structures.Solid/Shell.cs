using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;

namespace Dynamic.Tekla.Structures.Solid;
/// <summary>
/// The Shell class represents a single shell in a solid.
/// </summary>
public sealed class Shell
{

    internal dynamic teklaObject;

    internal Shell() { }
    
    public Shell(dynamic tsObject, DateTime nonConflictParameter)
    {
        this.teklaObject = tsObject;
    }


    public Dynamic.Tekla.Structures.Solid.FaceEnumerator GetFaceEnumerator()
    {

        try
        {
            var result = teklaObject.GetFaceEnumerator();

            var _result = Dynamic.Tekla.Structures.Solid.FaceEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetFaceEnumerator), ex);
        }
    }



    public Dynamic.Tekla.Structures.Solid.EdgeEnumerator GetEdgeEnumerator()
    {

        try
        {
            var result = teklaObject.GetEdgeEnumerator();

            var _result = Dynamic.Tekla.Structures.Solid.EdgeEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetEdgeEnumerator), ex);
        }
    }

}
internal static class Shell_
{
    public static dynamic GetTSObject(Shell dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Shell FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Solid.Shell)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}