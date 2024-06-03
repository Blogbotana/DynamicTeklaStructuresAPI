using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;
using System;

namespace Dynamic.Tekla.Structures.Geometry3d;
/// <summary>
/// The Point class represents a single position in 3D space.
/// </summary>
public class Point
{
    public double X
    {
        get
        {
            try
            {
                return teklaObject.X;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(X), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.X = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(X), ex);
            }
        }
    }

    public double Y
    {
        get
        {
            try
            {
                return teklaObject.Y;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Y), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Y = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Y), ex);
            }
        }
    }

    public double Z
    {
        get
        {
            try
            {
                return teklaObject.Z;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Z), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Z = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Z), ex);
            }
        }
    }
    public static readonly double EPSILON_SQUARED = 0.0001;
    public static readonly int HASH_SEED = 69069;

    internal dynamic teklaObject;

    public Point()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Point");
    }
    public Point(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public Point(double X, double Y, double Z)
    {
        object[] args = new object[3];
        args[0] = X;
        args[1] = Y;
        args[2] = Z;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Point", args);
    }
    public Point(double X, double Y)
    {
        object[] args = new object[2];
        args[0] = X;
        args[1] = Y;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Point", args);
    }
    public Point(Point Point)
    {
        object[] args = new object[1];
        args[0] = Point_.GetTSObject(Point);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Point", args);
    }


    public void Zero()
    {
        try
        {
            teklaObject.Zero();
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Zero), ex);
        }
    }
    public void Translate(
            double X,
            double Y,
            double Z)
    {

        try
        {
            teklaObject.Translate(X, Y, Z);


        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Translate), ex);
        }
    }



    public static bool AreEqual(
            Point Point1_,
            Point Point2_)
    {
        dynamic Point1 = Point_.GetTSObject(Point1_);
        dynamic Point2 = Point_.GetTSObject(Point2_);
        bool result = (bool)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Geometry3d.Point", "AreEqual", Point1, Point2);
        return result;
    }



    public int CompareTo(
            object obj)
    {

        try
        {
            int result = (int)teklaObject.CompareTo(obj);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CompareTo), ex);
        }
    }



    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
    }
    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
    }
    public static bool operator ==(Point p1, Point p2)
    {
        bool flag = p1 is null;
        bool flag2 = p2 is null;
        if (flag && flag2)
        {
            return true;
        }

        if (flag || flag2)
        {
            return false;
        }

        return ((p1.X - p2.X) * (p1.X - p2.X)) + ((p1.Y - p2.Y) * (p1.Y - p2.Y)) + ((p1.Z - p2.Z) * (p1.Z - p2.Z)) <= EPSILON_SQUARED;
    }
    public static bool operator !=(Point p1, Point p2)
    {
        return !(p1 == p2);
    }
}

internal static class Point_
{
    public static dynamic GetTSObject(Point dynObject)
    {
        return dynObject is null ? null : dynObject.teklaObject;
    }

    public static Point FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        dynamic typeName = "Dynamic." + tsObject.GetType().FullName;
        dynamic type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        object[] parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        Point dynObject = (Point)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
internal static class PointArray_
{
    public static dynamic GetTSObject(Point[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(Point_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static Point[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<Point>();
        foreach (var tsItem in tsArray)
        {
            list.Add(Point_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}
