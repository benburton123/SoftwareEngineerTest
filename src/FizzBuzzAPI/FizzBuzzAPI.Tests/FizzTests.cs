using Newtonsoft.Json;
using NUnit.Framework;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Tests
{
    public class FizzTests
    {
        [TestFixture]
        public class GivenASingleMultipleOf3 : WebApplicationTestBase
        {
            private ExpectedResponse _expectedResponse;

            [OneTimeSetUp]
            public async Task WhenTheAPIIsCalledWithRange()
            {
                var response = await Client.GetAsync($"{FizzBuzzRoute}/3/3");

                _expectedResponse = JsonConvert.DeserializeObject<ExpectedResponse>(await response.Content.ReadAsStringAsync());
            }

            [Test]
            public void ThenTheResultIsFizz()
            {
                Assert.That("fizz", Is.EqualTo(_expectedResponse.Result));
            }

            [Test]
            public void ThenTheSummaryIsCorrect()
            {
                Assert.That(1, Is.EqualTo(_expectedResponse.Summary.Fizz));
            }
        }
    }
}