using Microsoft.AspNetCore.Mvc;

namespace NetCoreApiTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET api/home
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Up and Running!");
        }
    }
}