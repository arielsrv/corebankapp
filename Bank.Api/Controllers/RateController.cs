using System.Collections.Generic;
using System.Threading.Tasks;
using Bank.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RateController : ControllerBase
    {
        private readonly IRateService rateService;

        public RateController(IRateService rateService)
        {
            this.rateService = rateService;
        }

        [HttpGet("/rates")]
        public Task<List<RateDto>> GetGetRates()
        {
            return rateService.GetRates();
        }
    }
}