namespace WinformApp.APIControll
{
    public class ApiResponse<T>
    {
        public string Status { get; set; } 
        public T Data { get; set; }
    }
}
