using Codility;
using System;
using Xunit;

namespace CodilityTest
{
    public class CyclicRotationTest
    {
        [Fact]
        public void SingleRotationTest()
        {
            //Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int rotationTimes = 1;
            int[] expected = { 5, 1, 2, 3, 4 };
            int[] actual = null;

            //Act
            actual = CyclicRotation.RotateArray(array, rotationTimes);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SameTimesAsArrayLengthRotationTest()
        {
            //Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int rotationTimes = 5;
            int[] expected = { 1, 2, 3, 4, 5 };
            int[] actual = null;

            //Act
            actual = CyclicRotation.RotateArray(array, rotationTimes);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MoreTimesThanArrayLengthRotationTest()
        {
            //Arrange
            int[] array = { 1, 2, 3, 4 };
            int rotationTimes = 6;
            int[] expected = { 3, 4, 1, 2 };
            int[] actual = null;

            //Act
            actual = CyclicRotation.RotateArray(array, rotationTimes);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ZerosRotationTest()
        {
            //Arrange
            int[] array = { 0, 0, 0 };
            int rotationTimes = 1;
            int[] expected = { 0, 0, 0 };
            int[] actual = null;

            //Act
            actual = CyclicRotation.RotateArray(array, rotationTimes);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
