namespace BookLibrary.Model.Messages
{
    public class ResultMessage<T>
    {
        public bool IsSuccess {get;set;}
        public string Message { get;set; }

        public T? Data { get;set; }    

        public DateTime Date { get; set; }

        public ResultMessage(string message,bool success, T? data)
        {
            Data = data;
            IsSuccess = success;
            Message = message;
            Date = DateTime.Now;
        }

        public ResultMessage(string error)
        {
            IsSuccess = false;
            Message = error;
            Date = DateTime.Now;
        }
    }
}
