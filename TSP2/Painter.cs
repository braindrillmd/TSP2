using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TSP2
{
    
    static public class Painter
    {
        static public Point BezierPointAt(Point[] nodes, double where)
        {
            Point point = new Point();

            double t = where;

            int x0 = nodes[0].X;
            int x1 = nodes[1].X;
            int x2 = nodes[2].X;
            int x3 = nodes[3].X;
            int y0 = nodes[0].Y;
            int y1 = nodes[1].Y;
            int y2 = nodes[2].Y;
            int y3 = nodes[3].Y;

            point.X = (int)(x0 * (-t * t * t + 3 * t * t - 3 * t + 1) +
                x1 * (3 * t * t * t + -6 * t * t + 3 * t) +
                x2 * (-3 * t * t * t + 3 * t * t) +
                x3 * t * t * t);

            point.Y = (int)(y0 * (-t * t * t + 3 * t * t - 3 * t + 1) +
                y1 * (3 * t * t * t + -6 * t * t + 3 * t) +
                y2 * (-3 * t * t * t + 3 * t * t) +
                y3 * t * t * t);

            return point;
        }

        static public void DrawBezier(Point[] nodes, PictureBox canvas, int parameter = 1000)
        {
            Bitmap bitmap = new Bitmap(canvas.Image);
            Graphics graphics = Graphics.FromImage(bitmap);

            for (int i = 0; i < parameter; i++)
            {
                double t = (double)i / parameter;

                graphics.DrawEllipse(Pens.DarkGreen, BezierPointAt(nodes, t).X, BezierPointAt(nodes, t).Y, 1, 1);

            }

            canvas.Image = bitmap;
        }

        static public void DrawRegion(int x0, int y0, int r1, int r2, PictureBox canvas)
        {
            Bitmap bitmap = new Bitmap(canvas.Image);
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.DrawEllipse(Pens.DarkGreen, x0 - r1, y0 - r1, 2 * r1, 2 * r1);
            graphics.DrawEllipse(Pens.DarkGreen, x0 - r2, y0 - r2, 2 * r2, 2 * r2);

            canvas.Image = bitmap;
        }
        static public void DrawPoint(Point point, PictureBox canvas)
        {
            Bitmap bitmap = new Bitmap(canvas.Image);
            Graphics graphics = Graphics.FromImage(bitmap);
            //canvas.Image.Dispose();

            graphics.FillEllipse(Brushes.Red, point.X - 5, point.Y - 5, 10, 10);

            canvas.Image = bitmap;
        }

        static public void DrawTour(Tour tour, WOGraph graph, PictureBox canvas, bool drawLabels = false)
        {
            Bitmap bitmap = new Bitmap(canvas.Image);
            Graphics graphics = Graphics.FromImage(bitmap);

            float arrowCapSize = 4;
            AdjustableArrowCap arrowCap = new AdjustableArrowCap(arrowCapSize, arrowCapSize * 2);
            Pen pen = new Pen(Brushes.Red);
            
            pen.CustomEndCap = arrowCap;
            pen.Width = 2;

            for (int i = 0; i < tour.VerticesNumber; i++)
            {
                graphics.FillEllipse(Brushes.Blue, graph.GetVerticeAt(i).Coordinates.X - 5,
                    graph.GetVerticeAt(i).Coordinates.Y - 5, 10, 10);
            }

            for (int i = 0; i < tour.VerticesNumber; i++)
            {
                graphics.DrawLine(pen, graph.GetVerticeAt(i).Coordinates,
                    graph.GetVerticeAt(tour.IndexAt(i)).Coordinates);
            }

            if (drawLabels == true)
            {
                Font font = new Font("Arial", 9);
                for (int i = 0; i < tour.VerticesNumber; i++)
                {
                    graphics.DrawString(graph.GetVerticeAt(i).Label, font, Brushes.Black, graph.GetVerticeAt(i).Coordinates.X + 10,
                        graph.GetVerticeAt(i).Coordinates.Y - 10);
                }
            }

            canvas.Image = bitmap;
        }

        static public void DrawWOGraph(WOGraph graph, PictureBox canvas)
        {
            Bitmap bitmap = new Bitmap(canvas.Image);
            Graphics graphics = Graphics.FromImage(bitmap);

            for(int i = 0; i < graph.VerticesNumber; i++)
            {
                for (int j = 0; j < graph.VerticesNumber; j++)
                {
                    graphics.DrawLine(Pens.Black, graph.GetVerticeAt(i).Coordinates,
                        graph.GetVerticeAt(j).Coordinates);
                }
            }

            for (int i = 0; i < graph.VerticesNumber; i++)
            {
                graphics.FillEllipse(Brushes.Red, graph.GetVerticeAt(i).Coordinates.X - 5,
                    graph.GetVerticeAt(i).Coordinates.Y - 5, 10, 10);
            }

            canvas.Image = bitmap;
        }
    }
}
