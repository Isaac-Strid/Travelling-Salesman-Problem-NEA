using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Display
{
    public class SimulatedAnnealing
    {
        private Route route;
        private Route possibleRoute;
        Random rnd;
        private int temperature;
        private const double alpha = 0.99;
        public SimulatedAnnealing(MatrixGraph graph) 
        { 
            rnd = new Random();
            temperature = 10000;
            route = new Route(graph);
            possibleRoute = new Route(graph);
        }

        public Route Solve()
        {
            return route;
            
        }

        public int Error()
        {
            return 0;
        }
        public int AdjacentError()
        {
            return 0;
        }
        public bool AcceptingProbability(int error, int adjacentError)
        {
            return false;
        }

    }
}
