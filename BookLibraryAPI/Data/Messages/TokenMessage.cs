namespace BookLibraryAPI.Data.Messages
{
    public class TokenMessage
    {
        public string Message { get; set; }
        public string Token { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ValidTo { get; set; }

        public TokenMessage(string message, string token) 
        { 
            Message = message;
            Token = token;
            CreatedAt = DateTime.Now;
            ValidTo = CreatedAt.AddHours(1);
        }
    }
}
