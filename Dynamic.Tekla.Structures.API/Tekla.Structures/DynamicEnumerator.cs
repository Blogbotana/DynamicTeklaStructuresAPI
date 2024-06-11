using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;
using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace Dynamic.Tekla.Structures;
public class DynamicEnumerator : IEnumerator
{
    readonly IEnumerator teklaEnumerator;

    public DynamicEnumerator(IEnumerator teklaEnumerator)
    {
        this.teklaEnumerator = teklaEnumerator;
    }
    public object Current
    {
        get
        {
            var teklaCurrent = teklaEnumerator.Current;
            if (teklaCurrent is null) return null;

            var typeName = "Dynamic." + teklaCurrent.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

            var parameters = new object[2];
            parameters[0] = teklaCurrent;
            parameters[1] = new System.DateTime();
            var dynObject = System.Activator.CreateInstance(type, parameters);
            PropertyInvoker.SetInstancePropertyOrFieldValue(dynObject, "teklaObject", teklaCurrent);
            return dynObject;
        }
    }

    public bool MoveNext()
    {
        try
        {
            var result = teklaEnumerator.MoveNext();
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
            teklaEnumerator.Reset();
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Reset), ex);
        }
    }
}
