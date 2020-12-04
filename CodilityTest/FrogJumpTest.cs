using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Codility;

namespace CodilityTest
{
    public class FrogJumpTest
    {

        [Fact]
        public void FrogJumpTest1()
        {

            //Arrange
            int X = 10; int Y = 85; int D = 30;
            int expected = 3;
            int actual = 0;

            //Act
            actual = FrogJump.solution2(X, Y, D);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FrogJumpTest2()
        {

            //Arrange
            int X = 5; int Y = 1000000000; int D = 2;
            int expected = 499999998;
            int actual = 0;

            //Act
            actual = FrogJump.solution2(X, Y, D);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

