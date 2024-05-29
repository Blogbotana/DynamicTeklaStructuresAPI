using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;

namespace Dynamic.Tekla.Structures.Geometry3d;
public class OBB : IEquatable<OBB>
{
    private const string InitializationExceptionMessage = "Confirm that given parameters are in correct format.";
    private const int RequiredArraySize = 3;

    public Point Center
    {
        get
        {
            try
            {
                dynamic value = teklaObject.Center;
                dynamic value_ = Point_.FromTSObject(value);
                return (Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Center), ex);
            }
        }
        set
        {
            try
            {
                dynamic value_ = Point_.GetTSObject(value);
                teklaObject.Center = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Center), ex);
            }
        }
    }
    public Vector Axis0
    {
        get
        {
            try
            {
                dynamic value = teklaObject.Axis0;
                dynamic value_ = Vector_.FromTSObject(value);
                return (Vector)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Axis0), ex);
            }
        }

    }
    public Vector Axis1
    {
        get
        {
            try
            {
                dynamic value = teklaObject.Axis1;
                dynamic value_ = Vector_.FromTSObject(value);
                return (Vector)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Axis1), ex);
            }
        }

    }
    public Vector Axis2
    {
        get
        {
            try
            {
                dynamic value = teklaObject.Axis2;
                dynamic value_ = Vector_.FromTSObject(value);
                return (Vector)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Axis2), ex);
            }
        }

    }
    public double Extent0
    {
        get
        {
            try
            {
                return teklaObject.Extent0;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Extent0), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Extent0 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Extent0), ex);
            }
        }
    }
    public double Extent1
    {
        get
        {
            try
            {
                return teklaObject.Extent1;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Extent1), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Extent1 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Extent1), ex);
            }
        }
    }
    public double Extent2
    {
        get
        {
            try
            {
                return teklaObject.Extent2;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Extent2), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Extent2 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Extent2), ex);
            }
        }
    }

    internal dynamic teklaObject;

    public OBB()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.OBB");
    }

    public OBB(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public OBB(Point center, Vector axis0, Vector axis1, Vector axis2, double extent0, double extent1, double extent2)
    {
        object[] args = new object[7];
        args[0] = Point_.GetTSObject(center);
        args[1] = Vector_.GetTSObject(axis0);
        args[2] = Vector_.GetTSObject(axis1);
        args[3] = Vector_.GetTSObject(axis2);
        args[4] = extent0;
        args[5] = extent1;
        args[6] = extent2;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.OBB", args);
    }
    public OBB(Point center, Vector[] axis, double[] extent)
    {
        object[] args = new object[3];
        args[0] = Point_.GetTSObject(center);
        args[1] = VectorArray_.GetTSObject(axis);
        args[2] = extent;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.OBB", args);
    }
    public OBB(OBB obb)
    {
        object[] args = new object[1];
        args[0] = OBB_.GetTSObject(obb);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.OBB", args);
    }

    /// <summary>
    /// Sets the Axis to the OBB.
    /// </summary>
    /// <param name="axis0">Unit-length vector parallel to one axis of the OBB.</param>
    /// <param name="axis1">Unit-length vector parallel to the second axis of the OBB.</param>
    /// <param name="axis2">Unit-length vector parallel to the third axis of the OBB.</param>
    /// <exception cref="T:System.ArgumentException">Thrown when setting the axis fails.</exception>
    public void SetAxis(Vector axis0, Vector axis1, Vector axis2)
    {
        SetAxis(new Vector[3] { axis0, axis1, axis2 });
    }
    public void SetAxis(Vector[] axis_)
    {
        var axis = VectorArray_.GetTSObject(axis_);
        try
        {
            teklaObject.SetAxis(axis);


        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetAxis), ex);
        }
    }
    public void SetExtent(double extent0, double extent1, double extent2)
    {
        SetExtent(new double[3] { extent0, extent1, extent2 });
    }
    public void SetExtent(double[] extent)
    {
        try
        {
            teklaObject.SetExtent(extent);
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetExtent), ex);
        }
    }
    public Point[] ComputeVertices()
    {
        try
        {
            dynamic result = teklaObject.ComputeVertices();

            var _result = PointArray_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ComputeVertices), ex);
        }
    }
    public Point ClosestPointTo(
            Point point_)
    {
        dynamic point = Point_.GetTSObject(point_);
        try
        {
            dynamic result = teklaObject.ClosestPointTo(point);

            dynamic _result = Point_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ClosestPointTo), ex);
        }
    }



    public Point ClosestPointTo(
        Line line_)
    {
        dynamic line = Line_.GetTSObject(line_);
        try
        {
            dynamic result = teklaObject.ClosestPointTo(line);

            dynamic _result = Point_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ClosestPointTo), ex);
        }
    }



    public Point ClosestPointTo(
        LineSegment lineSegment_)
    {
        dynamic lineSegment = LineSegment_.GetTSObject(lineSegment_);
        try
        {
            dynamic result = teklaObject.ClosestPointTo(lineSegment);

            dynamic _result = Point_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ClosestPointTo), ex);
        }
    }



    public double DistanceTo(
        Point point_)
    {
        dynamic point = Point_.GetTSObject(point_);
        try
        {
            double result = (double)teklaObject.DistanceTo(point);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(DistanceTo), ex);
        }
    }

    public double DistanceTo(
        Line line_)
    {
        dynamic line = Line_.GetTSObject(line_);
        try
        {
            double result = (double)teklaObject.DistanceTo(line);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(DistanceTo), ex);
        }
    }

    public double DistanceTo(
        LineSegment lineSegment_)
    {
        dynamic lineSegment = LineSegment_.GetTSObject(lineSegment_);
        try
        {
            double result = (double)teklaObject.DistanceTo(lineSegment);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(DistanceTo), ex);
        }
    }

    public Point[] IntersectionPointsWith(
        Line line_)
    {
        dynamic line = Line_.GetTSObject(line_);
        try
        {
            dynamic result = teklaObject.IntersectionPointsWith(line);

            var _result = PointArray_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IntersectionPointsWith), ex);
        }
    }

    public Point[] IntersectionPointsWith(
        LineSegment lineSegment_)
    {
        dynamic lineSegment = LineSegment_.GetTSObject(lineSegment_);
        try
        {
            dynamic result = teklaObject.IntersectionPointsWith(lineSegment);

            var _result = PointArray_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IntersectionPointsWith), ex);
        }
    }

    public LineSegment IntersectionWith(
        Line line_)
    {
        dynamic line = Line_.GetTSObject(line_);
        try
        {
            dynamic result = teklaObject.IntersectionWith(line);

            dynamic _result = LineSegment_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IntersectionWith), ex);
        }
    }



    public LineSegment IntersectionWith(
        LineSegment lineSegment_)
    {
        dynamic lineSegment = LineSegment_.GetTSObject(lineSegment_);
        try
        {
            dynamic result = teklaObject.IntersectionWith(lineSegment);

            dynamic _result = LineSegment_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IntersectionWith), ex);
        }
    }



    public bool Intersects(
        OBB obb_)
    {
        dynamic obb = OBB_.GetTSObject(obb_);
        try
        {
            bool result = (bool)teklaObject.Intersects(obb);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Intersects), ex);
        }
    }



    public bool Intersects(
        Line line_)
    {
        dynamic line = Line_.GetTSObject(line_);
        try
        {
            bool result = (bool)teklaObject.Intersects(line);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Intersects), ex);
        }
    }



    public bool Intersects(
        LineSegment lineSegment_)
    {
        dynamic lineSegment = LineSegment_.GetTSObject(lineSegment_);
        try
        {
            bool result = (bool)teklaObject.Intersects(lineSegment);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Intersects), ex);
        }
    }



    public bool Intersects(
        GeometricPlane geometricPlane_)
    {
        dynamic geometricPlane = GeometricPlane_.GetTSObject(geometricPlane_);
        try
        {
            bool result = (bool)teklaObject.Intersects(geometricPlane);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Intersects), ex);
        }
    }



    public LineSegment ShortestSegmentTo(
        Line line_)
    {
        dynamic line = Line_.GetTSObject(line_);
        try
        {
            dynamic result = teklaObject.ShortestSegmentTo(line);

            dynamic _result = LineSegment_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ShortestSegmentTo), ex);
        }
    }



    public LineSegment ShortestSegmentTo(
        LineSegment lineSegment_)
    {
        dynamic lineSegment = LineSegment_.GetTSObject(lineSegment_);
        try
        {
            dynamic result = teklaObject.ShortestSegmentTo(lineSegment);

            dynamic _result = LineSegment_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ShortestSegmentTo), ex);
        }
    }



    public LineSegment ShortestSegmentTo(
        Point point_)
    {
        dynamic point = Point_.GetTSObject(point_);
        try
        {
            dynamic result = teklaObject.ShortestSegmentTo(point);

            dynamic _result = LineSegment_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ShortestSegmentTo), ex);
        }
    }

    public bool Equals(OBB other)
    {
        dynamic _other = OBB_.GetTSObject(other);
        try
        {
            bool result = (bool)teklaObject.Equals(_other);
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(ShortestSegmentTo), ex);
        }
    }
}

internal static class OBB_
{
    public static dynamic GetTSObject(OBB dynObject)
    {
        return dynObject is null ? null : dynObject.teklaObject;
    }

    public static OBB FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        dynamic typeName = "Dynamic." + tsObject.GetType().FullName;
        dynamic type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        object[] parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        OBB dynObject = (Dynamic.Tekla.Structures.Geometry3d.OBB)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
