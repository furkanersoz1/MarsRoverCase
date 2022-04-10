using MarsRoverCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCase
{
    public class Rover
    {
        public IDirection m_Direction;
        public Coordinate m_Coordinates;
        public Plateau m_Plateau;

        public Rover(string location, Plateau plateau)
        {
            var locations = location.Split(' ');
            int x = Convert.ToInt32(locations[0]);
            int y = Convert.ToInt32(locations[1]);
            string direction = locations[2];
            m_Coordinates = new Coordinate();
            m_Coordinates.SetX(x);
            m_Coordinates.SetY(y);
            m_Plateau = plateau;
            m_Direction = setFirstState(direction);
        }

        public IDirection setFirstState(string value)
        {
            switch (value)
            {
                case "N":
                    return new North(m_Coordinates, m_Plateau);
                case "W":
                    return new West(m_Coordinates, m_Plateau);
                case "S":
                    return new South(m_Coordinates, m_Plateau);
                case "E":
                    return new East(m_Coordinates, m_Plateau);
                default:
                    throw new NotImplementedException();
            }
        }

        public void Run(string commands)
        {
            foreach (var item in commands.ToCharArray())
            {
                switch (item)
                {
                    case 'L':
                        m_Direction = m_Direction.Left();
                        break;
                    case 'R':
                        m_Direction = m_Direction.Right();
                        break;
                    case 'M':
                        m_Direction.Move();
                        break;
                    default:
                        break;
                }
            }
            m_Coordinates = m_Direction.GetCoordinate();
        }

        public string Output()
        {
            return m_Coordinates.X + " " + m_Coordinates.Y + " " + m_Direction.GetDirection();
        }
    }
}
