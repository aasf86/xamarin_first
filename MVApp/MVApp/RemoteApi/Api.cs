using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVApp.RemoteApi
{
    public static class Api
    {
        public static async Task<List<Model.User>> GetUsersAsync(string search)
        {
            using (var hC = new HttpClient())
            {
                hC.BaseAddress = new Uri("http://jsonplaceholder.typicode.com");
                var json = await hC.GetStringAsync("/users");
                var users = JsonConvert.DeserializeObject<List<Model.User>>(json);
                return users;
            }            
        }
    }
}
