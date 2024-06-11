using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
public sealed class BoltXYList : BoltGroup
{



    public BoltXYList()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BoltXYList");
    }
    
    public BoltXYList(dynamic tsObject, System.DateTime nonConflictParameter)
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






}

internal static class BoltXYList_
{
    public static dynamic GetTSObject(BoltXYList dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static BoltXYList FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (BoltXYList)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

