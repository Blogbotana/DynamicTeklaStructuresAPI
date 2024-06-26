using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;

namespace Dynamic.Tekla.Structures.Model.UI;


public class View
{


    public System.String CurrentRepresentation
    {
        get
        {
            try
            {
                if(TeklaProcess.TeklaFileVersion <= new Version("2016.1.0.0"))
                    return string.Empty;    

                return teklaObject.CurrentRepresentation;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CurrentRepresentation), ex);
            }
        }
        set
        {
            try
            {
                if (TeklaProcess.TeklaFileVersion <= new Version("2016.1.0.0"))
                    return;

                teklaObject.CurrentRepresentation = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CurrentRepresentation), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Identifier Identifier
    {
        get
        {
            try
            {
                var value = teklaObject.Identifier;
                var value_ = Dynamic.Tekla.Structures.Identifier_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Identifier)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Identifier), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value);
                teklaObject.Identifier = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Identifier), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem ViewCoordinateSystem
    {
        get
        {
            try
            {
                var value = teklaObject.ViewCoordinateSystem;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ViewCoordinateSystem), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(value);
                teklaObject.ViewCoordinateSystem = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ViewCoordinateSystem), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem DisplayCoordinateSystem
    {
        get
        {
            try
            {
                var value = teklaObject.DisplayCoordinateSystem;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DisplayCoordinateSystem), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.CoordinateSystem_.GetTSObject(value);
                teklaObject.DisplayCoordinateSystem = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DisplayCoordinateSystem), ex);
            }
        }
    }

    public System.String Name
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

    public Dynamic.Tekla.Structures.Geometry3d.AABB WorkArea
    {
        get
        {
            try
            {
                var value = teklaObject.WorkArea;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.AABB)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(WorkArea), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(value);
                teklaObject.WorkArea = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(WorkArea), ex);
            }
        }
    }

    public System.Double ViewDepthUp
    {
        get
        {
            try
            {
                return teklaObject.ViewDepthUp;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ViewDepthUp), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ViewDepthUp = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ViewDepthUp), ex);
            }
        }
    }

    public System.Double ViewDepthDown
    {
        get
        {
            try
            {
                return teklaObject.ViewDepthDown;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ViewDepthDown), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ViewDepthDown = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ViewDepthDown), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Model.UI.View.ViewProjectionType ViewProjection
    {
        get
        {
            try
            {
                var value = teklaObject.ViewProjection;
                var value_ = Dynamic.Tekla.Structures.Model.UI.View.ViewProjectionType_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Model.UI.View.ViewProjectionType)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ViewProjection), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Model.UI.View.ViewProjectionType_.GetTSObject(value);
                teklaObject.ViewProjection = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ViewProjection), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Model.UI.View.DisplayOrientationType DisplayType
    {
        get
        {
            try
            {
                var value = teklaObject.DisplayType;
                var value_ = Dynamic.Tekla.Structures.Model.UI.View.DisplayOrientationType_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Model.UI.View.DisplayOrientationType)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DisplayType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Model.UI.View.DisplayOrientationType_.GetTSObject(value);
                teklaObject.DisplayType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DisplayType), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Model.UI.View.ViewRenderingType ViewRendering
    {
        get
        {
            try
            {
                var value = teklaObject.ViewRendering;
                var value_ = Dynamic.Tekla.Structures.Model.UI.View.ViewRenderingType_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Model.UI.View.ViewRenderingType)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ViewRendering), ex);
            }
        }

    }

    public System.String ViewFilter
    {
        get
        {
            try
            {
                return teklaObject.ViewFilter;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ViewFilter), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ViewFilter = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ViewFilter), ex);
            }
        }
    }

    public System.Boolean SharedView
    {
        get
        {
            try
            {
                return teklaObject.SharedView;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SharedView), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.SharedView = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SharedView), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings VisibilitySettings
    {
        get
        {
            try
            {
                var value = teklaObject.VisibilitySettings;
                var value_ = Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(VisibilitySettings), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Model.UI.ViewVisibilitySettings_.GetTSObject(value);
                teklaObject.VisibilitySettings = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(VisibilitySettings), ex);
            }
        }
    }


    internal dynamic teklaObject;

    public View()
    {
        this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.View");
    }
    
    public View(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        this.teklaObject = tsObject;
    }


    public System.Boolean Insert()
    {

        try
        {
            var result = (System.Boolean)teklaObject.Insert();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Insert), ex);
        }
    }



    public System.Boolean Modify()
    {

        try
        {
            var result = (System.Boolean)teklaObject.Modify();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Modify), ex);
        }
    }



    public System.Boolean Select()
    {

        try
        {
            var result = (System.Boolean)teklaObject.Select();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
        }
    }



    public System.Boolean Delete()
    {

        try
        {
            var result = (System.Boolean)teklaObject.Delete();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Delete), ex);
        }
    }



    public System.Boolean IsPerspectiveViewProjection()
    {

        try
        {
            var result = (System.Boolean)teklaObject.IsPerspectiveViewProjection();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsPerspectiveViewProjection), ex);
        }
    }



    public System.Boolean IsVisible()
    {

        try
        {
            var result = (System.Boolean)teklaObject.IsVisible();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsVisible), ex);
        }
    }



    public Dynamic.Tekla.Structures.Model.UI.ClipPlaneCollection GetClipPlanes()
    {

        try
        {
            var result = teklaObject.GetClipPlanes();

            var _result = Dynamic.Tekla.Structures.Model.UI.ClipPlaneCollection_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetClipPlanes), ex);
        }
    }





    public enum ViewProjectionType
    {
        ORTHOGONAL_PROJECTION,
        PERSPECTIVE_PROJECTION
    }

    internal static class ViewProjectionType_
    {
        public static dynamic GetTSObject(ViewProjectionType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.View.ViewProjectionType").GetType();

            switch (dynEnum)
            {
                case ViewProjectionType.ORTHOGONAL_PROJECTION:
                    return System.Enum.Parse(tsType, "ORTHOGONAL_PROJECTION");
                case ViewProjectionType.PERSPECTIVE_PROJECTION:
                    return System.Enum.Parse(tsType, "PERSPECTIVE_PROJECTION");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static ViewProjectionType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("ORTHOGONAL_PROJECTION", System.StringComparison.InvariantCulture))
                return ViewProjectionType.ORTHOGONAL_PROJECTION;
            else if (tsEnumValue.Equals("PERSPECTIVE_PROJECTION", System.StringComparison.InvariantCulture))
                return ViewProjectionType.PERSPECTIVE_PROJECTION;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum DisplayOrientationType
    {
        DISPLAY_VIEW_PLANE,
        DISPLAY_3D
    }

    internal static class DisplayOrientationType_
    {
        public static dynamic GetTSObject(DisplayOrientationType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.View.DisplayOrientationType").GetType();

            switch (dynEnum)
            {
                case DisplayOrientationType.DISPLAY_VIEW_PLANE:
                    return System.Enum.Parse(tsType, "DISPLAY_VIEW_PLANE");
                case DisplayOrientationType.DISPLAY_3D:
                    return System.Enum.Parse(tsType, "DISPLAY_3D");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static DisplayOrientationType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("DISPLAY_VIEW_PLANE", System.StringComparison.InvariantCulture))
                return DisplayOrientationType.DISPLAY_VIEW_PLANE;
            else if (tsEnumValue.Equals("DISPLAY_3D", System.StringComparison.InvariantCulture))
                return DisplayOrientationType.DISPLAY_3D;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }


    public enum ViewRenderingType
    {
        WIREFRAME_VIEW,
        RENDERED_VIEW
    }

    internal static class ViewRenderingType_
    {
        public static dynamic GetTSObject(ViewRenderingType dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.UI.View.ViewRenderingType").GetType();

            switch (dynEnum)
            {
                case ViewRenderingType.WIREFRAME_VIEW:
                    return System.Enum.Parse(tsType, "WIREFRAME_VIEW");
                case ViewRenderingType.RENDERED_VIEW:
                    return System.Enum.Parse(tsType, "RENDERED_VIEW");

                default:
                    throw new DynamicAPIException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }

        public static ViewRenderingType FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);

            if (tsEnumValue.Equals("WIREFRAME_VIEW", System.StringComparison.InvariantCulture))
                return ViewRenderingType.WIREFRAME_VIEW;
            else if (tsEnumValue.Equals("RENDERED_VIEW", System.StringComparison.InvariantCulture))
                return ViewRenderingType.RENDERED_VIEW;

            else
                throw new DynamicAPIException(tsEnumValue + "- enum value is not implemented");

        }
    }



}

internal static class View_
{
    public static dynamic GetTSObject(View dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static View FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Model.UI.View)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ViewArray_
{
    public static dynamic GetTSObject(View[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(View_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static View[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<View>();
        foreach (var tsItem in tsArray)
        {
            list.Add(View_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

