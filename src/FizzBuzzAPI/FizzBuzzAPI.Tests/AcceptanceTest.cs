using Newtonsoft.Json;
using NUnit.Framework;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Tests
{
    public class AcceptanceTest
    {
        [TestFixture]
        public class GivenARangeOf1To20 : WebApplicationTestBase
        {
            private ExpectedResponse _expectedResponse;

            [OneTimeSetUp]
            public async Task WhenTheAPIIsCalled()
            {
                var response = await Client.GetAsync($"{FizzBuzzRoute}/1/20");

                _expectedResponse = JsonConvert.DeserializeObject<ExpectedResponse>(await response.Content.ReadAsStringAsync());
            }

            [Test]
            public void ThenTheResultIsCorrect()
            {
                Assert.That("1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz", Is.EqualTo(_expectedResponse.Result));
            }

            [Test]
            public void ThenTheSummaryForFizzIsCorrect()
            {
                Assert.That(5, Is.EqualTo(_expectedResponse.Summary.Fizz));
            }

            [Test]
            public void ThenTheSummaryForBuzzIsCorrect()
            {
                Assert.That(3, Is.EqualTo(_expectedResponse.Summary.Buzz));
            }

            [Test]
            public void ThenTheSummaryForFizzBuzzIsCorrect()
            {
                Assert.That(1, Is.EqualTo(_expectedResponse.Summary.FizzBuzz));
            }

            [Test]
            public void ThenTheSummaryForIntegerIsCorrect()
            {
                Assert.That(11, Is.EqualTo(_expectedResponse.Summary.Integer));
            }
        }
    }
}