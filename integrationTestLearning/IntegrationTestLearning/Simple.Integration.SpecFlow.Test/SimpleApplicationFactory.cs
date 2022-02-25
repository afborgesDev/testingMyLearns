using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using System;

namespace Simple.Integration.SpecFlow.Test
{
    public class SimpleApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            Environment.SetEnvironmentVariable("SomeUrl", "https://UrlFromAcceptanceTest.com");
        }
    }
}