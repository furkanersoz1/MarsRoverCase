using MarsRoverCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCase.Models
{
    public class North : IDirection
    {
        Coordinate m_Coordinate;
        Plateau m_Plateau;

        public North(Coordinate Coordinate, Plateau plateau)
        {
            this.m_Coordinate = Coordinate;
            this.m_Plateau = plateau;
        }

        public IDirection Left()
        {
            return  new West(m_Coordinate, m_Plateau);
        }

        public IDirection Right()
        {
            return new East(m_Coordinate, m_Plateau);
        }

        public void Move()
        {
            int newValue = m_Coordinate.Y + 1;
            if (m_Plateau.CheckPlateauY(newValue))
                m_Coordinate.SetY(newValue);
            else
                throw new NotImplementedException();
        }

        public Coordinate GetCoordinate()
        {
            return m_Coordinate;
        }

        public string GetDirection()
        {
            return "N";
        }
    }
}
