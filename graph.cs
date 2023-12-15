using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display
{
    public class Graph
    {
        private List<Vertex> vertices = new List<Vertex>();




        public int Size
        {
            get { return vertices.Count; }
        }

        public Graph(string filename)
        {
            
            string line;

            using StreamReader sr = new StreamReader(filename);
            {
                

                while ((line = sr.ReadLine()) != null)
                {
                    //AddVertex(line);
                }
            }
        }

        /*public void AddVertex(string line)
        {
            Vertex vertex = new Vertex();

            string[] splitVertex = line.Split('.');

            string source = splitVertex[0];

            string[] edges = splitVertex[1].Split(';');

            for (int i = 0; i < edges.Length; i++)
            {
                string[] partsOfEdge = edges[i].Split(',');

                int weight = Convert.ToInt32(partsOfEdge[1]);

                string target = partsOfEdge[0];

                Edge edge = new Edge(weight, source, target);

                vertex.AddEdge(edge);
            }
            vertices.Add(vertex);
        }*/


        public int IndexOfVertex(string source)
        {
            for (int i = 0; i < vertices.Count; i++)
            {
                if (vertices[i].name == source)
                {
                    return i;
                }
            }

            return -1;
        }

        public Vertex this[int i]
        {
            get { return vertices[i]; }
        }

       
    }
}
