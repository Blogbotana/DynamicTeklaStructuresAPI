using Dynamic.Tekla.Structures.Internal.Converters;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal.Invoker;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Dynamic.Tekla.Structures.Model;
/// <summary>
/// The ProjectInfo class provides project information about the currently open Tekla Structures model.
/// </summary>
public sealed class ProjectInfo
{
    /// <summary>
    /// The description to the Tekla Structures model.
    /// </summary>
    public string Description
    {
        get
        {
            try
            {
                return teklaObject.Description;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Description), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Description = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Description), ex);
            }
        }
    }
    /// <summary>
    /// Start date information of the project.
    /// </summary>
    public string StartDate
    {
        get
        {
            try
            {
                return teklaObject.StartDate;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartDate), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.StartDate = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(StartDate), ex);
            }
        }
    }
    /// <summary>
    /// End date information of the project.
    /// </summary>
    public string EndDate
    {
        get
        {
            try
            {
                return teklaObject.EndDate;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndDate), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.EndDate = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(EndDate), ex);
            }
        }
    }
    /// <summary>
    /// Object information of the project.
    /// </summary>
    public string Object
    {
        get
        {
            try
            {
                return teklaObject.Object;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Object), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Object = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Object), ex);
            }
        }
    }

    public string Designer
    {
        get
        {
            try
            {
                return teklaObject.Designer;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Designer), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Designer = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Designer), ex);
            }
        }
    }

    public string Location
    {
        get
        {
            try
            {
                return teklaObject.Location;
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
                teklaObject.Location = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Location), ex);
            }
        }
    }

    public string Address
    {
        get
        {
            try
            {
                return teklaObject.Address;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Address), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Address = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Address), ex);
            }
        }
    }

    public string PostalBox
    {
        get
        {
            try
            {
                return teklaObject.PostalBox;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PostalBox), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PostalBox = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PostalBox), ex);
            }
        }
    }

    public string Town
    {
        get
        {
            try
            {
                return teklaObject.Town;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Town), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Town = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Town), ex);
            }
        }
    }

    public string Region
    {
        get
        {
            try
            {
                return teklaObject.Region;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Region), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Region = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Region), ex);
            }
        }
    }

    public string PostalCode
    {
        get
        {
            try
            {
                return teklaObject.PostalCode;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PostalCode), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.PostalCode = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(PostalCode), ex);
            }
        }
    }

    public string Country
    {
        get
        {
            try
            {
                return teklaObject.Country;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Country), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Country = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Country), ex);
            }
        }
    }

    public string Builder
    {
        get
        {
            try
            {
                return teklaObject.Builder;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Builder), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Builder = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Builder), ex);
            }
        }
    }

    public string Name
    {
        get
        {
            try
            {
                return teklaObject.Name;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Name = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Name), ex);
            }
        }
    }

    public string ProjectNumber
    {
        get
        {
            try
            {
                return teklaObject.ProjectNumber;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ProjectNumber), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ProjectNumber = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ProjectNumber), ex);
            }
        }
    }

    public DirectoryInfo ModelSharingLocalPath
    {
        get
        {
            try
            {
                return teklaObject.ModelSharingLocalPath;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ModelSharingLocalPath), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ModelSharingLocalPath = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ModelSharingLocalPath), ex);
            }
        }
    }

    public Uri ModelSharingServerPath
    {
        get
        {
            try
            {
                return teklaObject.ModelSharingServerPath;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ModelSharingServerPath), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ModelSharingServerPath = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ModelSharingServerPath), ex);
            }
        }
    }

    public string Info1
    {
        get
        {
            try
            {
                return teklaObject.Info1;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Info1), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Info1 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Info1), ex);
            }
        }
    }

    public string Info2
    {
        get
        {
            try
            {
                return teklaObject.Info2;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Info2), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Info2 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Info2), ex);
            }
        }
    }

    public string GUID
    {
        get
        {
            try
            {
                return teklaObject.GUID;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(GUID), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.GUID = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(GUID), ex);
            }
        }
    }


    internal dynamic teklaObject;

    internal ProjectInfo() { }
    
    public ProjectInfo(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public bool Modify()
    {

        try
        {
            var result = (bool)teklaObject.Modify();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(Modify), ex);
        }
    }
    public bool GetUserProperty(
            string Name,
            ref string Value)
    {
        try
        {
            var result = (bool)teklaObject.GetUserProperty(Name, ref Value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetUserProperty), ex);
        }
    }

    public bool GetUserProperty(
            string Name,
            ref Int32 Value)
    {
        try
        {
            var result = (bool)teklaObject.GetUserProperty(Name, ref Value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetUserProperty), ex);
        }
    }


    public bool GetUserProperty(
            string Name,
            ref Double Value)
    {
        try
        {
            var result = (bool)teklaObject.GetUserProperty(Name, ref Value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetUserProperty), ex);
        }
    }


    public bool SetUserProperty(
            string Name,
            string Value)
    {
        try
        {
            var result = (bool)teklaObject.SetUserProperty(Name, Value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetUserProperty), ex);
        }
    }

    public bool SetUserProperty(
            string Name,
            Double Value)
    {
        try
        {
            var result = (bool)teklaObject.SetUserProperty(Name, Value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetUserProperty), ex);
        }
    }

    public bool SetUserProperty(
            string Name,
            Int32 Value)
    {
        try
        {
            var result = (bool)teklaObject.SetUserProperty(Name, Value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetUserProperty), ex);
        }
    }

    public bool GetIntegerUserProperties(
            ref Hashtable Values)
    {

        try
        {
            var result = (bool)teklaObject.GetIntegerUserProperties(ref Values);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetIntegerUserProperties), ex);
        }
    }

    public bool GetDoubleUserProperties(
            ref Hashtable Values)
    {

        try
        {
            var result = (bool)teklaObject.GetDoubleUserProperties(ref Values);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDoubleUserProperties), ex);
        }
    }



    public bool GetStringUserProperties(
            ref Hashtable Values)
    {

        try
        {
            var result = (bool)teklaObject.GetStringUserProperties(ref Values);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetStringUserProperties), ex);
        }
    }



    public bool GetDynamicStringProperty(
            string Name,
            ref string Value)
    {
        try
        {
            var result = (bool)teklaObject.GetDynamicStringProperty(Name, ref Value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetDynamicStringProperty), ex);
        }
    }



    public bool SetDynamicStringProperty(
            string Name,
            string Value)
    {
        try
        {
            var result = (bool)teklaObject.SetDynamicStringProperty(Name, Value);

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(SetDynamicStringProperty), ex);
        }
    }



    public static List<BasePoint> GetBasePoints()
    {
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "GetBasePoints");
        var _result = ListConverter.FromTSObjects<BasePoint>(result);
        return _result;
    }
    public static BasePoint GetBasePointByName(
            string name)
    {
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "GetBasePointByName", name);
        var _result = BasePoint_.FromTSObject(result);
        return _result;
    }

    public static BasePoint GetBasePointByGuid(
            Guid guid)
    {
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "GetBasePointByGuid", guid);
        var _result = BasePoint_.FromTSObject(result);
        return _result;
    }

    public static BasePoint GetCurrentCoordsysBasePoint()
    {
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "GetCurrentCoordsysBasePoint");
        var _result = BasePoint_.FromTSObject(result);
        return _result;
    }

    public static bool SetCurrentCoordsysToBasePoint(
            BasePoint basePoint_)
    {
        var basePoint = BasePoint_.GetTSObject(basePoint_);
        var result = (bool)MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "SetCurrentCoordsysToBasePoint", basePoint);
        return result;
    }

    public static BasePoint GetProjectBasePoint()
    {
        var result = MethodInvoker.InvokeStaticMethod("Tekla.Structures.Model.ProjectInfo", "GetProjectBasePoint");
        var _result = BasePoint_.FromTSObject(result);
        return _result;
    }
}

internal static class ProjectInfo_
{
    public static dynamic GetTSObject(ProjectInfo dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ProjectInfo FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (ProjectInfo)Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

