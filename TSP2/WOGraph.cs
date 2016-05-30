using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP2
{
    public class WOGraph
    {
        private double[,] edges;
        private ThreadSafeRandom random;
        private WOGraphVertice[] vertices;
        private int verticesNumber;
        public int VerticesNumber
        {
            set
            {
                verticesNumber = value;
            }
            get
            {
                return verticesNumber;
            }
        }
        
        public WOGraph(int verticesNumber)
        {
            edges = new double[verticesNumber, verticesNumber];
            random = new ThreadSafeRandom();
            vertices = new WOGraphVertice[verticesNumber];
            this.verticesNumber = verticesNumber;
        }

        public void AddVertice(int x, int y, string lable = "label")
        {
            WOGraphVertice vertice = new WOGraphVertice(lable, x, y);
            List<WOGraphVertice> list = vertices.ToList();
            list.Add(vertice);
            vertices = list.ToArray();

            verticesNumber++;

            _RecomputeEdges();
        }

        public void FillRandomData(int maxX, int maxY)
        {
            for(int i = 0; i < verticesNumber; i++)
            {
                vertices[i] = new WOGraphVertice(i.ToString(), random.Next(maxX), random.Next(maxY));
            }

            for(int i = 0; i < verticesNumber; i++)
            {
                for(int j = 0; j < verticesNumber; j++)
                {
                    edges[i, j] = Math.Sqrt(Math.Pow(vertices[i].Coordinates.X - vertices[j].Coordinates.X, 2) +
                        Math.Pow(vertices[i].Coordinates.Y - vertices[j].Coordinates.Y, 2));
                }
            }
        }

        public double GetEdgeWeightAt(int x, int y)
        {
            return edges[x, y];
        }
        public double GetTourLength(Tour tour)
        {
            double length = 0;

            for(int i = 0; i < tour.VerticesNumber; i++)
            {
                length += edges[i, tour.IndexAt(i)];
            }

            return length;
        }

        public WOGraphVertice GetVerticeAt(int index)
        {
            return vertices[index];
        }

        private void _RecomputeEdges()
        {
            edges = new double[verticesNumber, verticesNumber];

            for (int i = 0; i < verticesNumber; i++)
            {
                for (int j = 0; j < verticesNumber; j++)
                {
                    edges[i, j] = Math.Sqrt(Math.Pow(vertices[i].Coordinates.X - vertices[j].Coordinates.X, 2) +
                        Math.Pow(vertices[i].Coordinates.Y - vertices[j].Coordinates.Y, 2));
                }
            }
        }
    }
}
