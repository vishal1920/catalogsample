using catalogsample.Models;
using Microsoft.AspNetCore.Mvc;

namespace catalogsample.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    private readonly ILogger<HealthController> _logger;

    public HealthController(ILogger<HealthController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "health")]
    public IActionResult Get()
    {
        return Unauthorized();
    }
}