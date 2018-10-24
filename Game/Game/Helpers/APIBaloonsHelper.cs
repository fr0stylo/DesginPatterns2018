using Game.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Game.Helpers
{
    public class APIBaloonsHelper
    {
       // string apiUrl = "http://localhost:5000/api/baloons/";  //"https://towerdefenseapi.azurewebsites.net/api/baloons/";
        string apiUrl = "https://towerdefenseapi.azurewebsites.net/api/baloons/";
        public string GetBaloonById(string id)
        {
            // calling local api - no problem. calling azure - crash. requesting from postman/web browser - works. what
            // the fuck
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(apiUrl);
            HttpResponseMessage response = client.GetAsync("1").Result;

            var res = response.Content.ToString();



            return res;
        }
    }
}
