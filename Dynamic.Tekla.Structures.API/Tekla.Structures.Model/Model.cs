using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;

namespace Dynamic.Tekla.Structures.Model;
/// <summary>
/// The Model class represents a single model open in Tekla Structures. Before interaction
/// with the model, the user will have to create one instance of this class.
/// </summary>
public class Model
{



    internal dynamic teklaObject;

    public Model()
    {
        this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Model");
    }
    //This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
    public Model(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        this.teklaObject = tsObject;
    }


    public System.Boolean GetConnectionStatus()
    {

        try
        {
            var result = (System.Boolean)teklaObject.GetConnectionStatus();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetConnectionStatus), ex);
        }
    }



    public Dynamic.Tekla.Structures.Model.ModelInfo GetInfo()
    {

        try
        {
            var result = teklaObject.GetInfo();

            var _result = Dynamic.Tekla.Structures.Model.ModelInfo_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetInfo), ex);
        }
    }



    public Dynamic.Tekla.Structures.Model.ProjectInfo GetProjectInfo()
    {

        try
        {
            var result = teklaObject.GetProjectInfo();

            var _result = Dynamic.Tekla.Structures.Model.ProjectInfo_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetProjectInfo), ex);
        }
    }



    public Dynamic.Tekla.Structures.Model.PhaseCollection GetPhases()
    {

        try
        {
            var result = teklaObject.GetPhases();

            var _result = Dynamic.Tekla.Structures.Model.PhaseCollection_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetPhases), ex);
        }
    }



    public Dynamic.Tekla.Structures.Model.ModelObjectSelector GetModelObjectSelector()
    {

        try
        {
            var result = teklaObject.GetModelObjectSelector();

            var _result = Dynamic.Tekla.Structures.Model.ModelObjectSelector_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetModelObjectSelector), ex);
        }
    }



    public Dynamic.Tekla.Structures.Model.ModelObject SelectModelObject(
        Dynamic.Tekla.Structures.Identifier ID_)
    {
        var ID = Dynamic.Tekla.Structures.Identifier_.GetTSObject(ID_);
        try
        {
            var result = teklaObject.SelectModelObject(ID);

            var _result = Dynamic.Tekla.Structures.Model.ModelObject_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SelectModelObject), ex);
        }
    }



    public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> FetchModelObjects(
        System.Collections.Generic.List<System.String> Guids,
        System.Boolean SelectInstances)
    {
        try
        {
            var result = teklaObject.FetchModelObjects(Guids, SelectInstances);

            var _result = ListConverter.FromTSObjects<Dynamic.Tekla.Structures.Model.ModelObject>(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(FetchModelObjects), ex);
        }
    }



    public System.Collections.Generic.List<Dynamic.Tekla.Structures.Model.ModelObject> FetchModelObjects(
        System.Collections.Generic.List<Dynamic.Tekla.Structures.Identifier> Ids_,
        System.Boolean SelectInstances)
    {
        var Ids = ListConverter.ToTSObjects(Ids_);
        try
        {
            var result = teklaObject.FetchModelObjects(Ids, SelectInstances);

            var _result = ListConverter.FromTSObjects<Dynamic.Tekla.Structures.Model.ModelObject>(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(FetchModelObjects), ex);
        }
    }



    public Dynamic.Tekla.Structures.Identifier GetIdentifierByGUID(
        System.String guid)
    {

        try
        {
            var result = teklaObject.GetIdentifierByGUID(guid);

            var _result = Dynamic.Tekla.Structures.Identifier_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetIdentifierByGUID), ex);
        }
    }



    public System.String GetGUIDByIdentifier(
        Dynamic.Tekla.Structures.Identifier identifier_)
    {
        var identifier = Dynamic.Tekla.Structures.Identifier_.GetTSObject(identifier_);
        try
        {
            var result = (System.String)teklaObject.GetGUIDByIdentifier(identifier);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetGUIDByIdentifier), ex);
        }
    }



    public System.Boolean CommitChanges()
    {

        try
        {
            var result = (System.Boolean)teklaObject.CommitChanges();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CommitChanges), ex);
        }
    }



    public System.Boolean CommitChanges(
        System.String Message)
    {

        try
        {
            var result = (System.Boolean)teklaObject.CommitChanges(Message);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(CommitChanges), ex);
        }
    }



    public Dynamic.Tekla.Structures.Model.WorkPlaneHandler GetWorkPlaneHandler()
    {

        try
        {
            var result = teklaObject.GetWorkPlaneHandler();

            var _result = Dynamic.Tekla.Structures.Model.WorkPlaneHandler_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetWorkPlaneHandler), ex);
        }
    }



    public Dynamic.Tekla.Structures.Model.ClashCheckHandler GetClashCheckHandler()
    {

        try
        {
            var result = teklaObject.GetClashCheckHandler();

            var _result = Dynamic.Tekla.Structures.Model.ClashCheckHandler_.FromTSObject(result);
            return _result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetClashCheckHandler), ex);
        }
    }






}

internal static class Model_
{
    public static dynamic GetTSObject(Model dynObject)
    {
        return dynObject is null ? null : dynObject.teklaObject;
    }

    public static Model FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        dynamic typeName = "Dynamic." + tsObject.GetType().FullName;
        dynamic type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        object[] parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        Model dynObject = (Model)Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
