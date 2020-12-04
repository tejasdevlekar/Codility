using System;
using Xunit;
using Codility;
using System.Diagnostics;

namespace CodilityTest
{
    public class CodilityTest
    {
        [Fact]
        public void BinaryGapTest()
        {
            //Arrange
            int number = 1041;
            int expected = 5;
            int actual = 0;
            //Act
            actual = BinaryGap.GetGap(number);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
