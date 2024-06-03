using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Solid;
/// <summary>
/// The Loop class represents a single loop in a face.
/// </summary>
public sealed class Loop
{
    internal dynamic teklaObject;

    internal Loop() { }
    
    public Loop(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public VertexEnumerator GetVertexEnumerator()
    {

        try
        {
            var result = teklaObject.GetVertexEnumerator();

            var _result = VertexEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetVertexEnumerator), ex);
        }
    }

}
internal static class Loop_
{
    public static dynamic GetTSObject(Loop dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Loop FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Solid.Loop)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}