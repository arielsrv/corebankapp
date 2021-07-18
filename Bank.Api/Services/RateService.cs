using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank.Api.Services
{
    public class RateService : IRateService
    {
        private readonly IRateClient rateClient;

        public RateService(IRateClient rateClient)
        {
            this.rateClient = rateClient;
        }

        public async Task<List<RateDto>> GetRates()
        {
            List<RateResponse>? response = await rateClient.GetRates();

            List<RateDto> result = new();

            if (response != null)
                result
                    .AddRange(response.Select(rateResponse => new RateDto
                    {
                        From = rateResponse.From,
                        To = rateResponse.To,
                        Rate = rateResponse.Rate
                    }));

            return result;
        }
    }
}