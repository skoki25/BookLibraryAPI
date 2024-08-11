namespace BookLibraryAPI.Data.Messages
{
    public class ErrorMessage
    {
        public string Error { get;set; }
        public DateTime Date { get; set; }

        public ErrorMessage(string error)
        {
            Error = error;
            Date = DateTime.Now;
        }   
    }
}
