using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using FaithVentures.Models;
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
                var response = await http.PostAsync(url, httpContent);
                return await ConvertResponseAsync<T>(response);
            }
        }
                
        private HttpClient CreateClient() {
            var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(10);
            httpClient.BaseAddress = new Uri(_options.ApiUrl);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("BASIC",
                Convert.ToBase64String(Encoding.ASCII.GetBytes(_options.ApiAuthUsername + ":" + _options.ApiAuthPassword)));
            httpClient.DefaultRequestHeaders.Add("API-Token-Public-Key", _options.ApiTokenPublicKey);
            httpClient.DefaultRequestHeaders.Add("API-Token-Private-Key", _options.ApiTokenPrivateKey);
            return httpClient;
        }

        private async Task<IFaithVenturesSearchResponse<S>> ConvertResponseAsync<S>(HttpResponseMessage response) where S : new() {
            var faithVenturesResponse = new FaithVenturesSearchResponse<S>();

                if ((int)response.StatusCode == 200) {
                    try {
                        faithVenturesResponse = JsonConvert.DeserializeObject<FaithVenturesSearchResponse<S>>(await response.Content.ReadAsStringAsync());
                    }
                    catch (Exception e) {
                        throw;
                    }
                }

            return faithVenturesResponse;
        }
    }
}