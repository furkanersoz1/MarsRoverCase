using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCase.Models
{
    public class Plateau
    {
        public Coordinate m_maxCoordinate;
        public Coordinate m_minCoordinate;

        public Plateau(int x, int y)
        {
            m_minCoordinate = new Coordinate();
            m_minCoordinate.SetX(0);
            m_minCoordinate.SetY(0);

            m_maxCoordinate = new Coordinate();
            m_maxCoordinate.SetX(x);
            m_maxCoordinate.SetY(y);
        }

        public bool CheckPlateauX(int value)
        {
            if (m_minCoordinate.X <= value && value <= m_maxCoordinate.X)
                return true;
            return false;
        }

        public bool CheckPlateauY(int value)
        {
            if (m_minCoordinate.Y <= value && value <= m_maxCoordinate.Y)
                return true;
            return false;
        }
    }
}
