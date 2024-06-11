using Dynamic.Tekla.Structures.Geometry3d;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Geometry3d;
public static class MatrixFactory
{/// <summary>
 /// Returns a rotation matrix in a Clockwise rotation around the given rotation axis,
 /// defined by the given angle and the given rotation axis.
 /// </summary>
 /// <param name="Angle">The rotation angle (in radians).</param>
 /// <param name="Axis">The rotation axis.</param>
 /// <returns>The new rotation matrix.</returns>
    public static Matrix Rotate(double Angle, Vector Axis)
    {
        Matrix matrix = new Matrix();
        if (Angle == 0.0)
        {
            return matrix;
        }
        Vector normal = Axis.GetNormal();
        double num = normal.X * normal.Y;
        double num2 = normal.X * normal.Z;
        double num3 = normal.Y * normal.Z;
        double num4 = Math.Cos(Angle);
        double num5 = Math.Sin(Angle);
        matrix[0, 0] = normal.X * normal.X * (1.0 - num4) + num4;
        matrix[1, 0] = num * (1.0 - num4) + normal.Z * num5;
        matrix[2, 0] = num2 * (1.0 - num4) - normal.Y * num5;
        matrix[0, 1] = num * (1.0 - num4) - normal.Z * num5;
        matrix[1, 1] = normal.Y * normal.Y * (1.0 - num4) + num4;
        matrix[2, 1] = num3 * (1.0 - num4) + normal.X * num5;
        matrix[0, 2] = num2 * (1.0 - num4) + normal.Y * num5;
        matrix[1, 2] = num3 * (1.0 - num4) - normal.X * num5;
        matrix[2, 2] = normal.Z * normal.Z * (1.0 - num4) + num4;
        return matrix;
    }

    /// <summary>
    /// Returns a coordinate transformation matrix defined by the given coordinate system.
    /// With the returned matrix points can be transformed from the current work plane coordinate system
    /// to the given coordinate system.
    /// </summary>
    /// <param name="CoordSys">The coordinate system to transform points to.</param>
    /// <returns>The transformation matrix defined by the given coordinate system.</returns>
    public static Matrix ToCoordinateSystem(CoordinateSystem CoordSys)
    {
        Matrix matrix = new Matrix();
        Point origin = CoordSys.Origin;
        Vector normal = CoordSys.AxisX.GetNormal();
        Vector normal2 = CoordSys.AxisY.GetNormal();
        Vector normal3 = Vector.Cross(CoordSys.AxisX, CoordSys.AxisY).GetNormal();
        matrix[0, 0] = normal.X;
        matrix[1, 0] = normal.Y;
        matrix[2, 0] = normal.Z;
        matrix[0, 1] = normal2.X;
        matrix[1, 1] = normal2.Y;
        matrix[2, 1] = normal2.Z;
        matrix[0, 2] = normal3.X;
        matrix[1, 2] = normal3.Y;
        matrix[2, 2] = normal3.Z;
        matrix[3, 0] = 0.0 - (origin.X * normal.X + origin.Y * normal.Y + origin.Z * normal.Z);
        matrix[3, 1] = 0.0 - (origin.X * normal2.X + origin.Y * normal2.Y + origin.Z * normal2.Z);
        matrix[3, 2] = 0.0 - (origin.X * normal3.X + origin.Y * normal3.Y + origin.Z * normal3.Z);
        return matrix;
    }

    /// <summary>
    /// Returns a coordinate transformation matrix defined by the given coordinate system.
    /// With the returned matrix points can be transformed from the given coordinate system to
    /// the current work plane coordinate system.
    /// </summary>
    /// <param name="CoordSys">The coordinate system to transform points from.</param>
    /// <returns>The transformation matrix defined by the given coordinate system.</returns>
    public static Matrix FromCoordinateSystem(CoordinateSystem CoordSys)
    {
        Matrix matrix = new Matrix();
        Point origin = CoordSys.Origin;
        Vector normal = CoordSys.AxisX.GetNormal();
        Vector normal2 = CoordSys.AxisY.GetNormal();
        Vector normal3 = Vector.Cross(CoordSys.AxisX, CoordSys.AxisY).GetNormal();
        matrix[0, 0] = normal.X;
        matrix[1, 0] = normal2.X;
        matrix[2, 0] = normal3.X;
        matrix[0, 1] = normal.Y;
        matrix[1, 1] = normal2.Y;
        matrix[2, 1] = normal3.Y;
        matrix[0, 2] = normal.Z;
        matrix[1, 2] = normal2.Z;
        matrix[2, 2] = normal3.Z;
        matrix[3, 0] = origin.X;
        matrix[3, 1] = origin.Y;
        matrix[3, 2] = origin.Z;
        return matrix;
    }

    /// <summary>
    /// Returns a coordinate transformation matrix defined by two coordinate systems.
    /// With the returned matrix points can be transformed from the first coordinate system to
    /// the second coordinate system. The ByCoordinateSystems method is meant for transforming
    /// points between coordinate systems asked in the same work plane.
    /// </summary>
    /// <param name="CoordSys1">The coordinate system to start from.</param>
    /// <param name="CoordSys2">The target coordinate system.</param>
    /// <returns>The transformation matrix defined by the two coordinate systems.</returns>
    /// <example>This example shows the beam's extremes in some other model object's coordinate system.
    /// <code>
    /// using System;
    /// using System.Globalization;
    /// using Tekla.Structures.Geometry3d;
    /// using Tekla.Structures.Model;
    /// using Tekla.Structures.Model.UI;
    ///
    /// public class Example
    /// {
    ///        private readonly Model _Model = new Model();
    ///        private static GraphicsDrawer GraphicsDrawer = new GraphicsDrawer();
    ///        private readonly static Color TextColor = new Color(1, 0, 1);
    ///
    ///        //Shows the beam's extremes in the coordinates of the reference model object
    ///        private void ShowExtremesInOtherObjectCoordinates(ModelObject ReferenceObject, Beam Beam)
    ///        {
    ///            //Set the transformation plane to use the beam's coordinate system in order to get the beam's extremes in the local coordinate system
    ///            TransformationPlane CurrentTP = _Model.GetWorkPlaneHandler().GetCurrentTransformationPlane();
    ///            _Model.GetWorkPlaneHandler().SetCurrentTransformationPlane(new TransformationPlane(Beam.GetCoordinateSystem()));
    ///
    ///            //Update the beam's extremes to the new transformation plane
    ///            Beam.Select();
    ///            Point LocalStartPoint = Beam.StartPoint;
    ///            Point LocalEndPoint = Beam.EndPoint;
    ///
    ///            //Get the beam's extremes in the reference object's coordinates
    ///            Matrix TransformationMatrix = MatrixFactory.ByCoordinateSystems(Beam.GetCoordinateSystem(), ReferenceObject.GetCoordinateSystem());
    ///
    ///            //Transform the extreme points to the new coordinate system
    ///            Point BeamStartPoint = TransformationMatrix.Transform(LocalStartPoint);
    ///            Point BeamEndPoint = TransformationMatrix.Transform(LocalEndPoint);
    ///
    ///            _Model.GetWorkPlaneHandler().SetCurrentTransformationPlane(CurrentTP);
    ///
    ///            //Transform the points where to show the texts to current work plane coordinate system
    ///            Matrix TransformationToCurrent = MatrixFactory.FromCoordinateSystem(ReferenceObject.GetCoordinateSystem());
    ///            Point BeamStartPointInCurrent = TransformationToCurrent.Transform(BeamStartPoint);
    ///            Point BeamEndPointInCurrent = TransformationToCurrent.Transform(BeamEndPoint);
    ///
    ///            //Display results
    ///            DrawCoordinateSystem(ReferenceObject.GetCoordinateSystem());
    ///            GraphicsDrawer.DrawText(BeamStartPointInCurrent, FormatPointCoordinates(BeamStartPoint), TextColor);
    ///            GraphicsDrawer.DrawText(BeamEndPointInCurrent, FormatPointCoordinates(BeamEndPoint), TextColor);
    ///        }
    ///
    ///        //Draws the coordinate system in which the values are shown
    ///        private static void DrawCoordinateSystem(CoordinateSystem CoordinateSystem)
    ///        {
    ///            DrawVector(CoordinateSystem.Origin, CoordinateSystem.AxisX, "X");
    ///            DrawVector(CoordinateSystem.Origin, CoordinateSystem.AxisY, "Y");
    ///        }
    ///
    ///        //Draws the vector of the coordinate system
    ///        private static void DrawVector(Point StartPoint, Vector Vector, string Text)
    ///        {
    ///            Color Color = new Color(0, 1, 1);
    ///            const double Radians = 0.43;
    ///
    ///            Vector = Vector.GetNormal();
    ///            Vector Arrow01 = new Vector(Vector);
    ///
    ///            Vector.Normalize(500);
    ///            Point EndPoint = new Point(StartPoint);
    ///            EndPoint.Translate(Vector.X, Vector.Y, Vector.Z);
    ///            GraphicsDrawer.DrawLineSegment(StartPoint, EndPoint, Color);
    ///
    ///            GraphicsDrawer.DrawText(EndPoint, Text, Color);
    ///
    ///            Arrow01.Normalize(-100);
    ///            Vector Arrow = ArrowVector(Arrow01, Radians);
    ///
    ///            Point ArrowExtreme = new Point(EndPoint);
    ///            ArrowExtreme.Translate(Arrow.X, Arrow.Y, Arrow.Z);
    ///            GraphicsDrawer.DrawLineSegment(EndPoint, ArrowExtreme, Color);
    ///
    ///            Arrow = ArrowVector(Arrow01, -Radians);
    ///
    ///            ArrowExtreme = new Point(EndPoint);
    ///            ArrowExtreme.Translate(Arrow.X, Arrow.Y, Arrow.Z);
    ///            GraphicsDrawer.DrawLineSegment(EndPoint, ArrowExtreme, Color);
    ///        }
    ///
    ///        //Draws the arrows of the vectors
    ///        private static Vector ArrowVector(Vector Vector, double Radians)
    ///        {
    ///            double X, Y, Z;
    ///
    ///            if(Vector.X == 0 &amp;&amp; Vector.Y == 0)
    ///            {
    ///                X = Vector.X;
    ///                Y = (Vector.Y * Math.Cos(Radians)) - (Vector.Z * Math.Sin(Radians));
    ///                Z = (Vector.Y * Math.Sin(Radians)) + (Vector.Z * Math.Cos(Radians));
    ///            }
    ///            else
    ///            {
    ///                X = (Vector.X * Math.Cos(Radians)) - (Vector.Y * Math.Sin(Radians));
    ///                Y = (Vector.X * Math.Sin(Radians)) + (Vector.Y * Math.Cos(Radians));
    ///                Z = Vector.Z;
    ///            }
    ///
    ///            return new Vector(X, Y, Z);
    ///        }
    ///
    ///        //Shows the point coordinates with only two decimals
    ///        private static string FormatPointCoordinates(Point Point)
    ///        {
    ///            string Output = String.Empty;
    ///
    ///            Output = "(" + Point.X.ToString("0.00", CultureInfo.InvariantCulture) + ", " +
    ///                     Point.Y.ToString("0.00", CultureInfo.InvariantCulture) + ", " +
    ///                     Point.Z.ToString("0.00", CultureInfo.InvariantCulture) + ")";
    ///
    ///            return Output;
    ///        }
    /// }
    /// </code>
    /// </example>
    public static Matrix ByCoordinateSystems(CoordinateSystem CoordSys1, CoordinateSystem CoordSys2)
    {
        Matrix matrix = FromCoordinateSystem(CoordSys1);
        Matrix matrix2 = ToCoordinateSystem(CoordSys2);
        return matrix * matrix2;
    }
}
