using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class PetEntity : EntityBase
    {
        public string Name { get; set; }
        public string Reference { get; set; }
        public string Type { get; set; }
    }
}
