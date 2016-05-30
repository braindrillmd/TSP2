using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP2
{
    public class RoutineOutput
    {
        private Tour tour;
        private double tourWeight;

        public Tour RoutineTour
        {
            set
            {
                tour = new Tour(value.VerticesNumber);
                tour.CopyTour(value);
            }
            get
            {
                return tour;
            }
        }
        public double TourWeight
        {
            set
            {
                tourWeight = value;
            }
            get
            {
                return tourWeight;
            }
        }
    }
}
