using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
public sealed class BoltCircle : BoltGroup
{
    public double NumberOfBolts
    {
        get
        {
            try
            {
                return teklaObject.NumberOfBolts;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NumberOfBolts), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.NumberOfBolts = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NumberOfBolts), ex);
            }
        }
    }

    public double Diameter
    {
        get
        {
            try
            {
                return teklaObject.Diameter;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Diameter), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Diameter = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Diameter), ex);
            }
        }
    }




    public BoltCircle()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.BoltCircle");
    }
    
    public BoltCircle(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }





}

internal static class BoltCircle_
{
    public static dynamic GetTSObject(BoltCircle dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static BoltCircle FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (BoltCircle)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
