using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TSP2
{
    public static class GA
    {
        

        private static RoutineOutput[] routineOutput;
        private static WOGraph graph;
        private static int threadsNumber;
        public static int ThreadsNumber
        {
            set
            {
                threadsNumber = value;
            }
        }
        public static WOGraph Graph
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
        private static int capacity;
        public static int Capacity
        {
            set
            {
                capacity = value;
            }
            get
            {
                return capacity;
            }
        }
        private static long iterationsNumber;
        public static long IterationsNumber
        {
            set
            {
                iterationsNumber = value;
            }
            get
            {
                return iterationsNumber;
            }
        }

        private static void _GARoutine(object arg)
        {
            Population population = new Population(capacity, graph);
            population.InitializeRandom();

            for(int i = 0; i < iterationsNumber; i++)
            {
                population.NextGeneration();
            }

            Tour bestTour = population.GetFittest();
            routineOutput[(int)arg] = new RoutineOutput();
            routineOutput[(int)arg].RoutineTour = bestTour;
            routineOutput[(int)arg].TourWeight = graph.GetTourLength(bestTour);
        }

        public static Tour Run()
        {
            routineOutput = new RoutineOutput[threadsNumber];

            Thread[] threads = new Thread[threadsNumber];

            for(int i = 0; i < threadsNumber; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(_GARoutine));
                threads[i].Start(i);
            }

            for(int i = 0; i < threadsNumber; i++)
            {
                threads[i].Join();
            }

            int minElementIndex = 0;
            double minWeight = graph.GetTourLength(routineOutput[minElementIndex].RoutineTour);
            for (int i = 0; i < threadsNumber; i++)
            {
                if(routineOutput[i].TourWeight < minWeight)
                {
                    minWeight = routineOutput[i].TourWeight;
                    minElementIndex = i;
                }
            }

            return routineOutput[minElementIndex].RoutineTour;
        }
    }
}
