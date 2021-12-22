using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi01.Data.Entities
{
    public class PetEntity : EntityBase
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
