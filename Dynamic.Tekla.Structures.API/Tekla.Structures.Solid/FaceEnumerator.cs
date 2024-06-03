using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections;

namespace Dynamic.Tekla.Structures.Solid;
/// <summary>
/// The FaceEnumerator class is used to enumerate the faces of a solid.
/// </summary>
public sealed class FaceEnumerator : IEnumerator
{
    object IEnumerator.Current => Current;

    public Face Current
    {
        get
        {
            try
            {
                dynamic value = teklaObject.Current;
                dynamic value_ = Face_.FromTSObject(value);
                return (Face)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Current), ex);
            }
        }

    }


    internal dynamic teklaObject;

    internal FaceEnumerator() { }

    public FaceEnumerator(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }


    public bool MoveNext()
    {

        try
        {
            bool result = (bool)teklaObject.MoveNext();

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
internal static class FaceEnumerator_
{
    public static dynamic GetTSObject(FaceEnumerator dynObject)
    {
        return dynObject is null ? null : dynObject.teklaObject;
    }

    public static FaceEnumerator FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        dynamic typeName = "Dynamic." + tsObject.GetType().FullName;
        dynamic type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        object[] parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        FaceEnumerator dynObject = (FaceEnumerator)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}