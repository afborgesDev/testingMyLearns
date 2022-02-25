using FluentAssertions;
using Simple.Api;
using System.Net.Http;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Simple.Integration.SpecFlow.Test
{
    [Binding]
    public class WeatherForecastSteps
    {
        private readonly ScenarioContext scenarioContext;
        private readonly HttpClient client;

        public WeatherForecastSteps(ScenarioContext scenarioContext, SimpleApplicationFactory<Startup> factory)
        {
            this.scenarioContext = scenarioContext;
            client = factory.CreateClient();
        }

        [Given("I have the application up")]
        public void GivenIHaveTheApplicationUp()
        {
            // Ilustrative only
        }

        [When("I perform a request to the get endpoint")]
        public async Task WhenIPerformARequestToTheGetEndpointAsync()
        {
            var result = await client.GetAsync("WeatherForecast");
            scenarioContext.Set(result);
        }

        [Then("I receive a Ok status code")]
        public void ThenIReceiveAOkStatusCode()
        {
            var result = scenarioContext.Get<HttpResponseMessage>();
            result.Should().NotBeNull();
            result.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
        }
    }
}