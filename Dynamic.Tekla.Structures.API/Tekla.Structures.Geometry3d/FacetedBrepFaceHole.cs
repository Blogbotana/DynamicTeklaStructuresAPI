using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Geometry3d;
public class FacetedBrepFaceHole
{


    public int Count
    {
        get
        {
            try
            {
                return teklaObject.Count;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Count), ex);
            }
        }

    }

    public bool IsReadOnly
    {
        get
        {
            try
            {
                return teklaObject.IsReadOnly;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsReadOnly), ex);
            }
        }

    }

    public System.Collections.Generic.IList<int> VerticeIndexes
    {
        get
        {
            try
            {
                return teklaObject.VerticeIndexes;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(VerticeIndexes), ex);
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

    internal FacetedBrepFaceHole() { }
    //This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
    public FacetedBrepFaceHole(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }





}

internal static class FacetedBrepFaceHole_
{
    public static dynamic GetTSObject(FacetedBrepFaceHole dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static FacetedBrepFaceHole FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Geometry3d.FacetedBrepFaceHole)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
