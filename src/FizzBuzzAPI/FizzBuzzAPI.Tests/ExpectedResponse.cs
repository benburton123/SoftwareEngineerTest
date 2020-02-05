using Newtonsoft.Json;

namespace FizzBuzzAPI.Tests
{
    public class ExpectedResponse
    {
        public string Result { get; set; }

        public Summary Summary { get; set; }
    }

    public class Summary
    {
        [JsonProperty("fizz")]
        public int Fizz { get; set; }

        [JsonProperty("buzz")]
        public int Buzz { get; set; }

        [JsonProperty("fizzbuzz")]
        public int FizzBuzz { get; set; }

        [JsonProperty("integer")]
        public int Integer { get; set; }
    }
}
