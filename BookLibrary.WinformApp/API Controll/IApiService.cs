

namespace WinformApp.APIControll
{
    public interface IApiService
    {
        Task<T> GetAsync<T>(string endpoint,string token);
        Task<T> GetAsync<T>(string endpoint,int id,string token);
        Task<T> PostAsync<T>(string endpoint, object body);
        Task<T> PostAsync<T>(string endpoint, object body,string token);
        Task<T> PutAsync<T>(string endpoint,int id, object body,string token);
        Task Deletesync(string endpoint,int id,string token);
    }
}
