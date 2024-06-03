using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;
using System;
using System.Collections.Generic;

namespace Dynamic.Tekla.Structures.Geometry3d;
public class Matrix
{
    public double[,] Transformation
    {
        get
        {
            try
            {
                return PropertyInvoker.GetInstancePropertyOrFieldValue(teklaObject, "Transformation") as double[,];
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Transformation), ex);
            }
        }
        set
        {
            try
            {
                PropertyInvoker.SetInstancePropertyOrFieldValue(teklaObject, "Transformation", value);
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Transformation), ex);
            }
        }
    }
    /// <summary>
    /// Transposes a matrix. The resulting matrix is an inversion of the current matrix,
    /// if the current matrix was a valid rotation matrix.
    /// </summary>
    public void Transpose()
    {
        double num = Transformation[0, 1];
        Transformation[0, 1] = Transformation[1, 0];
        Transformation[1, 0] = num;
        num = Transformation[0, 2];
        Transformation[0, 2] = Transformation[2, 0];
        Transformation[2, 0] = num;
        num = Transformation[1, 2];
        Transformation[1, 2] = Transformation[2, 1];
        Transformation[2, 1] = num;
        double num2 = Transformation[3, 0];
        double num3 = Transformation[3, 1];
        double num4 = Transformation[3, 2];
        Transformation[3, 0] = 0.0 - (num2 * Transformation[0, 0] + num3 * Transformation[1, 0] + num4 * Transformation[2, 0]);
        Transformation[3, 1] = 0.0 - (num2 * Transformation[0, 1] + num3 * Transformation[1, 1] + num4 * Transformation[2, 1]);
        Transformation[3, 2] = 0.0 - (num2 * Transformation[0, 2] + num3 * Transformation[1, 2] + num4 * Transformation[2, 2]);
    }
    /// <summary>
    /// Sets or gets the matrix element values.
    /// </summary>
    /// <param name="row">The matrix row index (0-3).</param>
    /// <param name="column">The matrix column index (0-2).</param>
    /// <returns>The value at the specified index.</returns>
    public double this[int row, int column]
    {
        get
        {
            return Transformation[row, column];
        }
        set
        {
            Transformation[row, column] = value;
        }
    }
    /// <summary>
    /// Returns a new matrix which is a transpose of the current matrix.
    /// The transposed matrix is an inversion of the current matrix,
    /// if the current matrix was a valid rotation matrix.
    /// </summary>
    /// <returns>The new transposed matrix.</returns>
    public Matrix GetTranspose()
    {
        Matrix matrix = new Matrix(this);
        matrix.Transpose();
        return matrix;
    }
    /// <summary>
    /// Multiplies (combines) two transformation matrices.
    /// </summary>
    /// <param name="B">The transformation matrix which is applied second.</param>
    /// <param name="A">The transformation matrix which is applied first.</param>
    /// <returns>The new compound transformation matrix.</returns>
    public static Matrix operator *(Matrix B, Matrix A)
    {
        Matrix matrix = new Matrix();
        matrix.Transformation[0, 0] = 0.0;
        matrix.Transformation[1, 1] = 0.0;
        matrix.Transformation[2, 2] = 0.0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matrix.Transformation[j, i] = A.Transformation[0, i] * B.Transformation[j, 0] + A.Transformation[1, i] * B.Transformation[j, 1] + A.Transformation[2, i] * B.Transformation[j, 2];
            }
            matrix.Transformation[3, i] = matrix.Transformation[3, i] + A.Transformation[3, i];
        }
        return matrix;
    }

    /// <summary>
    /// Transforms the given point using the current matrix.
    /// </summary>
    /// <param name="p">The point to be transformed.</param>
    /// <returns>The new transformed point.</returns>
    public Point Transform(Point p)
    {
        return new Point
        {
            X = p.X * Transformation[0, 0] + p.Y * Transformation[1, 0] + p.Z * Transformation[2, 0] + Transformation[3, 0],
            Y = p.X * Transformation[0, 1] + p.Y * Transformation[1, 1] + p.Z * Transformation[2, 1] + Transformation[3, 1],
            Z = p.X * Transformation[0, 2] + p.Y * Transformation[1, 2] + p.Z * Transformation[2, 2] + Transformation[3, 2]
        };
    }

    /// <summary>
    /// Transforms the given points using the current matrix.
    /// </summary>
    /// <param name="Points">The points to be transformed.</param>
    /// <returns>The new transformed points.</returns>
    public IEnumerable<Point> Transform(IEnumerable<Point> Points)
    {
        foreach (Point Point in Points)
        {
            yield return Transform(Point);
        }
    }

    /// <summary>
    /// Transforms the given point using the given matrix.
    /// </summary>
    /// <param name="A">The transformation matrix.</param>
    /// <param name="p">The point to be transformed.</param>
    /// <returns>The new transformed point.</returns>
    public static Point operator *(Matrix A, Point p)
    {
        return A.Transform(p);
    }

    /// <summary>
    /// Transforms the given points using the given matrix.
    /// </summary>
    /// <param name="A">The transformation matrix.</param>
    /// <param name="Points">The points to be transformed.</param>
    /// <returns>The new transformed points.</returns>
    public static IEnumerable<Point> operator *(Matrix A, IEnumerable<Point> Points)
    {
        return A.Transform(Points);
    }

    /// <summary>
    /// Returns a string that represents the current matrix.
    /// </summary>
    /// <returns>The string that represents the current matrix.</returns>
    public override string ToString()
    {
        return "[" + Transformation[0, 0].ToString("f4") + " " + Transformation[0, 1].ToString("f4") + " " + Transformation[0, 2].ToString("f4") + "]\n[" + Transformation[1, 0].ToString("f4") + " " + Transformation[1, 1].ToString("f4") + " " + Transformation[1, 2].ToString("f4") + "]\n[" + Transformation[2, 0].ToString("f4") + " " + Transformation[2, 1].ToString("f4") + " " + Transformation[2, 2].ToString("f4") + "]\n[" + Transformation[3, 0].ToString("f4") + " " + Transformation[3, 1].ToString("f4") + " " + Transformation[3, 2].ToString("f4") + "]\n";
    }

    internal dynamic teklaObject;

    public Matrix()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Matrix");
    }

    public Matrix(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public Matrix(Matrix m)
    {
        var args = new object[1];
        args[0] = Matrix_.GetTSObject(m);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.Matrix", args);
    }
}

internal static class Matrix_
{
    public static dynamic GetTSObject(Matrix dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Matrix FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Matrix)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
