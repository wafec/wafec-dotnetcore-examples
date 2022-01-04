using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context2
{
    [Table("Entity1s", Schema = "Context1")]
    public class Context1Entity1 : EntityBase
    {
        public string Description { get; set; }
    }
}
