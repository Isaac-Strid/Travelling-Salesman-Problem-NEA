using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Display
{
    public class MatrixGraph
    {
        private Edge[,] matrix;
        private int size;

        public int Size
        { 
            get { return size; }
        }

        public Edge this[int i, int j]
        {
            get { return matrix[i, j]; }
        }

        public MatrixGraph()
        {
            string line = string.Empty;
            int lineNum = 0;

            using StreamReader sr = new StreamReader("MatrixInputProblem.txt");
            {  
                line = sr.ReadLine();
                string[] splitLine = line.Split(',');
                size = splitLine.Length;
                matrix = new Edge[size,size];

                AddLineToMatrix(lineNum, splitLine);
                lineNum++;

                while ((line = sr.ReadLine()) != null)
                {
                    splitLine = line.Split(',');
                    AddLineToMatrix(lineNum++, splitLine);

                }
            }
        }





 
        private void AddLineToMatrix(int lineNum, string[] splitLine)
        {
            for (int i = 0; i < splitLine.Length; i++)
            {
                int weight = Convert.ToInt32(splitLine[i]);
                int source = lineNum;
                int target = i;

                Edge edge = new Edge (weight, source, target);
                matrix[lineNum, i] = edge;
            }
        }            
    }
}
