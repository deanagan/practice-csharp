using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class LongestPalindromicTest
    {
        [Theory]
        [InlineData(["artrartrt", "rtrartr"])]
        [InlineData(["abacada", "aba"])]
        [InlineData(["aaaa", "aaaa"])]

        public void Should_BeEqual_WhenGivenNumbers(string input, string expected)
        {
            // Arrange
            var sut = new LongestPalindromic();
            // Act
            var result = sut.LongestPalindrome(input);
            // Assert
            result.Should().Be(expected);
        }
    }
}
