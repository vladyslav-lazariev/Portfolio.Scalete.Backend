using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Scalete.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BlogController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing1", "Bracing1", "Chilly1", "Cool1", "Mild1", "Warm1", "Balmy1", "Hot1", "Sweltering1", "Scorching1"
    };

    [HttpGet(Name = "Nums-1")]
    public IEnumerable<int> Get()
    {
        return Enumerable.Range(1, 5).Select(num => num).ToArray();
    }
}
