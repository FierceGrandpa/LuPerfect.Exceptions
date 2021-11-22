using System.Net;

namespace LuPerfect.Exceptions
{
    public class NotFoundException<TKey> : ApiException 
        where TKey : struct
    {
        public NotFoundException()
            : base(HttpStatusCode.NotFound, "Not found.") { }

        public NotFoundException(string name, TKey id) 
            : base(HttpStatusCode.NotFound, $"Entity \"{name}\" [id: {id}] was not found.") { }

        public NotFoundException(string name, TKey id, Exception? innerException)
            : base(HttpStatusCode.NotFound, $"Entity \"{name}\" [id: {id}] was not found.", innerException) { }
    }
}
