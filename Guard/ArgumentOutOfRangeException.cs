namespace LuPerfect.Exceptions
{
    public class GuardArgumentOutOfRangeException : ArgumentOutOfRangeException, IGuardException
    {
        public GuardArgumentOutOfRangeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public GuardArgumentOutOfRangeException(string? paramName, string? message) : base(paramName, message)
        {
        }
    }
}
