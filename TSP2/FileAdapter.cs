using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP2
{
    public static class FileAdapter
    {
        public static WOGraph LoadGraph(string filePath)
        {
            WOGraph graph;

            using (System.IO.StreamReader input = new System.IO.StreamReader(filePath))
            {
                int verticesNumber = Convert.ToInt32(input.ReadLine());

                graph = new WOGraph(0);

                for(int i = 0; i < verticesNumber; i++)
                {
                    string buffer = input.ReadLine();
                    string[] bufferArray = new string[3];
                    bufferArray = buffer.Split(' ');
                    WOGraphVertice vertice = new WOGraphVertice(bufferArray[0],
                        Convert.ToInt32(bufferArray[1]),
                        Convert.ToInt32(bufferArray[2]));
                    graph.AddVertice(vertice);
                }

                for(int i = 0; i < verticesNumber; i++)
                {
                    string buffer = input.ReadLine();
                    string[] bufferArray = new string[verticesNumber];
                    bufferArray = buffer.Split(' ');

                    for(int j = 0; j < verticesNumber; j++)
                    {
                        graph.SetWeightAt(i, j, Convert.ToDouble(bufferArray[j]));
                    }
                }

                input.Close();
            }

            return graph;
        }
        public static void SaveGraph(WOGraph graph, string filePath)
        {
            using (System.IO.StreamWriter output = new System.IO.StreamWriter(filePath))
            {
                output.WriteLine(graph.VerticesNumber.ToString());

                for(int i = 0; i < graph.VerticesNumber; i++)
                {
                    WOGraphVertice vertice = graph.GetVerticeAt(i);
                    output.WriteLine("{0} {1} {2}", vertice.Label, vertice.Coordinates.X, vertice.Coordinates.Y);

                }

                for(int i = 0; i < graph.VerticesNumber; i++)
                {
                    string buffer = "";
                    for(int j = 0; j < graph.VerticesNumber; j++)
                    {
                        buffer += graph.GetEdgeWeightAt(i, j).ToString();
                        if(j != graph.VerticesNumber - 1)
                        {
                            buffer += " ";
                        }
                    }
                    output.WriteLine(buffer);
                }

                output.Close();
            }
            
        }
    }
}
