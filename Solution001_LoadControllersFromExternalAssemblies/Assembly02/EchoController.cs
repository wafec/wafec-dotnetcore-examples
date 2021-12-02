using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly02
{
    [ApiController]
    [Route("api/[controller]")]
    public class EchoController
    {
        [HttpGet]
        public string Get(string message)
        {
            return message;
        }
    }
}
