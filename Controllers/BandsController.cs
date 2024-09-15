using Microsoft.AspNetCore.Mvc;

namespace NgSight.Controllers;

[ApiController]
[Route("[controller]")]
public class BandsController : ControllerBase
{
    private readonly ILogger<BandsController> _logger;

    public BandsController(ILogger<BandsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
        var bands = new string[]
        {
            "Avenged Sevenfold",
            "Bullet for My Valentine",
            "Disturbed",
            "Element Eighty",
            "Five Finger Death Punch",
            "Halestorm",
            "Killing Joke",
            "Mastodon",
            "Nightwish",
            "Rise Against",
            "Sabaton",
            "Skindred",
            "Skillet",
            "Static-X",
            "Trivium",
            "Volbeat",
            "Within Temptation"
        };

        return bands;
    }
}
