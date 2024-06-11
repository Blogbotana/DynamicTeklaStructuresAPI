using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
public sealed class BoltArray : BoltGroup
{



    public BoltArray()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BoltArray");
    }
    
    public BoltArray(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }


    public bool AddBoltDistX(
        double DistX)
    {

        try
        {
            var result = (bool)teklaObject.AddBoltDistX(DistX);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddBoltDistX), ex);
        }
    }



    public bool AddBoltDistY(
        double DistY)
    {

        try
        {
            var result = (bool)teklaObject.AddBoltDistY(DistY);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AddBoltDistY), ex);
        }
    }



    public bool RemoveBoltDistX(
        int Index)
    {

        try
        {
            var result = (bool)teklaObject.RemoveBoltDistX(Index);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveBoltDistX), ex);
        }
    }



    public bool RemoveBoltDistY(
        int Index)
    {

        try
        {
            var result = (bool)teklaObject.RemoveBoltDistY(Index);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(RemoveBoltDistY), ex);
        }
    }



    public int GetBoltDistXCount()
    {

        try
        {
            var result = (int)teklaObject.GetBoltDistXCount();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetBoltDistXCount), ex);
        }
    }



    public int GetBoltDistYCount()
    {

        try
        {
            var result = (int)teklaObject.GetBoltDistYCount();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetBoltDistYCount), ex);
        }
    }



    public double GetBoltDistX(
        int Index)
    {

        try
        {
            var result = (double)teklaObject.GetBoltDistX(Index);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetBoltDistX), ex);
        }
    }



    public double GetBoltDistY(
        int Index)
    {

        try
        {
            var result = (double)teklaObject.GetBoltDistY(Index);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetBoltDistY), ex);
        }
    }



    public bool SetBoltDistX(
        int Index,
        double DistX)
    {
        try
        {
            var result = (bool)teklaObject.SetBoltDistX(Index, DistX);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetBoltDistX), ex);
        }
    }



    public bool SetBoltDistY(
        int Index,
        double DistY)
    {
        try
        {
            var result = (bool)teklaObject.SetBoltDistY(Index, DistY);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetBoltDistY), ex);
        }
    }






}

internal static class BoltArray_
{
    public static dynamic GetTSObject(BoltArray dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static BoltArray FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (BoltArray)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
