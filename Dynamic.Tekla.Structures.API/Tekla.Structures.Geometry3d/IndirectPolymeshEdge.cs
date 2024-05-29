using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Geometry3d;
public class IndirectPolymeshEdge
{

    public PolymeshEdgeTypeEnum EdgeType
    {
        get
        {
            try
            {
                var value = teklaObject.EdgeType;
                var value_ = PolymeshEdgeTypeEnum_.FromTSObject(value);
                return (PolymeshEdgeTypeEnum)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EdgeType), ex);
            }
        }
        set
        {
            try
            {
                var value_ = PolymeshEdgeTypeEnum_.GetTSObject(value);
                teklaObject.EdgeType = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EdgeType), ex);
            }
        }
    }

    public int StartPoint
    {
        get
        {
            try
            {
                return teklaObject.StartPoint;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPoint), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.StartPoint = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartPoint), ex);
            }
        }
    }

    public int EndPoint
    {
        get
        {
            try
            {
                return teklaObject.EndPoint;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPoint), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.EndPoint = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndPoint), ex);
            }
        }
    }

    public int ShellIndex
    {
        get
        {
            try
            {
                return teklaObject.ShellIndex;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ShellIndex), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ShellIndex = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ShellIndex), ex);
            }
        }
    }


    internal dynamic teklaObject;

    public IndirectPolymeshEdge()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Geometry3d.IndirectPolymeshEdge");
    }
    
    public IndirectPolymeshEdge(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }





}
internal static class IndirectPolymeshEdge_
{
    public static dynamic GetTSObject(IndirectPolymeshEdge dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static IndirectPolymeshEdge FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (IndirectPolymeshEdge)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

