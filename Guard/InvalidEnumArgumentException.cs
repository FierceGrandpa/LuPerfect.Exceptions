using System.ComponentModel;

namespace LuPerfect.Exceptions
{
    public class GuardInvalidEnumArgumentException : InvalidEnumArgumentException, IGuardException
    {
        public GuardInvalidEnumArgumentException(string? message) : base(message)
        {
        }

        public GuardInvalidEnumArgumentException(string? argumentName, int invalidValue, Type enumClass) : base(argumentName, invalidValue, enumClass)
        {
        }
    }
}
