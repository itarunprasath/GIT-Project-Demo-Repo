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

        [HttpGet]
        public IActionResult Nadirah007WelcomeMessage()
        {
            return Ok("Welcome Nadirah007");
        }
        [HttpGet]
        public IActionResult AzniraWelcomeMessage()
        {
            return Ok("welcome to Aznira");

        }
        [HttpGet]
        public IActionResult HaidahWelcomeMessage()
        {
            return Ok("welcome to Haidah demo");
        }

    }
}
