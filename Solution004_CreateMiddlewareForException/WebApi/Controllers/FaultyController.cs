using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FaultyController
    {
        [HttpGet]
        public IActionResult Argument()
        {
            throw new ArgumentException();
        }

        [HttpGet]
        public IActionResult Null()
        {
            throw new NullReferenceException();
        }
    }
}
