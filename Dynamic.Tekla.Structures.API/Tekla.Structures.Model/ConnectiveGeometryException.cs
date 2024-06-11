using Dynamic.Tekla.Structures.Internal;
using Dynamic.Tekla.Structures.Internal.Exceptions;
using System;

namespace Dynamic.Tekla.Structures.Model;


public class ConnectiveGeometryException : Exception
{

    public BentPlateGeometrySolver.OperationStatus OperationStatus
    {
        get
        {
            try
            {
                var value = teklaObject.OperationStatus;
                var value_ = BentPlateGeometrySolver.OperationStatus_.FromTSObject(value);
                return (BentPlateGeometrySolver.OperationStatus)value_;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                throw DynamicAPINotFoundException.CouldNotFindProperty(nameof(OperationStatus), ex);
            }
        }

    }


    internal dynamic teklaObject;

    public ConnectiveGeometryException()
    {
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConnectiveGeometryException");
    }

    public ConnectiveGeometryException(dynamic tsObject, System.DateTime nonConflictParameter)
    {
        teklaObject = tsObject;
    }
    public ConnectiveGeometryException(BentPlateGeometrySolver.OperationStatus status, string errorMessage)
    {
        var args = new object[2];
        args[0] = BentPlateGeometrySolver.OperationStatus_.GetTSObject(status);
        args[1] = errorMessage;
        teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.ConnectiveGeometryException", args);
    }
}

internal static class ConnectiveGeometryException_
{
    public static dynamic GetTSObject(ConnectiveGeometryException dynObject)
    {
        if (dynObject is null) return null;
        return dynObject.teklaObject;
    }

    public static ConnectiveGeometryException FromTSObject(dynamic tsObject)
    {
        if (tsObject is null) return null;
        var typeName = "Dynamic." + tsObject.GetType().FullName;
        var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

        var parameters = new object[2];
        parameters[0] = tsObject;
        parameters[1] = new System.DateTime();

        var dynObject = (ConnectiveGeometryException)System.Activator.CreateInstance(type, parameters);
        dynObject.teklaObject = tsObject;
        return dynObject;
    }
}

internal static class ConnectiveGeometryExceptionArray_
{
    public static dynamic GetTSObject(ConnectiveGeometryException[] dynArray)
    {
        if (dynArray is null) return null;
        var list = new System.Collections.Generic.List<dynamic>();
        foreach (var dynItem in dynArray)
        {
            list.Add(ConnectiveGeometryException_.GetTSObject(dynItem));
        }
        return list.ToArray();
    }

    public static ConnectiveGeometryException[] FromTSObject(dynamic[] tsArray)
    {
        if (tsArray is null) return null;
        var list = new System.Collections.Generic.List<ConnectiveGeometryException>();
        foreach (var tsItem in tsArray)
        {
            list.Add(ConnectiveGeometryException_.FromTSObject(tsItem));
        }
        return list.ToArray();
    }
}

