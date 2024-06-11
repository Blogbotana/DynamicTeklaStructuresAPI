using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;

namespace Dynamic.Tekla.Structures.Model.UI;


public class ClipPlane
{


    public Dynamic.Tekla.Structures.Geometry3d.Point Location
    {
        get
        {
            try
            {
                var value = teklaObject.Location;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Point)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Location), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value);
                teklaObject.Location = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Location), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Geometry3d.Vector UpVector
    {
        get
        {
            try
            {
                var value = teklaObject.UpVector;
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Geometry3d.Vector)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(UpVector), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value);
                teklaObject.UpVector = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(UpVector), ex);
            }
        }
    }

    public Dynamic.Tekla.Structures.Model.UI.View View
    {
        get
        {
            try
            {
                var value = teklaObject.View;
                var value_ = Dynamic.Tekla.Structures.Model.UI.View_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Model.UI.View)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(View), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Model.UI.View_.GetTSObject(value);
                teklaObject.View = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(View), ex);
            }
        }
    }

    public System.Boolean IsBorderVisible
    {
        get
        {
            try
            {
                return teklaObject.IsBorderVisible;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsBorderVisible), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.IsBorderVisible = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsBorderVisible), ex);
            }
        }
    }

    public System.Boolean IsScissorVisible
    {
        get
        {
            try
            {
                return teklaObject.IsScissorVisible;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsScissorVisible), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.IsScissorVisible = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(IsScissorVisible), ex);
            }
        }
    }


    internal dynamic teklaObject;

    public ClipPlane()
    {
        this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.UI.ClipPlane");
    }
    //This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
    public ClipPlane(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        this.teklaObject = tsObject;
    }


    public System.Boolean Insert()
    {

        try
        {
            var result = (System.Boolean)teklaObject.Insert();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Insert), ex);
        }
    }



    public System.Boolean Delete()
    {

        try
        {
            var result = (System.Boolean)teklaObject.Delete();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Delete), ex);
        }
    }



    public System.Boolean Modify()
    {

        try
        {
            var result = (System.Boolean)teklaObject.Modify();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Modify), ex);
        }
    }






}

internal static class ClipPlane_
{
    public static dynamic GetTSObject(ClipPlane dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ClipPlane FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Model.UI.ClipPlane)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}


