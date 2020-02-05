using FizzBuzzAPI.Rules;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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

            var rules = new List<IRule>
            {
                new FizzBuzzRule(),
                new FizzRule(),
                new BuzzRule(),
                new IntegerRule()
            };

            for (int i = startIndex; i <= finishIndex; i++)
            {
                foreach (var rule in rules)
                {
                    if (rule.Run(i))
                    {
                        result += $"{rule.Output} ";
                        break;
                    }
                }
            }

            var response = new FizzBuzzResponse
            {
                Result = result.TrimEnd(),
                Summary = rules.ToDictionary(rule => rule.Name, rule => rule.TotalPasses)
            };

            return response;
        }
    }
}
