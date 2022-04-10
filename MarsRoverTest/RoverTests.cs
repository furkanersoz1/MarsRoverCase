using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverCase;
using MarsRoverCase.Models;

namespace MarsRoverTest
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Plateau plateau = new Plateau(5, 5);

            Rover rover = new Rover("1 2 N", plateau);
            rover.Run("LMLMLMLMM");
            Assert.AreEqual(rover.Output(), "1 3 N");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Plateau plateau = new Plateau(5, 5);

            Rover rover = new Rover("3 3 E", plateau);
            rover.Run("MMRMMRMRRM");
            Assert.AreEqual(rover.Output(), "5 1 E");
        }
    }
}
