using Microsoft.AspNetCore.Mvc;

namespace Postal.Tests.Integration.Controllers;

public class Test1Controller : Controller
{
    public Test1Controller()
    {
    }

    public IActionResult SendEmail1()
    {
        var emailData = new Email("Testing1");
        emailData.ViewData["to"] = "hello@example.com";
        emailData.ViewData["Name"] = "Sam";
        emailData.CaptureHttpContext(HttpContext);

        return new EmailViewResult(emailData);
    }
}
