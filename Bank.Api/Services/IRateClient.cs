using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bank.Api.Services
{
    public interface IRateClient
    {
        Task<List<RateResponse>?> GetRates();
    }
}