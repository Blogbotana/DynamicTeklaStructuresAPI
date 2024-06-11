using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;

namespace Dynamic.Tekla.Structures.Geometry3d;
public class Line
{
    public Point Origin
    {
        get
        {
            try
            {
                var value = teklaObject.Origin;
                var value_ = Point_.FromTSObject(value);
                return (Point)value_;
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
                var value_ = Point_.GetTSObject(value);
                teklaObject.Origin = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Origin), ex);
            }
        }
    }
    public Vector Direction
    {
        get
        {
            try
            {
                var value = teklaObject.Direction;
                var value_ = Vector_.FromTSObject(value);
                return (Vector)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Direction), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Vector_.GetTSObject(value);
                teklaObject.Direction = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Direction), ex);
            }
        }
    }
    internal dynamic teklaObject;
    public Line()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Line");
    }

    public Line(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public Line(Point p1, Point p2)
    {
        var args = new object[2];
        args[0] = Point_.GetTSObject(p1);
        args[1] = Point_.GetTSObject(p2);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Line", args);
    }
    public Line(Point Point, Vector Direction)
    {
        var args = new object[2];
        args[0] = Point_.GetTSObject(Point);
        args[1] = Vector_.GetTSObject(Direction);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Line", args);
    }
    public Line(LineSegment LineSegment)
    {
        var args = new object[1];
        args[0] = LineSegment_.GetTSObject(LineSegment);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Line", args);
    }
}

internal static class Line_
{
    public static dynamic GetTSObject(Line dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Line FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Geometry3d.Line)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}