using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example001_MapNestedClasses
{
    public class OuterSourceEnumerable
    {
        public int Value { get; set; }
        public IEnumerable<InnerSourceEnumerable> InnerItems { get; set; }
    }
}
