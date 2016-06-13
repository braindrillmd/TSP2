using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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

        public void AddVertice(WOGraphVertice vertice)
        {
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

        public void FillRandomDataInRegion(int maxX, int maxY, int x0, int y0, int r1, int r2)
        {
            for (int i = 0; i < verticesNumber; i++)
            {
                int x = random.Next(maxX);
                int y = random.Next(maxY);

                while ( !(y <= Math.Sqrt(r2 * r2 - (x - x0) * (x - x0)) + y0 &&
                    y >= -Math.Sqrt(r2 * r2 - (x - x0) * (x - x0)) + y0 &&
                    (y >= Math.Sqrt(r1*r1 - (x - x0 ) * (x - x0) ) + y0 ||
                    y <= -Math.Sqrt(r1 * r1 - (x - x0) * (x - x0)) + y0)))   {
                    x = random.Next(maxX);
                    y = random.Next(maxY);

                }
                vertices[i] = new WOGraphVertice(i.ToString(), x, y);
            }

            for (int i = 0; i < verticesNumber; i++)
            {
                for (int j = 0; j < verticesNumber; j++)
                {
                    edges[i, j] = Math.Sqrt(Math.Pow(vertices[i].Coordinates.X - vertices[j].Coordinates.X, 2) +
                        Math.Pow(vertices[i].Coordinates.Y - vertices[j].Coordinates.Y, 2));
                }
            }
        }

        public void FillRandomDataOnBezier(int maxX, int maxY, Point[] nodes, int resolution = 1000)
        {
            int x = Painter.BezierPointAt(nodes, 0).X;
            int y = Painter.BezierPointAt(nodes, 0).Y;
            vertices[0] = new WOGraphVertice("0", x, y);

            for (int i = 1; i < verticesNumber-1; i++)
            {
                double t = 0;
                double oldT = 0;
                while (t == 0 && oldT == t)
                {
                    while (oldT == t)
                    {
                        t = (double)random.Next((int)Math.Ceiling((double)(i - 1) / (verticesNumber - 2) * resolution),
                            (int)Math.Floor((double)(i) / (verticesNumber - 2) * resolution)) / resolution;
                    }
                    oldT = t;
                    
                }
                MessageBox.Show(t.ToString());
                x = Painter.BezierPointAt(nodes, t).X;
                y = Painter.BezierPointAt(nodes, t).Y;
                vertices[i] = new WOGraphVertice((i+1).ToString(), x, y);
            }
            x = Painter.BezierPointAt(nodes, 1).X;
            y = Painter.BezierPointAt(nodes, 1).Y;
            vertices[verticesNumber-1] = new WOGraphVertice(verticesNumber.ToString(), x, y);

            for (int i = 0; i < verticesNumber; i++)
            {
                for (int j = 0; j < verticesNumber; j++)
                {
                    edges[i, j] = Math.Sqrt(Math.Pow(vertices[i].Coordinates.X - vertices[j].Coordinates.X, 2) +
                        Math.Pow(vertices[i].Coordinates.Y - vertices[j].Coordinates.Y, 2));
                }
            }

            edges[0, verticesNumber - 1] = edges[verticesNumber - 1, 0] = 0;
        }

        public double GetBezierLength()
        {
            double length = 0;

            for (int i = 0; i < verticesNumber - 1; i++)
            {
                length += edges[i, i + 1];
            }

            return length;
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

        public void SetWeightAt(int x, int y, double weight)
        {
            edges[x, y] = weight;
        }
    }
}
