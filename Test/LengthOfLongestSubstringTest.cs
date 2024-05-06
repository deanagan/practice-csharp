using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class SubstringUtilityTest
    {

        [Theory]
        [InlineData(["abcabcbb", 3])]
        [InlineData(["bbbbb", 1])]
        [InlineData(["pwwkew", 3])]
        [InlineData(["", 0])]
        public void ShouldReturnLongestSubstringLength(string text, int expectedLength)
        {
            // Arrange
            var sut = new SubstringUtility();
            // Act
            var length = sut.GetLengthOfLongestSubstring(text);
            // Assert
            length.Should().Be(expectedLength);
        }
    }
}
