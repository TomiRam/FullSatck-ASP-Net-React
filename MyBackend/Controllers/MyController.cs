using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class MyController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello, World!");
    }
}

