using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display
{
    public class NearestNeighbour 
    {
        public Route route;
        public  string Name { get ; set; }

        
        public NearestNeighbour(MatrixGraph graph)
        {
            route = new Route(graph);
            Solve();
        }
        public void Solve()
        {
            
           // pick random starting vertex, or first vertex from input
        }
    }
}
