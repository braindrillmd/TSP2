using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSP2
{
    public partial class TSP2 : Form
    {
        private WOGraph graph;
        private const int CANVAS_WIDTH = 500;
        private const int CANVAS_HIGHT = 500;
        private int verticesNumber;
        private long MCEIterations;
        private long GAIterations;
        private int GACapacity;
        private int GAThreadsNumber;
        private Bitmap map;

        public TSP2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _InitCanvas(); 
        }

        private void buttonDrawGraph_Click(object sender, EventArgs e)
        {
            _InitCanvas();
            _DrawMap();
            Painter.DrawWOGraph(graph, pictureBoxCanvas);
        }

        private void buttonGenerateGraph_Click(object sender, EventArgs e)
        {
            graph = new WOGraph(verticesNumber);
            graph.FillRandomData(400, 400);
        }

        private void textBoxVerticesNumber_TextChanged(object sender, EventArgs e)
        {
            verticesNumber = Convert.ToInt32(textBoxVerticesNumber.Text);
        }

        private void buttonRandomTour_Click(object sender, EventArgs e)
        {
            _InitCanvas();
            _DrawMap();
            Tour tour = new Tour(verticesNumber);
            tour.FillRandomData();
            textBoxPathLength.Text = graph.GetTourLength(tour).ToString();
            Painter.DrawTour(tour, graph, pictureBoxCanvas);
        }

        private void buttonMCE_Click(object sender, EventArgs e)
        {
            MCE.IterationsNumber = MCEIterations;
            MCE.Graph = graph;
            Tour tour = MCE.Run();
            _InitCanvas();
            _DrawMap();
            textBoxPathLength.Text = graph.GetTourLength(tour).ToString();
            Painter.DrawTour(tour, graph, pictureBoxCanvas);
        }

        private void textBoxIterations_TextChanged(object sender, EventArgs e)
        {
            MCEIterations = Convert.ToInt64(textBoxIterations.Text);
        }

        private void _InitCanvas()
        {
            pictureBoxCanvas.Image = new Bitmap(CANVAS_WIDTH, CANVAS_HIGHT);
        }

        private void _DrawMap()
        {
            if(map != null)
            {
                pictureBoxCanvas.Image = map;
            }
        }

        private async void buttonMutation_Click(object sender, EventArgs e)
        {
            _InitCanvas();
            Tour tour = new Tour(verticesNumber);
            tour.FillRandomData();
            textBoxPathLength.Text = graph.GetTourLength(tour).ToString();
            Painter.DrawTour(tour, graph, pictureBoxCanvas);

            await PutTaskDelay(2000);

            _InitCanvas();
            tour.Mutate();
            textBoxPathLength.Text = graph.GetTourLength(tour).ToString();
            Painter.DrawTour(tour, graph, pictureBoxCanvas);
        }

        async Task PutTaskDelay (int howLong)
        {
            await Task.Delay(howLong);   
        }

        private async void buttonCrossingOver_Click(object sender, EventArgs e)
        {
            _InitCanvas();
            Tour tour1 = new Tour(verticesNumber);
            tour1.FillRandomData();
            textBoxPathLength.Text = graph.GetTourLength(tour1).ToString();
            Painter.DrawTour(tour1, graph, pictureBoxCanvas);

            await PutTaskDelay(1500);

            _InitCanvas();
            Tour tour2 = new Tour(verticesNumber);
            tour2.FillRandomData();
            textBoxPathLength.Text = graph.GetTourLength(tour2).ToString();
            Painter.DrawTour(tour2, graph, pictureBoxCanvas);

            await PutTaskDelay(1500);

            _InitCanvas();
            Tour tour = new Tour(verticesNumber);
            tour = tour1.CrossingOver(tour2);
            textBoxPathLength.Text = graph.GetTourLength(tour).ToString();
            Painter.DrawTour(tour, graph, pictureBoxCanvas);
        }

        private void buttonGA_Click(object sender, EventArgs e)
        {
            GA.IterationsNumber = GAIterations;
            GA.Capacity = GACapacity;
            GA.Graph = graph;
            GA.ThreadsNumber = GAThreadsNumber;
            Tour tour = GA.Run();
            _InitCanvas();
            _DrawMap();
            textBoxPathLength.Text = graph.GetTourLength(tour).ToString();
            Painter.DrawTour(tour, graph, pictureBoxCanvas);
        }

        private void textBoxGACapacity_TextChanged(object sender, EventArgs e)
        {
            GACapacity = Convert.ToInt32(textBoxGACapacity.Text);
        }

        private void textBoxGAIterations_TextChanged(object sender, EventArgs e)
        {
            GAIterations = Convert.ToInt64(textBoxGAIterations.Text);
        }

        private void textBoxGAThreadsNumber_TextChanged(object sender, EventArgs e)
        {
            GAThreadsNumber = Convert.ToInt32(textBoxGAThreadsNumber.Text);
        }

        private void buttonLoadMap_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            if(dialog.FileName != "")
            {
                map = new Bitmap(dialog.FileName);
                pictureBoxCanvas.Image = map;
            }
        }

        private void pictureBoxCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Painter.DrawPoint(new Point(e.X, e.Y), pictureBoxCanvas);

            if(graph == null)
            {
                graph = new WOGraph(0);
            }

            graph.AddVertice(e.X, e.Y);
        }
    }
}
