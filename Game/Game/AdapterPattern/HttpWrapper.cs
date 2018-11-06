using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Game.AdapterPattern
{
    public class HttpWrapper {
        HttpClient _client;
        private DebugLogSingleton _singleton;

        string apiUrl = "https://towerdefenseapi.azurewebsites.net/api/baloons/";

        public HttpWrapper(HttpClient client) {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            _client = client;
            _client.BaseAddress = new Uri(apiUrl);
            _singleton = DebugLogSingleton.GetInstance();
        }

        public async Task<T> Get<T>(string path) {
            var response = await _client.GetAsync(path);
            _singleton.Log<HttpWrapper>("Adapter", "Called API GET and converted json response to object.");

            return await ConvertResponseToObject<T>(response.Content);
        }

        public async Task<T> Post<T>(string path, object param) {
            var response = await _client.PostAsync(path, new StringContent(JsonConvert.SerializeObject(param)));

            return await ConvertResponseToObject<T>(response.Content);
        }

        private async Task<T> ConvertResponseToObject<T>(HttpContent content) {
            var result = await content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
