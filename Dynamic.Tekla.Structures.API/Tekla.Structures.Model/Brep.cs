using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
public sealed class Brep : Part
{

    public Dynamic.Tekla.Structures.Geometry3d.Point StartPoint
    {
        get
        {
            try
            {
                var value = teklaObject.StartPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPoint), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.StartPoint = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPoint), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Point EndPoint
    {
        get
        {
            try
            {
                var value = teklaObject.EndPoint;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPoint), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.EndPoint = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPoint), ex);
            }
        }
    }

    public Offset StartPointOffset
    {
        get
        {
            try
            {
                var value = teklaObject.StartPointOffset;
                var value_ = Offset_.FromTSObject(value);
                return (Offset)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPointOffset), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Offset_.GetTSObject(value);
                teklaObject.StartPointOffset = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPointOffset), ex);
            }
        }
    }

    public Offset EndPointOffset
    {
        get
        {
            try
            {
                var value = teklaObject.EndPointOffset;
                var value_ = Offset_.FromTSObject(value);
                return (Offset)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPointOffset), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Offset_.GetTSObject(value);
                teklaObject.EndPointOffset = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPointOffset), ex);
            }
        }
    }




    public Brep()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Brep");
    }
    
    public Brep(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public Brep(Dynamic.Tekla.Structures.Geometry3d.Point startPoint, Dynamic.Tekla.Structures.Geometry3d.Point endPoint)
    {
        var args = new object[2];
        args[0] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(startPoint);
        args[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(endPoint);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Brep", args);
    }





}

internal static class Brep_
{
    public static dynamic GetTSObject(Brep dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Brep FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Brep)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

