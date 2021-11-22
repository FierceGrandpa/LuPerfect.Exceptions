namespace LuPerfect.Exceptions
{
    public class GuardNotFoundException<TKey> : NotFoundException<TKey>, IGuardException 
        where TKey : struct
    {
        public GuardNotFoundException(string name, TKey id) : base(name, id)
        {
        }
    }
}
