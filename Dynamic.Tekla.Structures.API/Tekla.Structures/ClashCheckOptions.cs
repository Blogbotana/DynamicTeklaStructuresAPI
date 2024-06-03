using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;

namespace Dynamic.Tekla.Structures;
/// <summary>
/// The ClashCheckOptions class represents the clash check options.
/// </summary>
public class ClashCheckOptions
{
    public double BoltHeadDiameter
    {
        get
        {
            try
            {
                return teklaObject.BoltHeadDiameter;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoltHeadDiameter), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.BoltHeadDiameter = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoltHeadDiameter), ex);
            }
        }
    }

    public double NutThickness
    {
        get
        {
            try
            {
                return teklaObject.NutThickness;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NutThickness), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.NutThickness = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NutThickness), ex);
            }
        }
    }

    internal dynamic teklaObject;
    public ClashCheckOptions()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.ClashCheckOptions");
    }

    public ClashCheckOptions(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }


}
internal static class ClashCheckOptions_
{
    public static dynamic GetTSObject(ClashCheckOptions dynObject)
    {
        return dynObject is null ? null : dynObject.teklaObject;
    }

    public static ClashCheckOptions FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        dynamic typeName = "Dynamic." + tsObject.GetType().FullName;
        dynamic type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        object[] parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        ClashCheckOptions dynObject = (ClashCheckOptions)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
