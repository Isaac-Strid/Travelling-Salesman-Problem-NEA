using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Display
{
    public class Route 
    {
        private List<Edge> route = new List<Edge>();
        MatrixGraph graph;
  
        

        public Route(MatrixGraph graph) 
        {
            this.graph = graph;
        }


        public int Size
        {
            get { return route.Count; }
        }

        public Edge Last
        {
            get { return route[route.Count - 1]; }
        }

        public Edge this[int i]
        {
            get { return route[i]; }
        }

        public void AddEdge(Edge edge)
        {
            route.Add(edge);
        }

            
        public Edge ShortestEdgeNotInRoute(int source)
        {
            // starting edge 
     
            Edge minEdge;
            if (source == 0)
            {
                minEdge = graph[source, 1];
            }
            else
            {
                minEdge= graph[source, 0];
            }

            
            // find shortest Edge from vertex to vertex not in route
            for (int i = 0; i < graph.Size; i++)
            {
                if (!TargetVisited(graph[source, i].Target) && graph[source, i].Weight > 0 && graph[source, i].Weight < minEdge.Weight)
                {                   
                    minEdge = graph[source, i];
                }
            }

            Console.WriteLine($"{minEdge.Source}{minEdge.Target}: {minEdge.Weight}");
            return minEdge;
        }

        public bool TargetVisited(int target)
        {
            for (int i = 0; i < route.Count; i++)
            {
                if (route[i].Source == target)
                {
                    Console.WriteLine($"Target Visted {route[i].Source }");
                    return true;
                }
            }
            return false;
        }


        public bool TargetInRoute(int target)
        {         
            for (int i = 0; i < route.Count; i++)
            {              
                if (route[i].Source == target)
                {
                    return true;
                }
            }
            return false;
        }


        public bool EdgeInRoute(Edge edge)
        {
            for (int i = 0; i < route.Count; i++)
            {
                if (route[i] == edge)
                {
                    return true;
                }
            }       

            return false;
        }

        public void GenerateRandomRouteRecursive(int index)
        {
            
           
            //GenerateRandomRouteRecurisve(index);
        }

        public void GenerateRandomRouteIteratively()
        {

        }


        public void SwapTwoCities()
        {

        }
        public string OutputRouteAsString()
        {
            return string.Empty;
        }
        public void ReverseSegmentOfRoute()
        {

        }
    }
}
