using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TSP2
{
    public class WOGraphVertice
    {
        private string label;
        public string Label
        {
            get
            {
                return label;
            }
            set
            {
                label = value;
            }
        }
        private Point coordinates;
        public Point Coordinates
        {
            get
            {
                return coordinates;
            }
            set
            {
                coordinates.X = value.X;
                coordinates.Y = value.Y;
            }
        }

        public WOGraphVertice(string label, int x, int y)
        {
            this.label = label;
            coordinates.X = x;
            coordinates.Y = y;
        }


    }
}
