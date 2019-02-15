using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class IpDataRetriever
    {
        private static HttpClient _httpClient = new HttpClient();

        public static async Task<Response[]> GetResponse(IEnumerable<string> ipArray)
        {
            var requestArray = ipArray.Select(ip => new RequestContainer(ip)).ToArray();

            var json = JsonConvert.SerializeObject(requestArray);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("http://ip-api.com/batch", content);

            var responseString = await response.Content.ReadAsStringAsync();

            var res = JsonConvert.DeserializeObject<Response[]>(responseString);

            return res;
        }
    }
}
