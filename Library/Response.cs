using Newtonsoft.Json;

namespace Library
{
    public class Response
    {
        [JsonProperty("query")]
        public string Ip;

        [JsonProperty("city")]
        public string City;

        [JsonProperty("country")]
        public string Country;

        public Response(string ip, string city, string country)
        {
            Ip = ip;
            City = city;
            Country = country;
        }
    }
}
