using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model;
public abstract class BendSurfaceNode : IGeometryNode
{
    public bool IsAutomatic
    {
        get
        {
            try
            {
                return teklaObject.IsAutomatic;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsAutomatic), ex);
            }
        }

    }

    public BendSurface Surface
    {
        get
        {
            try
            {
                var value = teklaObject.Surface;
                var value_ = BendSurface_.FromTSObject(value);
                return (BendSurface)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Surface), ex);
            }
        }
        set
        {
            try
            {
                var value_ = BendSurface_.GetTSObject(value);
                teklaObject.Surface = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Surface), ex);
            }
        }
    }


    public dynamic teklaObject { get; set; }


    public void AcceptVisitor(IGeometryNodeVisitor visitor_)
    {
        var visitor = IGeometryNodeVisitor_.GetTSObject(visitor_);
        try
        {
            teklaObject.AcceptVisitor(visitor);


        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(AcceptVisitor), ex);
        }
    }
    public abstract IGeometryNode Clone();
}

internal static class BendSurfaceNode_
{
    public static dynamic GetTSObject(BendSurfaceNode dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static BendSurfaceNode FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (BendSurfaceNode)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}