using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display
{
    public class Edge
    {
        public int Weight { get; set; }
        public int Source { get; set; }
        public int Target { get; set; }

        public Edge (int weight, int source, int target)
        {
            Weight = weight;
            Source = source;
            Target = target;
        }
    }
}
