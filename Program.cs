using Display;


namespace TestForNea
{
    public class Program
    {
        static void Main(string[] args)
        {                            
            MatrixGraph matrix= new MatrixGraph();
            OutputGraph(matrix);
        
            Route route = new Route(matrix);
            route.AddEdge(route.ShortestEdgeNotInRoute(0));
           
            route.AddEdge(route.ShortestEdgeNotInRoute(route.Last.Target));

            route.AddEdge(route.ShortestEdgeNotInRoute(route.Last.Target));

            route.AddEdge(route.ShortestEdgeNotInRoute(route.Last.Target));

            OutputRoute(route);
        }  

        static void OutputGraph(MatrixGraph matrix)
        {
            for (int i = 0; i < matrix.Size; i++)
            {
                Console.Write(matrix[i, 0].Source + ":");
                for (int j = 0; j < matrix.Size; j++)
                {
                    Console.Write(matrix[i, j].Weight + ",");
                }
                Console.WriteLine();
            }
        }

        static void OutputRoute(Route route)
        {
            for (int i = 0; i < route.Size; i++)
            {
                Console.Write($"{route[i].Source}{route[i].Target} {route[i].Weight}");
                Console.WriteLine();
            }
        }
    }
}