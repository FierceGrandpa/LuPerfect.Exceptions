namespace LuPerfect.Exceptions
{
    public class GuardArgumentException : ArgumentException, IGuardException
    {
        public GuardArgumentException(string? message) : base(message)
        {
        }

        public GuardArgumentException(string? message, string? paramName) : base(message, paramName)
        {
        }
    }
}
