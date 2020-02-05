using Newtonsoft.Json;
using NUnit.Framework;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Tests
{
    public class IntegerTests
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

        [TestFixture(1, 2)]
        [TestFixture(7, 8)]
        public class GivenARangeWithANonMultipleOfEither3Or5 : WebApplicationTestBase
        {
            private int _start;
            private int _end;
            private ExpectedResponse _expectedResponse;

            public GivenARangeWithANonMultipleOfEither3Or5(int start, int end)
            {
                _start = start;
                _end = end;
            }

            [OneTimeSetUp]
            public async Task WhenTheAPIIsCalledWithRange()
            {
                var response = await Client.GetAsync($"{FizzBuzzRoute}/{_start}/{_end}");

                _expectedResponse = JsonConvert.DeserializeObject<ExpectedResponse>(await response.Content.ReadAsStringAsync());
            }

            [Test]
            public void ThenTheResultIsNumber()
            {
                Assert.That($"{_start} {_end}", Is.EqualTo(_expectedResponse.Result));
            }

            [Test]
            public void ThenTheSummaryIsCorrect()
            {
                Assert.That(2, Is.EqualTo(_expectedResponse.Summary.Integer));
            }
        }
    }
}