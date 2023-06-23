using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ELKExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        [HttpPost("Test")]
        public IActionResult Test()
        {
            return Ok("Test");
        }
    }
}
