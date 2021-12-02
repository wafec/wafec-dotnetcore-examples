using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GreetingBuilder
    {
        public GreetingResponse ProcessGreeting(GreetingRequest greetingRequest)
        {
            return new GreetingResponse()
            {
                Message = $"Hello {greetingRequest?.Name?.ToUpper()}"
            };
        }
    }
}
