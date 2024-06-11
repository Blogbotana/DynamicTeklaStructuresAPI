using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public abstract class GridBase  : ModelObject
{


    public bool IsMagnetic
    {
        get
        {
            try
            {
            return teklaObject.IsMagnetic;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsMagnetic), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.IsMagnetic = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsMagnetic), ex); 
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

    public int FontSize
    {
        get
        {
            try
            {
            return teklaObject.FontSize;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FontSize), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.FontSize = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FontSize), ex); 
            }
        }
    }

    public System.Drawing.Color FontColor
    {
        get
        {
            try
            {
            return teklaObject.FontColor;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FontColor), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.FontColor = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(FontColor), ex); 
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point Origin
    {
        get
        {
            try
            {
            var value = teklaObject.Origin;
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
            return (Dynamic.Tekla.Structures.Geometry3d.Point) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Origin), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
            teklaObject.Origin = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Origin), ex); 
            }
        }
    }
    

    






}

internal static class GridBase_
{
    public static dynamic GetTSObject(GridBase dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static GridBase FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (GridBase)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class GridBaseArray_
{
    public static dynamic GetTSObject(GridBase[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(GridBase_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static GridBase[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<GridBase>();
        foreach(var tsItem in tsArray)
        {
            list.Add(GridBase_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

