using System;
using Xunit;
using FluentAssertions;
using System.Collections;
using System.Collections.Generic;

namespace lib.test
{
    public class FourSumShould
    {
        [Theory]
        [InlineData(new object[] { new int[] { 1, 2, 3 } })]
        public void BeEqualToExpected_WhenInputs(int[] nums)
        {
            // Arrange
            var firstWord = new FourSumFinder();
            // Act
            var result = firstWord.FourSum(nums, 0);
            // Assert
            // result.Should().Be(expected);
        }
    }
}
