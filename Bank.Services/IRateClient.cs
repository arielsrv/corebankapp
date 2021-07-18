using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bank.Services
{
    public interface IRateClient
    {
        Task<List<RateResponse>> GetRates();
    }
}