using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections;

namespace Dynamic.Tekla.Structures.Solid;
/// <summary>
/// The EdgeEnumerator class is used to enumerate the edges of a solid.
/// </summary>
public sealed class EdgeEnumerator : IEnumerator
{
    internal dynamic teklaObject;

    internal EdgeEnumerator() { }

    public EdgeEnumerator(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public object Current
    {
        get
        {
            try
            {
                return teklaObject.Current;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Current), ex);
            }
        }

    }
    public bool MoveNext()
    {
        try
        {
            var result = (bool)teklaObject.MoveNext();
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(MoveNext), ex);
        }
    }

    public void Reset()
    {
        try
        {
            teklaObject.Reset();
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Reset), ex);
        }
    }

}
internal static class EdgeEnumerator_
{
    public static dynamic GetTSObject(EdgeEnumerator dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static EdgeEnumerator FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Solid.EdgeEnumerator)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}