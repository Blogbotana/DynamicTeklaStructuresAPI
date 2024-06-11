using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections;

namespace Dynamic.Tekla.Structures.Model.UI;


public class PickInput : ICollection, IEnumerable
{


    public System.Int32 Count
    {
        get
        {
            try
            {
                return teklaObject.Count;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Count), ex);
            }
        }

    }

    public System.Boolean IsSynchronized
    {
        get
        {
            try
            {
                return teklaObject.IsSynchronized;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsSynchronized), ex);
            }
        }

    }

    public object SyncRoot
    {
        get
        {
            try
            {
                return teklaObject.SyncRoot;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SyncRoot), ex);
            }
        }

    }


    internal dynamic teklaObject;

    internal PickInput() { }
    
    public PickInput(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        this.teklaObject = tsObject;
    }

    public IEnumerator GetEnumerator()
    {
        try
        {
            var teklaEnumerator = (IEnumerator)teklaObject.GetEnumerator();
            return new DynamicEnumerator(teklaEnumerator);
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetEnumerator), ex);
        }
    }

    public void CopyTo(Array array, int index)
    {
        if (array == null)
        {
            return;
        }
        IEnumerator enumerator = GetEnumerator();
        try
        {
            while (enumerator.MoveNext())
            {
                InputItem inputItem = (InputItem)enumerator.Current;
                if (inputItem != null && index < array.Length)
                {
                    array.SetValue(inputItem, index++);
                }
            }
        }
        finally
        {
            IDisposable disposable = enumerator as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
            }
        }
    }
}

internal static class PickInput_
{
    public static dynamic GetTSObject(PickInput dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static PickInput FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Model.UI.PickInput)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class PickInputArray_
{
    public static dynamic GetTSObject(PickInput[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(PickInput_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static PickInput[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<PickInput>();
        foreach (var tsItem in tsArray)
        {
            list.Add(PickInput_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

