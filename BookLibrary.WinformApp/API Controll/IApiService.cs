

using BookLibrary.Model.Messages;

namespace WinformApp.APIControll
{
    public interface IApiService
    {
        Task<ResultMessage<T>> GetAsync<T>(string endpoint,string token);
        Task<ResultMessage<T>> GetAsync<T>(string endpoint,int id,string token);
        Task<ResultMessage<T>> PostAsync<T>(string endpoint, object body);
        Task<ResultMessage<T>> PostAsync<T>(string endpoint, object body,string token);
        Task<ResultMessage<T>> PutAsync<T>(string endpoint, object body,string token);
        Task Delete(string endpoint,int id,string token);
    }
}
