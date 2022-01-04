using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context1
{
    [Table("Entity2s", Schema = "Context1")]
    public class Context1Entity2 : EntityBase
    {
        public string Description { get; set; }
        [ForeignKey(nameof(Entity1))]
        public long Entity1Id { get; set; }
        public Context1Entity1 Entity1 { get; set; }
    }
}
