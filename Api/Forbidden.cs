using System.Net;

namespace LuPerfect.Exceptions
{
    public class ForbiddenException : ApiException
    {
        public ForbiddenException(string? message = "Forbidden.") : base(HttpStatusCode.Forbidden, message) { }
    }
}
