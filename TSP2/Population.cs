using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSP2
{
    public class Population
    {
        private ThreadSafeRandom random;
        private Tour[] toursPopulation;
        private WOGraph graph;
        private int capacity;
        private int size;
        public int Size
        {
            get
            {
                return size;
            }
        }
        private double mutationProbability;

        public Population(int capacity, WOGraph graph)
        {
            this.capacity = capacity;
            size = 0;
            toursPopulation = new Tour[capacity];
            this.graph = graph;
            random = new ThreadSafeRandom();
            mutationProbability = 25;
        }

        public void AddTour(Tour tour)
        {
            if(size < capacity)
            {
                toursPopulation[size-1].CopyTour(tour);
                size++;
            }
        }

        public Tour GetFittest()
        {
            //TODO: procedure
            TourComparer comparer = new TourComparer(graph);
            Array.Sort(toursPopulation, comparer);

            return toursPopulation[0];
        }

        public void InitializeRandom()
        {
            for(int i = 0; i < capacity; i++)
            {
                toursPopulation[i] = new Tour(graph.VerticesNumber);
                toursPopulation[i].FillRandomData();
            }
        }

        public bool IsRoom()
        {
            if(size < capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void NextGeneration()
        {
            //MessageBox.Show("Enterng NextGeneration()");

            TourComparer comparer = new TourComparer(graph);
            Array.Sort(toursPopulation, comparer);
            Tour[] newTourPopulation = new Tour[capacity];


            for(int i = 0; i < capacity; i++)
            {
                newTourPopulation[i] = new Tour(graph.VerticesNumber);
                newTourPopulation[i].CopyTour(toursPopulation[i]);
            }

            for(int i = capacity/2; i < capacity-1; i++)
            {
                Tour child1 = toursPopulation[i - capacity/2].CrossingOver(toursPopulation[i -capacity/2+1]);
                Tour child2 = toursPopulation[i-capacity/2+1].CrossingOver(toursPopulation[i-capacity/2]);
                newTourPopulation[i] = new Tour(graph.VerticesNumber);
                newTourPopulation[i].CopyTour(child1);
                newTourPopulation[i+1] = new Tour(graph.VerticesNumber);
                newTourPopulation[i+1].CopyTour(child2);
            }

            for(int i = 0; i < capacity; i++)
            {
                if (random.Next(100) < mutationProbability)
                {
                    newTourPopulation[i].Mutate();
                }
            }

            toursPopulation = newTourPopulation;
        }

    }
}
