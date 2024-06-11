using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
/// <summary>
/// The Boolean class is an abstract base class for boolean operations such as a part cut, an add, a fitting or
/// a cut plane.
/// </summary>
public abstract class Boolean : ModelObject
{

    public ModelObject Father
    {
        get
        {
            try
            {
                var value = teklaObject.Father;
                var value_ = ModelObject_.FromTSObject(value);
                return (ModelObject)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Father), ex);
            }
        }
        set
        {
            try
            {
                var value_ = ModelObject_.GetTSObject(value);
                teklaObject.Father = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Father), ex);
            }
        }
    }

}

internal static class Boolean_
{
    public static dynamic GetTSObject(Boolean dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Boolean FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Boolean)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

