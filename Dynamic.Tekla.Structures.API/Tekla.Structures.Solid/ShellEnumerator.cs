using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Solid;
public sealed class ShellEnumerator : IEnumerator
{
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
    internal dynamic teklaObject;

    internal ShellEnumerator() { }
   
    public ShellEnumerator(dynamic tsObject, DateTime nonConflictParameter)
    {
        this.teklaObject = tsObject;
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
internal static class ShellEnumerator_
{
    public static dynamic GetTSObject(ShellEnumerator dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ShellEnumerator FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Solid.ShellEnumerator)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
