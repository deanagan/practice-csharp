using System;
using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class TestNumberPairs
    {
        [Theory]
        [InlineData(new object[] {new int[]{5, 25, 45, 15}, 30, 2})]
        [InlineData(new object[] {new int[]{30, 30, 30}, 30, 3})]
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
