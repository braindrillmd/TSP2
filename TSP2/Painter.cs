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
