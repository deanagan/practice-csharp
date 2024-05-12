using System;
using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class TestNumberPairs
    {
        [Theory]
        [InlineData([new int[] { 5, 25, 45, 15 }, 30, 2])]
        [InlineData([new int[] { 30, 30, 30 }, 30, 3])]
        [InlineData([new int[] { 17, 13, 30 }, 30, 1])]
        [InlineData([new int[] { 338, 172, 7, 3, 29, 1 }, 30, 2])]
        public void ShouldReturnCorrectCount_WhenGivenInputs(int[] inputs, int denom, int expected)
        {
            // Arrange
            var sut = new NumberPairs(inputs);
            // Act
            var result = sut.CountPairs(denom);
            // Assert
            result.Should().Be(expected);
        }
    }
}
