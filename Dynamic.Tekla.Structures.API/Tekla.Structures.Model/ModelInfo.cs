using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;

namespace Dynamic.Tekla.Structures.Model;

/// <summary>
/// The ModelInfo class provides information about the currently open Tekla Structures model
/// </summary>
public class ModelInfo
{
    /// <summary>
    /// The north direction of the current Tekla Structures model.
    /// </summary>
    public double NorthDirection
    {
        get
        {
            try
            {
                return teklaObject.NorthDirection;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NorthDirection), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.NorthDirection = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(NorthDirection), ex);
            }
        }
    }
    /// <summary>
    /// The path to the Tekla Structures model.
    /// </summary>
    public string ModelPath
    {
        get
        {
            try
            {
                return teklaObject.ModelPath;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ModelPath), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ModelPath = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ModelPath), ex);
            }
        }
    }
    /// <summary>
    ///  The name of the Tekla Structures model.
    /// </summary>
    public string ModelName
    {
        get
        {
            try
            {
                return teklaObject.ModelName;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ModelName), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.ModelName = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(ModelName), ex);
            }
        }
    }
    /// <summary>
    /// The number of the Tekla Structures model's current phase.
    /// </summary>
    public int CurrentPhase
    {
        get
        {
            try
            {
                return teklaObject.CurrentPhase;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CurrentPhase), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.CurrentPhase = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(CurrentPhase), ex);
            }
        }
    }
    /// <summary>
    /// The read-only property of the Tekla Structures model's sharing status.
    /// </summary>
    public bool SharedModel
    {
        get
        {
            try
            {
                return teklaObject.SharedModel;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SharedModel), ex);
            }
        }

    }
    /// <summary>
    /// The read-only property if the Tekla Structures model is a single user model.
    /// </summary>
    public bool SingleUserModel
    {
        get
        {
            try
            {
                return teklaObject.SingleUserModel;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(SingleUserModel), ex);
            }
        }

    }

    internal dynamic teklaObject;

    internal ModelInfo() { }

    public ModelInfo(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
}

internal static class ModelInfo_
{
    public static dynamic GetTSObject(ModelInfo dynObject)
    {
        return dynObject?.teklaObject;
    }

    public static ModelInfo FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        dynamic typeName = "Dynamic." + tsObject.GetType().FullName;
        dynamic type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        object[] parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        ModelInfo dynObject = (ModelInfo)Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
