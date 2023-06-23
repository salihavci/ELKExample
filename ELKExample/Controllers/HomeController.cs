using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ELKExample.Controllers
{
    //Demo
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
            try
            {
                var isException = true;
                return !isException! ? Ok("Test") : throw new Exception("Deneme bir hata fırlatıldı. Test apisinden");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return BadRequest(ex.ToString());
            }
        }
    }
}
