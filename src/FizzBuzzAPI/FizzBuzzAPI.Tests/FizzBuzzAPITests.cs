using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Tests
{
    public class FizzBuzzAPITests
    {
        private HttpClient _httpClient;

        [SetUp]
        public void Setup()
        {
            _httpClient = new WebApplicationFactory<Startup>().CreateClient();
        }

        [Test]
        public async Task Test1()
        {
            await _httpClient.GetAsync("FizzBuzz");
        }
    }
}