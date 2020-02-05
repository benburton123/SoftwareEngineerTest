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
        private List<IRule> _rules;

        public FizzBuzzController(List<IRule> rules)
        {
            _rules = rules;
        }

        [HttpGet("{startIndex}/{finishIndex}")]
        public FizzBuzzResponse Get(int startIndex, int finishIndex)
        {
            string result = "";

            for (int i = startIndex; i <= finishIndex; i++)
            {
                foreach (var rule in _rules)
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
                Summary = _rules.ToDictionary(rule => rule.Name, rule => rule.TotalPasses)
            };

            return response;
        }
    }
}
