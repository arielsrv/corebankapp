using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bank.Api.Services
{
    public interface IRateService
    {
        Task<List<RateDto>> GetRates();
    }
}