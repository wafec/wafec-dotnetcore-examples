using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.AdvancedPatternMatching
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Point(int x, int y, int z) =>
            (this.x, this.y, this.z) = (x, y, z);
    }
}
