using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Scalete.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WorkController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing2", "Bracing2", "Chilly2", "Cool2", "Mild2", "Warm2", "Balmy2", "Hot2", "Sweltering2", "Scorching2"
    };

    [HttpGet(Name = "Nums-2")]
    public IEnumerable<int> Get()
    {
        return Enumerable.Range(1, 5).Select(num => num).ToArray();
    }
}
