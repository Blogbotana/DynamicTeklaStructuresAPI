using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
/// <summary>
/// The Object class is an abstract base class for all the objects Tekla Structures has.
/// </summary>
public abstract class Object
{
    public Dynamic.Tekla.Structures.Identifier Identifier
    {
        get
        {
            try
            {
                var value = teklaObject.Identifier;
                var value_ = Dynamic.Tekla.Structures.Identifier_.FromTSObject(value);
                return (Dynamic.Tekla.Structures.Identifier)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Identifier), ex);
            }
        }
        set
        {
            try
            {
                var value_ = Dynamic.Tekla.Structures.Identifier_.GetTSObject(value);
                teklaObject.Identifier = value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Identifier), ex);
            }
        }
    }


    internal dynamic teklaObject;
}
internal static class Object_
{
    public static dynamic GetTSObject(Object dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Object FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (Object)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}