using System.Net;
using Microsoft.AspNetCore.Mvc;
using NetCoreApiTemplate.Extensions;
using NetCoreApiTemplate.Services;
using NetCoreApiTemplate.Services.Shared;
using Swashbuckle.AspNetCore.Annotations;

namespace NetCoreApiTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly HomeService _homeService;

        public HomeController(HomeService homeService)
        {
            _homeService = homeService;
        }
        
        
        // GET api/home
        [HttpGet]
        [SwaggerResponse((int) HttpStatusCode.OK, "Okay", typeof(string))]
        [SwaggerResponse((int) HttpStatusCode.Conflict, "Conflict", typeof(ErrorResult))]
        [SwaggerResponse((int) HttpStatusCode.BadRequest, "Bad Request", typeof(ErrorResult))]
        public IActionResult Get()
        {
            return this.FromServiceResult(
                _homeService.GetHome()
            );
        }
    }
}