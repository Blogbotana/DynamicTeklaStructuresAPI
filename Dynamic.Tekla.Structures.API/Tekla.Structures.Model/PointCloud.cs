using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dynamic.Tekla.Structures.Internal.Invoker;
using Dynamic.Tekla.Structures.Internal.Converters;

namespace Dynamic.Tekla.Structures.Model;

public class PointCloud
{


    public System.Guid Guid
    {
        get
        {
            try
            {
                return teklaObject.Guid;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Guid), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Guid = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Guid), ex);
            }
        }
    }

    public string OriginalPath
    {
        get
        {
            try
            {
                return teklaObject.OriginalPath;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OriginalPath), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.OriginalPath = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OriginalPath), ex);
            }
        }
    }

    public string Url
    {
        get
        {
            try
            {
                return teklaObject.Url;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Url), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Url = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Url), ex);
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

    public System.Guid LocationBy
    {
        get
        {
            try
            {
                return teklaObject.LocationBy;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LocationBy), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.LocationBy = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(LocationBy), ex);
            }
        }
    }

    public bool UseAutoCreatedBasePoint
    {
        get
        {
            try
            {
                return teklaObject.UseAutoCreatedBasePoint;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(UseAutoCreatedBasePoint), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.UseAutoCreatedBasePoint = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(UseAutoCreatedBasePoint), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.AABB BoundingBox
    {
        get
        {
            try
            {
                var value = teklaObject.BoundingBox;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.AABB_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.AABB)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoundingBox), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.AABB_.GetTSObject(value);
                teklaObject.BoundingBox = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(BoundingBox), ex);
            }
        }
    }

    public double Scale
    {
        get
        {
            try
            {
                return teklaObject.Scale;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Scale), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Scale = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Scale), ex);
            }
        }
    }

    public double OffsetX
    {
        get
        {
            try
            {
                return teklaObject.OffsetX;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OffsetX), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.OffsetX = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OffsetX), ex);
            }
        }
    }

    public double OffsetY
    {
        get
        {
            try
            {
                return teklaObject.OffsetY;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OffsetY), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.OffsetY = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OffsetY), ex);
            }
        }
    }

    public double OffsetZ
    {
        get
        {
            try
            {
                return teklaObject.OffsetZ;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OffsetZ), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.OffsetZ = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OffsetZ), ex);
            }
        }
    }

    public double RotationZ
    {
        get
        {
            try
            {
                return teklaObject.RotationZ;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RotationZ), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.RotationZ = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(RotationZ), ex);
            }
        }
    }


    internal dynamic teklaObject;

    public PointCloud()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PointCloud");
    }

    public PointCloud(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }


    public bool Attach()
    {

        try
        {
            var result = (bool)teklaObject.Attach();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Attach), ex);
        }
    }



    public bool AttachComplete()
    {

        try
        {
            var result = (bool)teklaObject.AttachComplete();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AttachComplete), ex);
        }
    }



    public bool Detach()
    {

        try
        {
            var result = (bool)teklaObject.Detach();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Detach), ex);
        }
    }



    public bool Select()
    {

        try
        {
            var result = (bool)teklaObject.Select();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Select), ex);
        }
    }



    //public bool SetVisibility(
    //    System.Collections.Generic.List<UI.View> views_,
    //    bool visible)
    //{
    //    var views = ListConverter.ToTSObjects(views_);
    //    try
    //    {
    //        var result = (bool)teklaObject.SetVisibility(views, visible);

    //        return result;
    //    }
    //    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    //    {
    //        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetVisibility), ex);
    //    }
    //}



    //public System.Collections.Generic.List<UI.View> GetVisibleInViews()
    //{

    //    try
    //    {
    //        var result = teklaObject.GetVisibleInViews();

    //        var _result = ListConverter.FromTSObjects<UI.View>(result);
    //        return _result;
    //    }
    //    catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
    //    {
    //        throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetVisibleInViews), ex);
    //    }
    //}



    public static System.Collections.Generic.List<PointCloud> GetPointClouds()
    {
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.PointCloud", "GetPointClouds");
        var _result = ListConverter.FromTSObjects<PointCloud>(result);
        return _result;
    }






}

internal static class PointCloud_
{
    public static dynamic GetTSObject(PointCloud dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static PointCloud FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (PointCloud)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}


