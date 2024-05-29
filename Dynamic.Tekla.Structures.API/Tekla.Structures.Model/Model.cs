using Dynamic.Tekla.Structures.Internal;
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
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Model");
    }
    public Model(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    /// <summary>
    ///Returns true if a proper connection to the Tekla Structures process has been
    ///established. Currently, there's no way to re-establish the connection.
    /// </summary>
    /// <returns>True on success</returns>
    public bool GetConnectionStatus()
    {
        try
        {
            bool result = (bool)teklaObject.GetConnectionStatus();
            return result;
        }
        catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
        {
            throw DynamicAPINotFoundException.CouldNotFindMethod(nameof(GetConnectionStatus), ex);
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
