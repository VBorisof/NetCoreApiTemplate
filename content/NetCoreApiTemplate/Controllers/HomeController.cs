using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreApiTemplate.Extensions;
using NetCoreApiTemplate.Forms;
using NetCoreApiTemplate.Services;

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
        public IActionResult Get()
        {
            return this.FromServiceOperationResult(
                _homeService.GetHome()
            );
        }
        
        // POST api/home/numbers
        [HttpPost]
        public async Task<IActionResult> GetNumbersAsync([FromBody] NumbersForm form)
        {
            return this.FromServiceOperationResult(
                await _homeService.GetNumbersAsync(form)
            );
        }
    }
}