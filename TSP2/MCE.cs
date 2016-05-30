using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSP2
{
    static public class MCE
    {
        static long iteratonsNumber;
        static public long IterationsNumber
        {
            set
            {
                iteratonsNumber = value;
            }
        }
        static private WOGraph graph;
        static public WOGraph Graph
        {
            set
            {
                graph = value;
            }
        }
        
        static public Tour Run()
        {
            return _MCERoutine(new object());
        }

        static private Tour _MCERoutine(object arg)
        {
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

            return bestTour;
        }
    }
}
