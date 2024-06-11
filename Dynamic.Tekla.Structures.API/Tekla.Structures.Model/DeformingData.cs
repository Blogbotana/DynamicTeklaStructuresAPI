using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public  class DeformingData 
{


    public double Angle
    {
        get
        {
            try
            {
            return teklaObject.Angle;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Angle), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.Angle = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Angle), ex); 
            }
        }
    }

    public double Angle2
    {
        get
        {
            try
            {
            return teklaObject.Angle2;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Angle2), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.Angle2 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Angle2), ex); 
            }
        }
    }

    public double Cambering
    {
        get
        {
            try
            {
            return teklaObject.Cambering;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Cambering), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.Cambering = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Cambering), ex); 
            }
        }
    }

    public double Shortening
    {
        get
        {
            try
            {
            return teklaObject.Shortening;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Shortening), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.Shortening = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Shortening), ex); 
            }
        }
    }
    

    internal dynamic teklaObject;

		public DeformingData()
		{
			teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.DeformingData");
		}
		
		public DeformingData(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			teklaObject = tsObject;
		}





}

internal static class DeformingData_
{
    public static dynamic GetTSObject(DeformingData dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static DeformingData FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (DeformingData)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class DeformingDataArray_
{
    public static dynamic GetTSObject(DeformingData[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(DeformingData_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static DeformingData[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<DeformingData>();
        foreach(var tsItem in tsArray)
        {
            list.Add(DeformingData_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

