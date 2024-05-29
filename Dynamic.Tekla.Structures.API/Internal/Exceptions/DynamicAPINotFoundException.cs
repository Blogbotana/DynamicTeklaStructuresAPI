using System;

namespace Dynamic.Tekla.Structures.Internal.Exceptions;

public class DynamicAPINotFoundException : DynamicAPIException
{
    public DynamicAPINotFoundException(string message) 
        : base (message + TeklaVersion())
    {  }

    public DynamicAPINotFoundException(string message, Exception innerException) 
        :base(message + TeklaVersion(), innerException)
    { }

    public DynamicAPINotFoundException() : base()
    { }

    public static DynamicAPINotFoundException CouldNotFindMethod(string methodName, Exception innerException)
    {
        return new DynamicAPINotFoundException("Could not find method " + methodName + " in current Tekla API", innerException);
    }

    public static DynamicAPINotFoundException CouldNotFindProperty(string propertyName, Exception innerException)
    {
        return new DynamicAPINotFoundException("Could not find property " + propertyName + " in current Tekla API", innerException);
    }
}
