using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;

namespace Postal.Tests.Integration;

public class CustomWebApplicationFactory<TProgram>
    : WebApplicationFactory<TProgram> where TProgram : class
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        //builder.UseContentRoot(AppContext.BaseDirectory);
        //builder.UseSolutionRelativeContentRoot()
    }
}
