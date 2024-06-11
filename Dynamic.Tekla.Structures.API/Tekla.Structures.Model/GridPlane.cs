using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;

namespace Dynamic.Tekla.Structures.Model;


public class GridPlane : GridSurface
{


    public Plane Plane
    {
        get
        {
            try
            {
                var value = teklaObject.Plane;
                var value_ = Plane_.FromTSObject(value);
                return (Plane)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Plane), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Plane_.GetTSObject(value);
                teklaObject.Plane = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Plane), ex);
            }
        }
    }

    public Grid Father
    {
        get
        {
            if (TeklaProcess.TeklaFileVersion > new Version("2018.1.0.0"))
                return Parent as Grid;

            try
            {
                var value = teklaObject.Father;
                var value_ = Plane_.FromTSObject(value);
                return (Grid)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Father), ex);
            }
        }
        set
        {
            if (TeklaProcess.TeklaFileVersion > new Version("2018.1.0.0"))
            {
                Parent = value;
                return;
            }

            try
            {
                var value_ = Grid_.GetTSObject(value);
                teklaObject.Father = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Father), ex);
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




    public GridPlane()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.GridPlane");
    }

    public GridPlane(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public GridPlane(Plane Plane, string Label)
    {
        var args = new object[2];
        args[0] = Plane_.GetTSObject(Plane);
        args[1] = Label;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.GridPlane", args);
    }





}

internal static class GridPlane_
{
    public static dynamic GetTSObject(GridPlane dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static GridPlane FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (GridPlane)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class GridPlaneArray_
{
    public static dynamic GetTSObject(GridPlane[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(GridPlane_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static GridPlane[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<GridPlane>();
        foreach (var tsItem in tsArray)
        {
            list.Add(GridPlane_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

