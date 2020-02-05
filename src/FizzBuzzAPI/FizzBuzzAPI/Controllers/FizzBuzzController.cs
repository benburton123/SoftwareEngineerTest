using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return null;
        }
    }
}
