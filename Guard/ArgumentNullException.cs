namespace LuPerfect.Exceptions
{
    public class GuardArgumentNullException : ArgumentNullException, IGuardException
    {
        public GuardArgumentNullException(string parameterName) : base(parameterName)
        {
        }

        public GuardArgumentNullException(string parameterName, Exception? exception) : base(parameterName, exception)
        {
        }
    }
}
