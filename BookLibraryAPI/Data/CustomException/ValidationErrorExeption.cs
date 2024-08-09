namespace BookLibraryAPI.Data.CustomException
{
    public class ValidationErrorExeption: Exception
    {
        public ValidationErrorExeption(string message) : base(message) { }
    }
}
