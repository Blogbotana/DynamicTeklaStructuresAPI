using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;

namespace Dynamic.Tekla.Structures.Model;


public abstract class GridSurface  : ModelObject
{


    public GridBase Parent
    {
        get
        {
            try
            {
            var value = teklaObject.Parent;
            var value_ = GridBase_.FromTSObject(value);
            return (GridBase) value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Parent), ex); 
            }
        }
        set
        {
            try
            {
            var value_ = GridBase_.GetTSObject(value);
            teklaObject.Parent = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Parent), ex); 
            }
        }
    }

    public string Label
    {
        get
        {
            try
            {
            return teklaObject.Label;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Label), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.Label = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Label), ex); 
            }
        }
    }

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

    public double ExtensionLeft
    {
        get
        {
            try
            {
            return teklaObject.ExtensionLeft;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionLeft), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.ExtensionLeft = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionLeft), ex); 
            }
        }
    }

    public double ExtensionRight
    {
        get
        {
            try
            {
            return teklaObject.ExtensionRight;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionRight), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.ExtensionRight = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionRight), ex); 
            }
        }
    }

    public double ExtensionBelow
    {
        get
        {
            try
            {
            return teklaObject.ExtensionBelow;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionBelow), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.ExtensionBelow = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionBelow), ex); 
            }
        }
    }

    public double ExtensionAbove
    {
        get
        {
            try
            {
            return teklaObject.ExtensionAbove;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionAbove), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.ExtensionAbove = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionAbove), ex); 
            }
        }
    }

    public bool DrawingVisibility
    {
        get
        {
            try
            {
            return teklaObject.DrawingVisibility;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawingVisibility), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.DrawingVisibility = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DrawingVisibility), ex); 
            }
        }
    }

    public bool IsManual
    {
        get
        {
            try
            {
            return teklaObject.IsManual;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsManual), ex); 
            }
        }
        set
        {
            try
            {
            teklaObject.IsManual = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsManual), ex); 
            }
        }
    }
    

    






}

internal static class GridSurface_
{
    public static dynamic GetTSObject(GridSurface dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static GridSurface FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
        
        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (GridSurface)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class GridSurfaceArray_
{
    public static dynamic GetTSObject(GridSurface[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach(var dynItem in dynArray)
        {
            list.Add(GridSurface_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static GridSurface[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<GridSurface>();
        foreach(var tsItem in tsArray)
        {
            list.Add(GridSurface_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

