namespace FizzBuzzAPI.Tests
{
    public class ExpectedResponse
    {
        public string Result { get; set; }

        public Summary Summary { get; set; }
    }

    public class Summary
    {
        public int Fizz { get; set; }

        public int Integer { get; set; }
    }
}
