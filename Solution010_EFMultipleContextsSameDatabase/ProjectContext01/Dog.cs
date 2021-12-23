using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectContext01
{
    public class Dog
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; } 
    }
}
