using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class LongestPalindromicTest
    {
        [Theory]
        [InlineData(new object[] {"artrartrt", "rtrartr"})]
        [InlineData(new object[] {"abacada", "aba"})]
        [InlineData(new object[] {"aaaa", "aaaa"})]

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
