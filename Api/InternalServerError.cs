using System.Net;

namespace LuPerfect.Exceptions
{
    public class InternalServerError : ApiException
    {
        public InternalServerError(string? message = "Something went wrong...") : base(HttpStatusCode.InternalServerError, message) { }
    }
}
