using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bank.Services
{
    public interface IRateService
    {
        Task<List<RateDto>> GetRates();
    }
}