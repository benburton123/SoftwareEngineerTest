using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FizzBuzzController : ControllerBase
    {
        [HttpGet("{startIndex}/{finishIndex}")]
        public FizzBuzzResponse Get(int startIndex, int finishIndex)
        {
            return new FizzBuzzResponse
            {
                Result = "2"
            };
        }
    }
}
