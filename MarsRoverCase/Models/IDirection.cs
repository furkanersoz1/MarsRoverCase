using MarsRoverCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCase.Models
{
    public interface IDirection
    {
        IDirection Left();
        IDirection Right();
        void Move();
        Coordinate GetCoordinate();
        string GetDirection();
    }
}
