using Contacts.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Services
{
    public class RandomUserService
    {
        public async Task<RandomUserData> GetUserData(int size)
        {
            var client = new HttpClient();

            var response = await client.GetAsync($"https://randomuser.me/api/?results={size}&seed=dfwmobilenet");

            var json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<RandomUserData>(json);
        }
    }
}
