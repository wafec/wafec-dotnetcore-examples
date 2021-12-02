using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GreetingService : IGreetingService
    {
        public GreetingModel SayHello(string name)
        {
            return new GreetingModel()
            {
                Id = 0,
                Message = $"Hello {name}"
            };
        }
    }
}
