using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;
using System.Reflection;

namespace Dynamic.Tekla.Structures;

/// <summary>
/// Defines an assertion by the method it failed in and the messages it provided.
/// </summary>
public class Assertion
{
    public string Message
    {
        get
        {
            try
            {
                return teklaObject.Message;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Message), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.Message = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(Message), ex);
            }
        }
    }

    public string DetailedMessage
    {
        get
        {
            try
            {
                return teklaObject.DetailedMessage;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DetailedMessage), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.DetailedMessage = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(DetailedMessage), ex);
            }
        }
    }

    public string MethodName
    {
        get
        {
            try
            {
                return teklaObject.MethodName;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MethodName), ex);
            }
        }
        set
        {
            try
            {
                teklaObject.MethodName = value;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(MethodName), ex);
            }
        }
    }

    internal dynamic teklaObject;

    internal Assertion() { }
    public Assertion(dynamic tsObject, DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public Assertion(string message, string detailedMessage, string methodName)
    {
        var args = new object[3];
        args[0] = message;
        args[1] = detailedMessage;
        args[2] = methodName;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Assertion", args);
    }
    public override string ToString()
    {
        return string.Format("Message: {0}{1}Detail: {2}{1}Method: {3}{1}", Message ?? "<No Message>", Environment.NewLine, DetailedMessage ?? "<No Detail>", MethodName);
    }
    public override bool Equals(object obj)
    {
        Assertion assertion = obj as Assertion;
        if (assertion == null)
        {
            return false;
        }

        if (Message == assertion.Message && DetailedMessage == assertion.DetailedMessage)
        {
            return MethodName == assertion.MethodName;
        }

        return false;
    }
    public override int GetHashCode()
    {
        return MethodName.GetHashCode() ^ ((DetailedMessage != null) ? DetailedMessage.GetHashCode() : 0) ^ ((Message != null) ? Message.GetHashCode() : 0);
    }
}
internal static class Assertion_
{
    public static dynamic GetTSObject(Assertion dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static Assertion FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new DateTime();

        var dynObject = (Assertion)Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}
