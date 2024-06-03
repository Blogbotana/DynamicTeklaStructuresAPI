using Dynamic.Tekla.Structures.Geometry3d;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections;

namespace Dynamic.Tekla.Structures.Solid;
/// <summary>
/// The VertexEnumerator class is used to enumerate the vertexes of a loop instance.
/// </summary>
public sealed class VertexEnumerator : IEnumerator
{
    object IEnumerator.Current => Current;
    public Point Current
    {
        get
        {
            try
            {
                var value = teklaObject.Current;
                var value_ = Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Current), ex);
            }
        }

    }
    internal dynamic teklaObject;

    internal VertexEnumerator() { }

    public VertexEnumerator(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
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
internal static class VertexEnumerator_
{
    public static dynamic GetTSObject(VertexEnumerator dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static VertexEnumerator FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Solid.VertexEnumerator)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}