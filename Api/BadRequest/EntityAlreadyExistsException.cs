namespace LuPerfect.Exceptions
{
    public class EntityAlreadyExistsException : BadRequestException
    {
        public EntityAlreadyExistsException(string? message = null) : base(message) {}
    }
}