using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/")]
public class ApiController : ControllerBase
{
    [HttpGet]
    public IActionResult GetInfo()
    {
        return Ok(new
        {
            email = "ekechukwu65@gmail.com",
            current_datetime = DateTime.UtcNow.ToString("o"),
            github_url = "https://github.com/Justceei/HNG12API"
        });
    }
}
