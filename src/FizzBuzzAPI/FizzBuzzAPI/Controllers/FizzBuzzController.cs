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
            string result = "";

            for (int i = startIndex; i <= finishIndex; i++)
            {
                if (i % 3 != 0 && i % 5 != 0) result += $"{i} ";
            }

            return new FizzBuzzResponse
            {
                Result = result.TrimEnd()
            };
        }
    }
}
