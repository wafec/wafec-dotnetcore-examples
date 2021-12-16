using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example001_MapNestedClasses
{
    public class OuterDestEnumerable
    {
        public int Value { get; set; }
        public IEnumerable<InnerDestEnumerable> InnerItems { get; set; }
    }
}
