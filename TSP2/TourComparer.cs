using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP2
{
    public class TourComparer : IComparer<Tour>
    {
        private WOGraph graph;

        public TourComparer(WOGraph graph)
        {
            this.graph = graph;
        }

        public int Compare(Tour x, Tour y)
        {
            return (int)(graph.GetTourLength(x) - graph.GetTourLength(y));
        }
    }
}
