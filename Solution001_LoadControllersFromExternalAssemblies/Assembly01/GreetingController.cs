using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly01
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreetingController : ControllerBase
    {
        [HttpGet]
        public IActionResult SayHello([FromQuery] string name)
        {
            return new JsonResult(new { message = $"Hello {name}" });
        }
    }
}
