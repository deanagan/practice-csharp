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
        [InlineData(new object[] { new int[] { 2, 4, 3, 7, 4, 5 }, 4 })]
        public void ShouldReturnCorrectNumbers(int[] numbers, int expectedLength)
        {
            // Arrange


            // Act
            var result = LISFinder.LongestIncreasingSubsequence(numbers.ToList());

            // Assert
            result.Should().Be(expectedLength);


        }
    }

}