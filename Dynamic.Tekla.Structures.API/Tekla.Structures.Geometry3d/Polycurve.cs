using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Dynamic.Tekla.Structures.Geometry3d;
public class Polycurve : IEnumerable<ICurve>, IEnumerable, ICurve, IEquatable<ICurve>
{
    public Point StartPoint
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

    }

    public Point EndPoint
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

    }
    public double Length
    {
        get
        {
            try
            {
                return teklaObject.Length;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Length), ex);
            }
        }

    }
    public IEnumerator<ICurve> GetEnumerator()
    {
        try
        {
            return (IEnumerator<ICurve>)(teklaObject.GetEnumerator());
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(GetEnumerator), ex);
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public ICurve Clone()
    {
        try
        {
            dynamic newClone = teklaObject.Clone();
            return Polycurve_.FromTSObject(newClone);
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(GetEnumerator), ex);
        }
    }

    public bool Equals(ICurve other)
    {
        Polycurve polycurve = other as Polycurve;
        if (polycurve != null)
        {
            var _polycurve = Polycurve_.GetTSObject(polycurve);
            return (bool)teklaObject.Equals(_polycurve);
        }
        return false;
    }

    internal dynamic teklaObject;

    public Polycurve()
    {
        this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Polycurve");
    }

    public Polycurve(dynamic tsObject, DateTime nonConflictParameter)
    {
        this.teklaObject = tsObject;
    }
    public Polycurve(Dynamic.Tekla.Structures.Geometry3d.PolyLine polyLine)
    {
        var args = new object[1];
        args[0] = Dynamic.Tekla.Structures.Geometry3d.PolyLine_.GetTSObject(polyLine);
        this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Polycurve", args);
    }
}
internal static class Polycurve_
{
    public static dynamic GetTSObject(Polycurve dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Polycurve FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Polycurve)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}