using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections;

namespace Dynamic.Tekla.Structures.Geometry3d;
public class PolyLine
{
    public ArrayList Points
    {
        get
        {
            try
            {
                var value = teklaObject.Points;
                var value_ = ArrayListConverter.FromTSObjects(value);
                return (System.Collections.ArrayList)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Points), ex);
            }
        }
        set
        {
            try
            {
                var value_ = ArrayListConverter.ToTSObjects(value);
                teklaObject.Points = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Points), ex);
            }
        }
    }

    public override bool Equals(object obj)
    {
        try
        {
            PolyLine other = obj as PolyLine;
            if (other != null)
            {
                var _polyline = PolyLine_.GetTSObject(other);
                return (bool)teklaObject.Equals(_polyline);
            }
            return false;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Equals), ex);
        }
    }
    /// <summary>
    /// Returns the length of a polyline.
    /// </summary>
    /// <returns>The length of the polyline.</returns>
    public double Length()
    {
        double num = 0.0;
        for (int i = 0; i < Points.Count - 1; i++)
        {
            num += Distance.PointToPoint((Point)Points[i], (Point)Points[i + 1]);
        }
        return num;
    }   
    /// <summary>
    /// Returns a hash code for a polyline.
    /// Notice, in extremely rare cases, you might not get the same
    /// hash code for two polylines even though they are considered equal! This
    /// should, however, happen only in extremely rare cases!
    /// </summary>
    /// <returns>The hash code for the polyline.</returns>
    public override int GetHashCode()
    {
        int num = 0;
        for (int i = 0; i < Points.Count; i++)
        {
            num ^= Points[i].GetHashCode();
        }
        return num;
    }/// <summary>
     /// Checks the equality of two polylines.
     /// </summary>
     /// <param name="PolyLine1">The first polyline to be used.</param>
     /// <param name="PolyLine2">The second polyline to be used.</param>
     /// <returns>True if the two polylines are equal.
     /// False otherwise.</returns>
    public static bool operator ==(PolyLine PolyLine1, PolyLine PolyLine2)
    {
        bool flag = (object)PolyLine1 == null;
        bool flag2 = (object)PolyLine2 == null;
        bool flag3 = true;
        if (flag && flag2)
        {
            return true;
        }
        if (flag || flag2)
        {
            return false;
        }
        if (PolyLine1.Points.Count != PolyLine2.Points.Count)
        {
            return false;
        }
        for (int i = 0; i < PolyLine1.Points.Count; i++)
        {
            flag3 = flag3 && PolyLine1.Points[i] as Point == PolyLine2.Points[i] as Point;
        }
        return flag3;
    }

    /// <summary>
    /// Checks the inequality of two polylines.
    /// </summary>
    /// <param name="PolyLine1">The first polyline to be used.</param>
    /// <param name="PolyLine2">The second polyline to be used.</param>
    /// <returns>True if the two polylines are not equal.
    /// False otherwise.</returns>
    public static bool operator !=(PolyLine PolyLine1, PolyLine PolyLine2)
    {
        return !(PolyLine1 == PolyLine2);
    }

    internal dynamic teklaObject;

    internal PolyLine() { }

    public PolyLine(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public PolyLine(System.Collections.IEnumerable Points)
    {
        var args = new object[1];
        args[0] = Points;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.PolyLine", args);
    }
}
internal static class PolyLine_
{
    public static dynamic GetTSObject(PolyLine dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static PolyLine FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Geometry3d.PolyLine)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}