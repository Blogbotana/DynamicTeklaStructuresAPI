using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;


public class Grid : GridBase
{

    public string CoordinateX
    {
        get
        {
            try
            {
                return teklaObject.CoordinateX;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CoordinateX), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.CoordinateX = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CoordinateX), ex);
            }
        }
    }

    public string CoordinateY
    {
        get
        {
            try
            {
                return teklaObject.CoordinateY;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CoordinateY), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.CoordinateY = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CoordinateY), ex);
            }
        }
    }

    public string CoordinateZ
    {
        get
        {
            try
            {
                return teklaObject.CoordinateZ;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CoordinateZ), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.CoordinateZ = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CoordinateZ), ex);
            }
        }
    }

    public string LabelX
    {
        get
        {
            try
            {
                return teklaObject.LabelX;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LabelX), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.LabelX = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LabelX), ex);
            }
        }
    }

    public string LabelY
    {
        get
        {
            try
            {
                return teklaObject.LabelY;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LabelY), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.LabelY = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LabelY), ex);
            }
        }
    }

    public string LabelZ
    {
        get
        {
            try
            {
                return teklaObject.LabelZ;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LabelZ), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.LabelZ = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LabelZ), ex);
            }
        }
    }

    public double ExtensionLeftX
    {
        get
        {
            try
            {
                return teklaObject.ExtensionLeftX;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionLeftX), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ExtensionLeftX = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionLeftX), ex);
            }
        }
    }

    public double ExtensionLeftY
    {
        get
        {
            try
            {
                return teklaObject.ExtensionLeftY;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionLeftY), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ExtensionLeftY = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionLeftY), ex);
            }
        }
    }

    public double ExtensionLeftZ
    {
        get
        {
            try
            {
                return teklaObject.ExtensionLeftZ;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionLeftZ), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ExtensionLeftZ = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionLeftZ), ex);
            }
        }
    }

    public double ExtensionRightX
    {
        get
        {
            try
            {
                return teklaObject.ExtensionRightX;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionRightX), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ExtensionRightX = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionRightX), ex);
            }
        }
    }

    public double ExtensionRightY
    {
        get
        {
            try
            {
                return teklaObject.ExtensionRightY;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionRightY), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ExtensionRightY = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionRightY), ex);
            }
        }
    }

    public double ExtensionRightZ
    {
        get
        {
            try
            {
                return teklaObject.ExtensionRightZ;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionRightZ), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ExtensionRightZ = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionRightZ), ex);
            }
        }
    }

    public double ExtensionForMagneticArea
    {
        get
        {
            try
            {
                return teklaObject.ExtensionForMagneticArea;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionForMagneticArea), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ExtensionForMagneticArea = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ExtensionForMagneticArea), ex);
            }
        }
    }

    public int Color
    {
        get
        {
            try
            {
                return teklaObject.Color;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Color), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Color = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Color), ex);
            }
        }
    }


    public Grid()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Grid");
    }

    public Grid(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }

}

internal static class Grid_
{
    public static dynamic GetTSObject(Grid dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Grid FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Grid)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class GridArray_
{
    public static dynamic GetTSObject(Grid[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(Grid_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static Grid[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<Grid>();
        foreach (var tsItem in tsArray)
        {
            list.Add(Grid_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

