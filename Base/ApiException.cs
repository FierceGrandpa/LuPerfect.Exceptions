using System.Net;

namespace LuPerfect.Exceptions
{
    public class ApiException : Exception
    {
        public int StatusCode { get; set; }
        public string? Details { get; set; }

        public ApiException(int statusCode) => StatusCode = statusCode;
        public ApiException(HttpStatusCode statusCode) : this((int)statusCode) { }

        public ApiException(int statusCode, string? message) : base(message) { StatusCode = statusCode; }
        public ApiException(HttpStatusCode statusCode, string? message) : this((int)statusCode, message) { }

        public ApiException(HttpStatusCode statusCode, string? message, Exception? innerException) 
            : base(message, innerException)
        {
            StatusCode = (int)statusCode;
        }

        public ApiException(int statusCode, string? message, string? details) : this(statusCode, message) 
            => Details = details;
        public ApiException(HttpStatusCode statusCode, string? message, string? details) 
            : this((int)statusCode, message, details) { }
    }
}