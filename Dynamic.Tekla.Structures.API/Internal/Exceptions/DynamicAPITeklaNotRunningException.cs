using System;

namespace Dynamic.Tekla.Structures.Internal.Exceptions;

public class DynamicAPITeklaNotRunningException : Exception
{
    public DynamicAPITeklaNotRunningException() : base("Tekla Structures is not running")
    { }
}
