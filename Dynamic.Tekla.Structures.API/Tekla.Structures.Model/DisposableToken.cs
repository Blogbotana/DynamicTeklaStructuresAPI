using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;
using System;

namespace Dynamic.Tekla.Structures.Model;


public class DisposableToken : IDisposable
{


    public static DisposableToken None
    {
        get
        {
            var value = PropertyInvoker.GetStaticPropertyOrFieldValue("Tekla.Structures.Model.DisposableToken", "None");
            var value_ = DisposableToken_.FromTSObject(value);
            return (DisposableToken)value_;
        }

    }

    internal dynamic teklaObject;

    internal DisposableToken() { }

    public DisposableToken(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public DisposableToken(System.Action disposed)
    {
        var args = new object[1];
        args[0] = disposed;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.DisposableToken", args);
    }


    public void Dispose()
    {

        try
        {
            teklaObject.Dispose();


        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Dispose), ex);
        }
    }



    public static DisposableToken operator +(DisposableToken o1, System.IDisposable o2)
    {
        if (o1 is null) throw new System.ArgumentNullException("o1");
        if (o2 is null) throw new System.ArgumentNullException("o2");
        var o1Tek = DisposableToken_.GetTSObject(o1);
        var o2Tek = o2;
        return DisposableToken_.FromTSObject(o1Tek + o2Tek);
    }



}

internal static class DisposableToken_
{
    public static dynamic GetTSObject(DisposableToken dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static DisposableToken FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (DisposableToken)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class DisposableTokenArray_
{
    public static dynamic GetTSObject(DisposableToken[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(DisposableToken_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static DisposableToken[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<DisposableToken>();
        foreach (var tsItem in tsArray)
        {
            list.Add(DisposableToken_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

