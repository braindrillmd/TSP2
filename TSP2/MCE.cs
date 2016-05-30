using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TSP2
{
    static public class MCE
    {
        static RoutineOutput[] routineOutput;
        static long iteratonsNumber;
        static public long IterationsNumber
        {
            set
            {
                iteratonsNumber = value;
            }
            get
            {
                return iteratonsNumber;
            }
        }
        static private WOGraph graph;
        static int threadsNumber;
        static public int ThreadsNumber
        {
            set
            {
                threadsNumber = value;
            }
            get
            {
                return threadsNumber;
            }
        }
        static public WOGraph Graph
        {
            set
            {
                graph = value;
            }
            get
            {
                return graph;
            }
        }
        
        static public Tour Run()
        {
            routineOutput = new RoutineOutput[threadsNumber];

            Thread[] threads = new Thread[threadsNumber];

            for (int i = 0; i < threadsNumber; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(_MCERoutine));
                threads[i].Start(i);
            }

            for (int i = 0; i < threadsNumber; i++)
            {
                threads[i].Join();
            }

            int minElementIndex = 0;
            double minWeight = graph.GetTourLength(routineOutput[minElementIndex].RoutineTour);
            for (int i = 0; i < threadsNumber; i++)
            {
                if (routineOutput[i].TourWeight < minWeight)
                {
                    minWeight = routineOutput[i].TourWeight;
                    minElementIndex = i;
                }
            }

            return routineOutput[minElementIndex].RoutineTour;
        }

        static private void _MCERoutine(object arg)
        {
            //MessageBox.Show("I am thread " + arg.ToString() + "!");
            int verticesNumber = graph.VerticesNumber;

            Tour bestTour = new Tour(verticesNumber);
            bestTour.FillRandomData();
            double minTourLength = graph.GetTourLength(bestTour);
            for (int i = 0; i < iteratonsNumber; i++)
            {
                Tour tempTour = new Tour(verticesNumber);
                tempTour.FillRandomData();
                double currentTourLength = graph.GetTourLength(tempTour);

                if (currentTourLength < minTourLength)
                {
                    minTourLength = currentTourLength;
                    bestTour.CopyTour(tempTour);
                }
            }

            routineOutput[(int)arg] = new RoutineOutput();
            routineOutput[(int)arg].RoutineTour = bestTour;
            routineOutput[(int)arg].TourWeight = graph.GetTourLength(bestTour);
        }
    }
}
