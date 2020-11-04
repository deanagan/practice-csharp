using System;
using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class TestNumberPairs
    {
        [Theory]
        [InlineData(new object[] {new int[]{5, 25, 45, 15}, 30, 2})]
        public void ShouldReturnCorrectCount_WhenGivenInputs(int[] inputs, int mod, int expected)
        {
            // Arrange
            var sut = new NumberPairs(inputs);
            // Act
            var result = sut.CountPairs(mod);
            // Assert
            result.Should().Be(expected);
        }
    }
}
