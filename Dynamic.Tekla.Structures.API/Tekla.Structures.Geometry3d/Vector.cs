using Dynamic.Tekla.Structures.Internal;
using System;

namespace Dynamic.Tekla.Structures.Geometry3d;
/// <summary>
/// The Vector class defines a direction and magnitude from the current origin.
/// </summary>
public class Vector : Point
{
    private static readonly double EPSILON = 1E-06;

    public Vector()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Vector");
    }

    public Vector(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public Vector(double X, double Y, double Z)
    {
        object[] args = new object[3];
        args[0] = X;
        args[1] = Y;
        args[2] = Z;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Vector", args);
    }
    public Vector(Point Point)
    {
        object[] args = new object[1];
        args[0] = Point_.GetTSObject(Point);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Vector", args);
    }
    public double Normalize()
    {
        return Normalize(1.0);
    }
    public double Normalize(double NewLength)
    {
        double num = GetLength();
        double ePSILON = EPSILON;
        if (num > ePSILON)
        {
            X = X / num * NewLength;
            Y = Y / num * NewLength;
            Z = Z / num * NewLength;
            num = NewLength;
        }

        return num;
    }
    public double GetLength()
    {
        return Math.Sqrt((X * X) + (Y * Y) + (Z * Z));
    }

    public double GetAngleBetween(Vector Vector)
    {
        Vector normal = GetNormal();
        Vector normal2 = Vector.GetNormal();
        if (Math.Abs(normal.Dot(normal2) - 1.0) <= EPSILON)
        {
            return 0.0;
        }

        return Math.Abs(normal.Dot(normal2) + 1.0) <= EPSILON ? Math.PI : Math.Acos(normal.Dot(normal2));
    }
    public Vector GetNormal()
    {
        Vector vector = new(this);
        _ = vector.Normalize();
        return vector;
    }
    public double Dot(Vector Vector)
    {
        return (X * Vector.X) + (Y * Vector.Y) + (Z * Vector.Z);
    }
    public static double Dot(Vector Vector1, Vector Vector2)
    {
        return Vector1.Dot(Vector2);
    }
    public Vector Cross(Vector Vector)
    {
        return new Vector((Y * Vector.Z) - (Z * Vector.Y), (Z * Vector.X) - (X * Vector.Z), (X * Vector.Y) - (Y * Vector.X));
    }
    public static Vector Cross(Vector Vector1, Vector Vector2)
    {
        return Vector1.Cross(Vector2);
    }
    public static Vector operator *(Vector Vector, double Multiplier)
    {
        return Vector == null ? null : new Vector(Vector.X * Multiplier, Vector.Y * Multiplier, Vector.Z * Multiplier);
    }
    public static Vector operator *(double Multiplier, Vector Vector)
    {
        return Vector * Multiplier;
    }
    public override string ToString()
    {
        return $"({X:0.000}, {Y:0.000}, {Z:0.000})";
    }
}

internal static class Vector_
{
    public static dynamic GetTSObject(Vector dynObject)
    {
        return dynObject is null ? null : dynObject.teklaObject;
    }

    public static Vector FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        dynamic typeName = "Dynamic." + tsObject.GetType().FullName;
        dynamic type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        object[] parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        Vector dynObject = (Vector)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class VectorArray_
{
    public static dynamic GetTSObject(Vector[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(Vector_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static Vector[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<Vector>();
        foreach (var tsItem in tsArray)
        {
            list.Add(Vector_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}
