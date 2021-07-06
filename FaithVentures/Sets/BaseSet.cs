using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FaithVentures.Models;
using FiftytwoProjects.Core.Extensions;
using Newtonsoft.Json;

namespace FaithVentures.Sets {
    public class BaseSet<T> where T : new() {
        private readonly FaithVenturesOptions _options;

        public BaseSet(FaithVenturesOptions options) {
            _options = options;
        }

        internal async Task<IFaithVenturesSearchResponse<T>> PostAsync(string url, object entity) {
            using (var http = CreateClient()) {
                string json = JsonConvert.SerializeObject(entity);
                json = json.Replace("False", "false").Replace("True", "true");
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                var task = http.PostAsync(url, httpContent);
                Task.WaitAll(task);
                var response = task.Result;
                return await ConvertResponseAsync<T>(response);
            }
        }
                
        private HttpClient CreateClient() {
            var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(10);
            httpClient.BaseAddress = new Uri(_options.ApiUrl);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (_options.ApiAuthUsername.HasValue()) {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("BASIC",
                    Convert.ToBase64String(Encoding.ASCII.GetBytes(_options.ApiAuthUsername + ":" + _options.ApiAuthPassword)));
            }
            httpClient.DefaultRequestHeaders.Add("API-Token-Public-Key", _options.ApiTokenPublicKey);
            httpClient.DefaultRequestHeaders.Add("API-Token-Private-Key", _options.ApiTokenPrivateKey);
            return httpClient;
        }

        private async Task<IFaithVenturesSearchResponse<S>> ConvertResponseAsync<S>(HttpResponseMessage response) where S : new() {
            var faithVenturesResponse = new FaithVenturesSearchResponse<S>();

                if ((int)response.StatusCode == 200) {
                    try {
                        var responseBody = await response.Content.ReadAsStringAsync();
                        faithVenturesResponse = JsonConvert.DeserializeObject<FaithVenturesSearchResponse<S>>(responseBody);
                    }
                    catch (Exception e) {
                        throw;
                    }
                }

            return faithVenturesResponse;
        }
    }
}