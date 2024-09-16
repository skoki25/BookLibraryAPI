namespace BookLibrary.Model.Messages
{
    public class ResultMessage<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get;set; }
        public T? Data { get;set; }    
        public DateTime Date { get; set; }
        public List<string> Errors { get; set; }

        public ResultMessage(bool success, T? data)
        {
            Data = data;
            IsSuccess = success;
            Message = "Success";
            Date = DateTime.Now;
            Errors = new List<string>();
        }

        public ResultMessage(string error)
        {
            IsSuccess = false;
            Message = error;
            Date = DateTime.Now;
            Errors = new List<string>();
        }

        public ResultMessage() { }
    }
}
