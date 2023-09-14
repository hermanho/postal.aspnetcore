using System.Net;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Hosting.Server;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Postal.Tests.Integration.IntegrationTests;

public class EmailViewTests :
        IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;
    private readonly WebApplicationFactory<Program>
        _factory;

    public EmailViewTests(
        WebApplicationFactory<Program> factory)
    {
        _factory = factory;
        var server = factory.Services.GetRequiredService<IServer>();
        _client = factory.CreateClient(new WebApplicationFactoryClientOptions()
        {
            BaseAddress = new Uri("http://localhost:7060")
        });
    }

    [Fact]
    public async Task Get_EmailTemplateWith_UrlHelper()
    {
        var response = await _client.GetAsync("/Test1/SendEmail1");
        var content = await response.Content.ReadAsStringAsync();

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Contains("http://localhost:7060/Second/Dummy", content);
    }
}

