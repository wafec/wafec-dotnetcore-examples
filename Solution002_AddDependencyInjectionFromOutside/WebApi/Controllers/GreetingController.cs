using Microsoft.AspNetCore.Mvc;
using Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class GreetingController : ControllerBase
    {
        private IGreetingService _greetingService;

        public GreetingController(IGreetingService greetingService) => (_greetingService) = (greetingService);

        [HttpGet]
        public IActionResult SayHello([FromQuery] string name)
        {
            return new JsonResult(_greetingService.SayHello(name));
        }
    }
}
