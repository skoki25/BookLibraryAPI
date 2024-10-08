using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using BookLibrary.Model.Messages;
using BookLibrary.Models;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinformApp.APIControll
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        public event Action<Exception> OnErrorMessage;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task Delete(string endpoint, int id, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultMessage<T>> GetAsync<T>(string endpoint, string token)
        {
            AddAuthorizationHeader(token);
            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            ResultMessage<T> resultMessage = JsonConvert.DeserializeObject<ResultMessage<T>>(jsonResponse);
            if (resultMessage.Data == null)
            {
                throw new ArgumentNullException("No data");
            }
            return resultMessage;

        }

        public async Task<ResultMessage<T>> GetAsync<T>(string endpoint, int id, string token)
        {
            AddAuthorizationHeader(token);
            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            ResultMessage<T> resultMessage = JsonConvert.DeserializeObject<ResultMessage<T>>(jsonResponse);
            if (resultMessage.Data == null)
            {
                throw new ArgumentNullException("No data");
            }
            return resultMessage;
        }

        public async Task<ResultMessage<T>> PostAsync<T>(string endpoint, object body)
        {
            string jsonContent = JsonConvert.SerializeObject(body);
            HttpContent content = new StringContent(jsonContent,Encoding.UTF8,"application/json");
            HttpResponseMessage response = await _httpClient.PostAsync(endpoint, content);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            ResultMessage<T> resultMessage = JsonConvert.DeserializeObject<ResultMessage<T>>(jsonResponse);
            if (resultMessage.Data == null)
            {
                throw new ArgumentNullException("No data");
            }
            return resultMessage;
        }

        public async Task<ResultMessage<T>> PostAsync<T>(string endpoint, object body, string token)
        {
            AddAuthorizationHeader(token);
            string jsonContent = JsonConvert.SerializeObject(body);
            HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync(endpoint, content);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            ResultMessage<T> resultMessage = JsonConvert.DeserializeObject<ResultMessage<T>>(jsonResponse);
            if (resultMessage.Data == null)
            {
                throw new ArgumentNullException("No data");
            }
            return resultMessage;
        }

        public async Task<ResultMessage<T>> PutAsync<T>(string endpoint, object body, string token)
        {
            AddAuthorizationHeader(token);
            string jsonContent = JsonConvert.SerializeObject(body);
            HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PutAsync(endpoint, content);

            string jsonResponse = await response.Content.ReadAsStringAsync();
            ResultMessage<T> resultMessage = JsonConvert.DeserializeObject<ResultMessage<T>>(jsonResponse);
            if (resultMessage.Data == null)
            {
                throw new ArgumentNullException("No data");
            }
            return resultMessage;
        }

        private void AddAuthorizationHeader(string token)
        {
            if(!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }

        public void ErrorMessage(Exception message)
        {
            throw new NotImplementedException();
        }
    }
}
