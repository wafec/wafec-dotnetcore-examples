using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context2
{
    [Table("Entity2s", Schema = "Context2")]
    public class Context2Entity2 : EntityBase
    {
        public string Description { get; set; }
        [ForeignKey(nameof(Entity1))]
        public long? Entity1Id { get; set; }
        public Context2Entity1 Entity1 { get; set; }
        [ForeignKey(nameof(Context1Entity1))]
        public long? Context1Entity1Id { get; set; }
        public Context1Entity1 Context1Entity1 { get; set; }
    }
}
