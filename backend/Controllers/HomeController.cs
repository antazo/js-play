using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHome()
        {
            return Ok("Test");
        }
        
        [HttpGet("foobar")]
        public IActionResult GetFoobar()
        {
            return Ok("Test!");
        }
    }
}