using System;
using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class ValidParenthesesShould
    {
        [Theory]
        // [InlineData(new object[] {"()[]{}", true })]
        // [InlineData(new object[] {"(]", false })]
        // [InlineData(new object[] {"([)]", false })]
        [InlineData(new object[] {"{[]}", true })]
        // [InlineData(new object[] {"]", false })]
        // [InlineData(new object[] {"(])", false })]
        // [InlineData(new object[] {"){", false })]
        public void BeEqualToExpected_WhenInputs(string input, bool expected)
        {
            // Arrange
            var sut = new ValidParentheses();
            // Act
            var result = sut.IsValid(input);
            // Assert
            result.Should().Be(expected);
        }
    }
}
