using FluentAssertions;
using Simple.Api;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Simple.Integration.Test
{
    public class WeatherForecastTest : IClassFixture<SimpleApplicationFactory<Startup>>
    {
        private HttpClient client;

        public WeatherForecastTest(SimpleApplicationFactory<Startup> factory)
        {
            client = factory.CreateClient();
        }

        [Fact]
        public async Task Should_ReturnOk_GetEndpoitAsync()
        {
            var result = await client.GetAsync("WeatherForecast");
            result.Should().NotBeNull();
            result.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }
    }
}