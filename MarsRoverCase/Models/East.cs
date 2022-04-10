using MarsRoverCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCase.Models
{
    public class East : IDirection
    {
        Coordinate m_Coordinate;
        Plateau m_Plateau;

        public East(Coordinate Coordinate, Plateau plateau)
        {
            this.m_Coordinate = Coordinate;
            this.m_Plateau = plateau;
        }

        public IDirection Left()
        {
            return new North(m_Coordinate, m_Plateau);
        }

        public IDirection Right()
        {
            return new South(m_Coordinate, m_Plateau);
        }

        public void Move()
        {
            int newValue = m_Coordinate.X + 1;
            if (m_Plateau.CheckPlateauX(newValue))
                m_Coordinate.SetX(newValue);
            else
                throw new NotImplementedException();
        }

        public Coordinate GetCoordinate()
        {
            return m_Coordinate;
        }

        public string GetDirection()
        {
            return "E";
        }

        public bool CheckPlateau(int value)
        {
            throw new NotImplementedException();
        }
    }
}
