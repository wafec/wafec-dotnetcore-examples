using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly01
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        public IActionResult Sum([FromForm] int x, [FromForm] int y)
        {
            return new JsonResult(new { x, y, result = x + y });
        }
    }
}
