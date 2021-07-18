using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bank.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet("/ping")]
        public Task<string> Ping()
        {
            return Task.FromResult("pong");
        }
    }
}