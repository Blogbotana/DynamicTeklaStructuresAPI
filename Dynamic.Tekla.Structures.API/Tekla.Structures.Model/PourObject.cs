using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures.Model;
public class PourObject : ModelObject, IAssemblable
{
    public int Class
    {
        get
        {
            try
            {
                return teklaObject.Class;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Class), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Class = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Class), ex);
            }
        }
    }

    public string PourNumber
    {
        get
        {
            try
            {
                return teklaObject.PourNumber;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PourNumber), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PourNumber = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PourNumber), ex);
            }
        }
    }

    public string PourType
    {
        get
        {
            try
            {
                return teklaObject.PourType;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PourType), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PourType = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PourType), ex);
            }
        }
    }

    public string ConcreteMixture
    {
        get
        {
            try
            {
                return teklaObject.ConcreteMixture;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ConcreteMixture), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ConcreteMixture = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ConcreteMixture), ex);
            }
        }
    }

    public dynamic teklaObject { get => teklaObject; set => teklaObject = value; }

    public PourObject()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.PourObject");
    }
   
    public PourObject(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }

    public Solid GetSolid()
    {

        try
        {
            var result = teklaObject.GetSolid();

            var _result = Solid_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSolid), ex);
        }
    }

    public PolymeshEnumerator GetPourPolymeshes()
    {

        try
        {
            var result = teklaObject.GetPourPolymeshes();

            var _result = PolymeshEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPourPolymeshes), ex);
        }
    }

    public ModelObjectEnumerator GetParts()
    {

        try
        {
            var result = teklaObject.GetParts();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetParts), ex);
        }
    }

    public ModelObjectEnumerator GetObjects()
    {

        try
        {
            var result = teklaObject.GetObjects();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetObjects), ex);
        }
    }

    public PourUnit GetFatherPourUnit()
    {

        try
        {
            var result = teklaObject.GetFatherPourUnit();

            var _result = PourUnit_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetFatherPourUnit), ex);
        }
    }

    public ModelObjectEnumerator GetSurfaceObjects()
    {

        try
        {
            var result = teklaObject.GetSurfaceObjects();

            var _result = ModelObjectEnumerator_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetSurfaceObjects), ex);
        }
    }

    public Assembly GetAssembly()
    {

        try
        {
            var result = teklaObject.GetAssembly();

            var _result = Assembly_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetAssembly), ex);
        }
    }

}

internal static class PourObject_
{
    public static dynamic GetTSObject(PourObject dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static PourObject FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (PourObject)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
