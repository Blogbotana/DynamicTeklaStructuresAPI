using Dynamic.Tekla.Structures.Geometry3d;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;

namespace Dynamic.Tekla.Structures.Solid;
/// <summary>
/// The Face class represents a single face in a solid.
/// </summary>
public sealed class Face
{
    public Vector Normal
    {
        get
        {
            try
            {
                var value = teklaObject.Normal;
                var value_ = Vector_.FromTSObject(value);
                return (Vector)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Normal), ex);
            }
        }
    }

    public Identifier OriginPartId
    {
        get
        {
            try
            {
                var value = teklaObject.OriginPartId;
                var value_ = Identifier_.FromTSObject(value);
                return (Identifier)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OriginPartId), ex);
            }
        }

    }


    internal dynamic teklaObject;

    internal Face() { }

    public Face(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
}
internal static class Face_
{
    public static dynamic GetTSObject(Face dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Face FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Solid.Face)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
