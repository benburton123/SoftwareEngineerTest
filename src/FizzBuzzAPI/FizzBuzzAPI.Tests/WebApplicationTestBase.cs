using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;

namespace FizzBuzzAPI.Tests
{
    public class WebApplicationTestBase
    {
        protected const string FizzBuzzRoute = "FizzBuzz";
        protected HttpClient Client;

        public WebApplicationTestBase()
        {
            var webApplicationFactory = new WebApplicationFactory<Startup>();

            Client = webApplicationFactory.CreateClient();
        }
    }
}
