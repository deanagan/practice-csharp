using System;
using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class ValidParenthesesShould
    {
        [Theory]
        [InlineData(["()[]{}", true])]
        [InlineData(["(]", false])]
        [InlineData(["([)]", false])]
        [InlineData(["{[]}", true])]
        [InlineData(["){", false])]
        [InlineData(["]", false])]
        [InlineData(["(])", false])]
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
