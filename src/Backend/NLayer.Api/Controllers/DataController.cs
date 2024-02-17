using Microsoft.AspNetCore.Mvc;

namespace NLayer.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DataController : ControllerBase
{
    private readonly ILogger<DataController> _logger;

    public DataController(ILogger<DataController> logger)
    {
        _logger = logger;
    }

    [HttpGet("[action]")]
    public IActionResult Get()
    {
        return Ok();
    }
    [HttpGet("[action]")]
    public IActionResult Post()
    {
        return Ok();
    }
    [HttpGet("[action]")]
    public IActionResult Update()
    {
        return Ok();
    }
    [HttpGet("[action]")]
    public IActionResult Delete()
    {
        return Ok();
    }
}
