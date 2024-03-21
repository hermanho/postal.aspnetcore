using System.Net;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Hosting.Server;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Postal.Tests.Integration.IntegrationTests;

public class EmailViewTests :
        IClassFixture<CustomWebApplicationFactory<Program>>
{
    private readonly CustomWebApplicationFactory<Program>
        _factory;

    public EmailViewTests(
        CustomWebApplicationFactory<Program> factory)
    {
        _factory = factory;
        _factory.Server.PreserveExecutionContext = true;
    }

    [Fact]
    public async Task Get_EmailTemplateWith_UrlHelper()
    {
        var client = _factory.CreateClient(new WebApplicationFactoryClientOptions()
        {
            BaseAddress = new Uri("http://localhost:7060")
        });
        var response = await client.GetAsync("/Test1/SendEmail1");
        var content = await response.Content.ReadAsStringAsync();

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Contains("http://localhost:7060/Second/Dummy", content);
    }

    [Fact]
    public async Task Get_EmailTemplateWith_UrlHelper2()
    {
        var client = _factory.CreateClient(new WebApplicationFactoryClientOptions()
        {
            BaseAddress = new Uri("http://localhost:7060")
        });
        var response = await client.GetAsync("/Test1/SendEmail2");
        var content = await response.Content.ReadAsStringAsync();

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Contains("http://localhost:7060/Second/Dummy", content);
    }
}

