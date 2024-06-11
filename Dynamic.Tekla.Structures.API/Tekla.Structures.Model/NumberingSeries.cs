using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
public sealed class NumberingSeries
{
    public string Prefix
    {
        get
        {
            try
            {
                return teklaObject.Prefix;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Prefix), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Prefix = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Prefix), ex);
            }
        }
    }

    public int StartNumber
    {
        get
        {
            try
            {
                return teklaObject.StartNumber;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartNumber), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.StartNumber = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartNumber), ex);
            }
        }
    }


    internal dynamic teklaObject;

    public NumberingSeries()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.NumberingSeries");
    }
   
    public NumberingSeries(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public NumberingSeries(string Prefix, int Number)
    {
        var args = new object[2];
        args[0] = Prefix;
        args[1] = Number;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.NumberingSeries", args);
    }





}

internal static class NumberingSeries_
{
    public static dynamic GetTSObject(NumberingSeries dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static NumberingSeries FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (NumberingSeries)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

