using Microsoft.AspNetCore.Mvc;
using Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class GreetingController
    {
        private GreetingService _greetingService;

        public GreetingController(GreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        [HttpGet]
        public GreetingModel SayHello([FromQuery] HelloMessage message)
        {
            return _greetingService.SayHello(message);
        }
    }
}
