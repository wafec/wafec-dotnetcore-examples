using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class PetFoodEntity : EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
    }
}
