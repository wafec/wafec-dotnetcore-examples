using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context2
{
    [Table("Entity1s", Schema = "Context2")]
    public class Context2Entity1 : EntityBase
    {
        public string Description { get; set; }
    }
}
