using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Game.Helpers
{
    class APIGameHelper
    {
        string apiUrl = "https://towerdefenseapi.azurewebsites.net/api/baloons/";
        public async Task<string> GetBaloonById(string id)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(apiUrl);
            HttpResponseMessage response =  await client.GetAsync("1");
            var res = response.Content.ToString();
            return res;
        }
    }
}
