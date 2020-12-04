using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Codility;

namespace CodilityTest
{
    public class OddOccurenceInArrayTest
    {
        [Fact]
        public void OddOccurenceTest()
        {

            //Arrange
            int[] array = { 9, 3, 9, 3, 9, 7, 9 };
            int expected = 7;
            int actual = 0;

            //Act
            actual = OddOccurrencesInArray.Solution2(array);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
