using Dynamic.Tekla.Structures.Internal;
using System;

namespace Dynamic.Tekla.Structures.Internal.Exceptions
{
    public class DynamicAPIException : Exception
    {
        public DynamicAPIException(string message) 
            : base (message + TeklaVersion())
        { }

        public DynamicAPIException(string message, Exception innerException) 
            :base(message + TeklaVersion(), innerException)
        { }

        public DynamicAPIException() : base()
        { }

        protected static string TeklaVersion()
        {
            return "\nCurrent tekla version = " + TeklaProcess.TeklaFileVersion.ToString();
        }
    }
}
