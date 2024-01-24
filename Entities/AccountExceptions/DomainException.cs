namespace ExercicioExcecao.Entities.AccountExceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base (message)
        {

        }
    }
}