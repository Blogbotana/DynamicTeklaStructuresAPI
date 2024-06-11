using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;


namespace Dynamic.Tekla.Structures.Model;

public class Offset
{


    public double Dx
    {
        get
        {
            try
            {
                return teklaObject.Dx;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Dx), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Dx = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Dx), ex);
            }
        }
    }

    public double Dy
    {
        get
        {
            try
            {
                return teklaObject.Dy;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Dy), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Dy = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Dy), ex);
            }
        }
    }

    public double Dz
    {
        get
        {
            try
            {
                return teklaObject.Dz;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Dz), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Dz = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Dz), ex);
            }
        }
    }


    internal dynamic teklaObject;

    public Offset()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Offset");
    }

    public Offset(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }





}

internal static class Offset_
{
    public static dynamic GetTSObject(Offset dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Offset FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Offset)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class OffsetArray_
{
    public static dynamic GetTSObject(Offset[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(Offset_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static Offset[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<Offset>();
        foreach (var tsItem in tsArray)
        {
            list.Add(Offset_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}



    
