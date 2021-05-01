using System;
using System.Collections.Generic;
using System.Linq;

using Xunit;
using FluentAssertions;



namespace lib.test
{
    public class LongestIncreasingSubsequenceTest
    {
        public LongestIncreasingSubsequenceTest()
        {

        }

        [Theory]
        [InlineData(new object[] { new int[]{ 2, 7, 4, 3, 8}, 3 })]
        public void ShouldReturnCorrectNumbers(int[] numbers, int expectedLength)
        {
            // Arrange


            // Act
            var result = LISFinder.longestIncreasingSubsequence(numbers.ToList());

            // Assert
            result.Should().Be(expectedLength);


        }
    }

}