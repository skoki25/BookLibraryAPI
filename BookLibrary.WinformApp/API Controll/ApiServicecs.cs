using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinformApp.APIControll
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task Delete(string endpoint, int id, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetAsync<T>(string endpoint, string token)
        {
            AddAuthorizationHeader(token);
            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }

        public async Task<T> GetAsync<T>(string endpoint, int id, string token)
        {
            AddAuthorizationHeader(token);
            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }

        public async Task<T> PostAsync<T>(string endpoint, object body)
        {
            string jsonContent = JsonConvert.SerializeObject(body);
            HttpContent content = new StringContent(jsonContent,Encoding.UTF8,"application/json");
            HttpResponseMessage response = await _httpClient.PostAsync(endpoint, content);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }

        public async Task<T> PostAsync<T>(string endpoint, object body, string token)
        {
            AddAuthorizationHeader(token);
            string jsonContent = JsonConvert.SerializeObject(body);
            HttpContent content = new StringContent(jsonContent);
            HttpResponseMessage response = await _httpClient.PostAsync(endpoint, content);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }

        public async Task<T> PutAsync<T>(string endpoint, object body, string token)
        {
            AddAuthorizationHeader(token);
            string jsonContent = JsonConvert.SerializeObject(body);
            HttpContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PutAsync(endpoint, content);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }

        private void AddAuthorizationHeader(string token)
        {
            if(!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }
    }
}
