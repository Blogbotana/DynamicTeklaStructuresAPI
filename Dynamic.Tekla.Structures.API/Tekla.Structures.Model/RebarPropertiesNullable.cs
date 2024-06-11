using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;

public class RebarPropertiesNullable
{


    public string Size
    {
        get
        {
            try
            {
                return teklaObject.Size;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Size), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Size = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Size), ex);
            }
        }
    }

    public string Grade
    {
        get
        {
            try
            {
                return teklaObject.Grade;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Grade), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Grade = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Grade), ex);
            }
        }
    }

    public string Name
    {
        get
        {
            try
            {
                return teklaObject.Name;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Name = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex);
            }
        }
    }

    public System.Nullable<int> Class
    {
        get
        {
            try
            {
                return teklaObject.Class;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Class), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Class = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Class), ex);
            }
        }
    }

    public NumberingSeriesNullable NumberingSeries
    {
        get
        {
            try
            {
                var value = teklaObject.NumberingSeries;
                var value_ = NumberingSeriesNullable_.FromTSObject(value);
                return (NumberingSeriesNullable)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NumberingSeries), ex);
            }
        }
        set
        {
            try
            {
                var value_ = NumberingSeriesNullable_.GetTSObject(value);
                teklaObject.NumberingSeries = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NumberingSeries), ex);
            }
        }
    }

    public System.Nullable<double> BendingRadius
    {
        get
        {
            try
            {
                return teklaObject.BendingRadius;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BendingRadius), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.BendingRadius = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BendingRadius), ex);
            }
        }
    }


    internal dynamic teklaObject;

    public RebarPropertiesNullable()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarPropertiesNullable");
    }

    public RebarPropertiesNullable(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }





}

internal static class RebarPropertiesNullable_
{
    public static dynamic GetTSObject(RebarPropertiesNullable dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static RebarPropertiesNullable FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (RebarPropertiesNullable)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class RebarPropertiesNullableArray_
{
    public static dynamic GetTSObject(RebarPropertiesNullable[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(RebarPropertiesNullable_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static RebarPropertiesNullable[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<RebarPropertiesNullable>();
        foreach (var tsItem in tsArray)
        {
            list.Add(RebarPropertiesNullable_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

