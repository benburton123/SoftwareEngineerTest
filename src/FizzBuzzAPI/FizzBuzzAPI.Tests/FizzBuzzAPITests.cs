using Newtonsoft.Json;
using NUnit.Framework;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Tests
{
    [TestFixture]
    public class GivenASingleNonMultipleOfEither3Or5 : WebApplicationTestBase
    {
        private ExpectedResponse _expectedResponse;

        [OneTimeSetUp]
        public async Task WhenTheAPIIsCalledWithRange()
        {
            var response = await Client.GetAsync($"{FizzBuzzRoute}/2/2");

            _expectedResponse = JsonConvert.DeserializeObject<ExpectedResponse>(await response.Content.ReadAsStringAsync());
        }

        [Test]
        public void ThenTheResultIsNumber()
        {
            Assert.That("2", Is.EqualTo(_expectedResponse.Result));
        }

        [Test]
        public void ThenTheSummaryIsCorrect()
        {
            Assert.That(1, Is.EqualTo(_expectedResponse.Summary.Integer));
        }
    }

    [TestFixture]
    public class GivenARangeWithANonMultipleOfEither3Or5 : WebApplicationTestBase
    {
        private ExpectedResponse _expectedResponse;

        [OneTimeSetUp]
        public async Task WhenTheAPIIsCalledWithRange()
        {
            var response = await Client.GetAsync($"{FizzBuzzRoute}/1/2");

            _expectedResponse = JsonConvert.DeserializeObject<ExpectedResponse>(await response.Content.ReadAsStringAsync());
        }

        [Test]
        public void ThenTheResultIsNumber()
        {
            Assert.That("1 2", Is.EqualTo(_expectedResponse.Result));
        }

        [Test]
        public void ThenTheSummaryIsCorrect()
        {
            Assert.That(2, Is.EqualTo(_expectedResponse.Summary.Integer));
        }
    }
}