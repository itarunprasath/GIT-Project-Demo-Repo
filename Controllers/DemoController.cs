using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GIT_Project_Demo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public IActionResult WelcomeMessage()
        {
            return Ok("welcome to demo");
        }
    }
}
