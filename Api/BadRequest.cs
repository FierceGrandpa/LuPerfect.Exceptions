using System.Net;

namespace LuPerfect.Exceptions
{
    public class BadRequestException : ApiException
    {
        public BadRequestException(string? message = "BadRequest.") : base(HttpStatusCode.BadRequest, message) { }
    }
}
