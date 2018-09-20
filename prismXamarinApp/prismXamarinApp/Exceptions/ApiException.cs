using System;
using System.Net;

namespace prismXamarinApp.Exceptions
{
    public class ApiException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool Connection { get; set; }

        public ApiException(string message, HttpStatusCode statusCode)
            : base(message)
        {
            StatusCode = statusCode;
            Connection = true;
        }

        public ApiException(string message, bool connection, Exception inner)
            : base(message, inner)
        {
            Connection = connection;
            StatusCode = HttpStatusCode.ServiceUnavailable;
        }
    }
    public class ApiExceptionError
    {
        public string Message { get; set; }
    }
}
