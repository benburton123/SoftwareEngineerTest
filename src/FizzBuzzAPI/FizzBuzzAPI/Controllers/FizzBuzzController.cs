using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
            int integerCount = 0;

            for (int i = startIndex; i <= finishIndex; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    result += $"{i} ";
                    integerCount++;
                }
            }

            var response = new FizzBuzzResponse
            {
                Result = result.TrimEnd(),
                Summary = new Dictionary<string, int>
                {
                    { "integer", integerCount }
                }
            };

            return response;
        }
    }
}
