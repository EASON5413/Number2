using Microsoft.AspNetCore.Mvc;
[Route("api/Status")]
[ApiController]
public class ClassController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello World");
    }
}