using Newtonsoft.Json;
using NUnit.Framework;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Tests
{
    public class FizzBuzzTests
    {
        [TestFixture]
        public class GivenASingleMultipleOfBoth3And5 : WebApplicationTestBase
        {
            private ExpectedResponse _expectedResponse;

            [OneTimeSetUp]
            public async Task WhenTheAPIIsCalled()
            {
                var response = await Client.GetAsync($"{FizzBuzzRoute}/15/15");

                _expectedResponse = JsonConvert.DeserializeObject<ExpectedResponse>(await response.Content.ReadAsStringAsync());
            }

            [Test]
            public void ThenTheResultIsFizz()
            {
                Assert.That("fizzbuzz", Is.EqualTo(_expectedResponse.Result));
            }

            [Test]
            public void ThenTheSummaryIsCorrect()
            {
                Assert.That(1, Is.EqualTo(_expectedResponse.Summary.FizzBuzz));
            }
        }
    }
}