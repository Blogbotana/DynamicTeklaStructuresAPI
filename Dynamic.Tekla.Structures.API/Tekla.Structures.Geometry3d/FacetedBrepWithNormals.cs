using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Geometry3d;
public class FacetedBrepWithNormals : Dynamic.Tekla.Structures.Geometry3d.FacetedBrep
{
    public Dynamic.Tekla.Structures.Geometry3d.Vector[] Normals
    {
        get
        {
            try
            {
                var value = teklaObject.Normals;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.VectorArray_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector[])value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Normals), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.VectorArray_.GetTSObject(value);
                teklaObject.Normals = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Normals), ex);
            }
        }
    }
    internal FacetedBrepWithNormals() { }
    //This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
    public FacetedBrepWithNormals(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public FacetedBrepWithNormals(Dynamic.Tekla.Structures.Geometry3d.Vector[] vertices, int[][] outerWires, System.Collections.Generic.IDictionary<int, int[][]> innerWires, Dynamic.Tekla.Structures.Geometry3d.Vector[] normals)
    {
        var args = new object[4];
        args[0] = Dynamic.Tekla.Structures.Geometry3d.VectorArray_.GetTSObject(vertices);
        args[1] = outerWires;
        args[2] = innerWires;
        args[3] = Dynamic.Tekla.Structures.Geometry3d.VectorArray_.GetTSObject(normals);
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.FacetedBrepWithNormals", args);
    }
}

internal static class FacetedBrepWithNormals_
{
    public static dynamic GetTSObject(FacetedBrepWithNormals dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static FacetedBrepWithNormals FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Geometry3d.FacetedBrepWithNormals)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
