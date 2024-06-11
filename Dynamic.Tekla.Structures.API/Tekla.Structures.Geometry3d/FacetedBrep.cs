using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Geometry3d;
public class FacetedBrep
{


    public System.Collections.Generic.ICollection<Dynamic.Tekla.Structures.Geometry3d.FacetedBrepFace> Faces
    {
        get
        {
            try
            {
                var value = teklaObject.Faces;
                var value_ = IEnumerableConverter.FromTSObjects<Dynamic.Tekla.Structures.Geometry3d.FacetedBrepFace>(value);
                return (System.Collections.Generic.ICollection<Dynamic.Tekla.Structures.Geometry3d.FacetedBrepFace>)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Faces), ex);
            }
        }

    }

    public System.Collections.Generic.IDictionary<int, int[][]> InnerWires
    {
        get
        {
            try
            {
                return teklaObject.InnerWires;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(InnerWires), ex);
            }
        }

    }

    public int[][] OuterWires
    {
        get
        {
            try
            {
                return teklaObject.OuterWires;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OuterWires), ex);
            }
        }

    }

    public System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.IndirectPolymeshEdge> GetEdges
    {
        get
        {
            try
            {
                var value = teklaObject.GetEdges;
                var value_ = ListConverter.FromTSObjects<Dynamic.Tekla.Structures.Geometry3d.IndirectPolymeshEdge>(value);
                return (System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.IndirectPolymeshEdge>)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(GetEdges), ex);
            }
        }

    }

    public System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Vector> Vertices
    {
        get
        {
            try
            {
                var value = teklaObject.Vertices;
                var value_ = ListConverter.FromTSObjects<Dynamic.Tekla.Structures.Geometry3d.Vector>(value);
                return (System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.Vector>)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Vertices), ex);
            }
        }

    }


    internal dynamic teklaObject;

    internal FacetedBrep() { }
    //This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
    public FacetedBrep(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public FacetedBrep(Dynamic.Tekla.Structures.Geometry3d.Vector[] vertices, int[][] outerWires, System.Collections.Generic.IDictionary<int, int[][]> innerWires)
    {
        var args = new object[3];
        args[0] = Dynamic.Tekla.Structures.Geometry3d.VectorArray_.GetTSObject(vertices);
        args[1] = outerWires;
        args[2] = innerWires;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.FacetedBrep", args);
    }
    public FacetedBrep(Dynamic.Tekla.Structures.Geometry3d.Vector[] vertices, int[][] outerWires, System.Collections.Generic.IDictionary<int, int[][]> innerWires, System.Collections.Generic.IList<Dynamic.Tekla.Structures.Geometry3d.IndirectPolymeshEdge> edges)
    {
        var args = new object[4];
        args[0] = Dynamic.Tekla.Structures.Geometry3d.VectorArray_.GetTSObject(vertices);
        args[1] = outerWires;
        args[2] = innerWires;
        args[3] = edges;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.FacetedBrep", args);
    }


    public bool CheckForTwoManifold()
    {

        try
        {
            var result = (bool)teklaObject.CheckForTwoManifold();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CheckForTwoManifold), ex);
        }
    }



    public int[] GetInnerFace(
        int faceIndex)
    {

        try
        {
            var result = (int[])teklaObject.GetInnerFace(faceIndex);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetInnerFace), ex);
        }
    }



    public int GetInnerFaceCount(
        int faceIndex)
    {

        try
        {
            var result = (int)teklaObject.GetInnerFaceCount(faceIndex);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetInnerFaceCount), ex);
        }
    }



    public int[] GetOuterFace(
        int faceIndex)
    {

        try
        {
            var result = (int[])teklaObject.GetOuterFace(faceIndex);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetOuterFace), ex);
        }
    }






}

internal static class FacetedBrep_
{
    public static dynamic GetTSObject(FacetedBrep dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static FacetedBrep FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Geometry3d.FacetedBrep)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

