using System;
using System.Runtime.Serialization;

namespace Client.Exceptions
{
    public class UnhandledException : Exception
    {
        public string ErrorMessage { get; set; }

        public UnhandledException() => ErrorMessage = string.Empty;

        public UnhandledException(string mes) => ErrorMessage = mes;

        protected UnhandledException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            ErrorMessage = string.Empty;
        }
    }
}
