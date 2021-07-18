#nullable enable
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Bank.Api.Services
{
    internal class RateClient : IRateClient
    {
        private readonly HttpClient httpClient;

        public RateClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<RateResponse>?> GetRates()
        {
            const string url = "http://quiet-stone-2094.herokuapp.com/rates.json";
            string responseString = await httpClient.GetStringAsync(url);

            List<RateResponse>? result = JsonConvert.DeserializeObject<List<RateResponse>>(responseString);
            return result;
        }
    }
}