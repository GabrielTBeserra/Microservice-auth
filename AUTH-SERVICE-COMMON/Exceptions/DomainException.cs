using System;

namespace AUTH_SERVICE_COMMON.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
