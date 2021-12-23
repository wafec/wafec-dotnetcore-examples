using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectContext02
{
    public class Person
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Dog")]
        public long DogId { get; set; }
        public Dog Dog { get; set; }
    }
}
