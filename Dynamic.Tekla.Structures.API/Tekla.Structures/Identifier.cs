using Dynamic.Tekla.Structures.Internal.Exceptions;
using Dynamic.Tekla.Structures.Internal;
using System;
using System.Collections.Generic;

namespace Dynamic.Tekla.Structures;
/// <summary>
/// The Identifier class represents an identifier that holds information
/// about the identifier number of an object.
/// </summary>
public sealed class Identifier
{
    public int ID
    {
        get
        {
            try
            {
                return teklaObject.ID;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ID), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ID = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ID), ex);
            }
        }
    }

    public int ID2
    {
        get
        {
            try
            {
                return teklaObject.ID2;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ID2), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ID2 = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ID2), ex);
            }
        }
    }

    public Guid GUID
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

    public Identifier()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Identifier");
    }
    
    public Identifier(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public Identifier(int id)
    {
        var args = new object[1];
        args[0] = id;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Identifier", args);
    }
    public Identifier(Guid guid)
    {
        var args = new object[1];
        args[0] = guid;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Identifier", args);
    }
    public Identifier(string guid)
    {
        var args = new object[1];
        args[0] = guid;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Identifier", args);
    }

    public bool IsValid()
    {

        try
        {
            var result = (Boolean)teklaObject.IsValid();

            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(IsValid), ex);
        }
    }
}

internal static class Identifier_
{
    public static dynamic GetTSObject(Identifier dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Identifier FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Dynamic.Tekla.Structures.Identifier)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
