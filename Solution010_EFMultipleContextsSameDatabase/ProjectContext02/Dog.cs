﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectContext02
{
    public class Dog
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
