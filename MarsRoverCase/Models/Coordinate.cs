using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCase.Models
{
    public class Coordinate
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public void SetY(int value)
        {
            y = value;
        }

        public void SetX(int value)
        {
            x = value;
        }

    }
}
