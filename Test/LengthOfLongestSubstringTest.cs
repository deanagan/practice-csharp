using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class SubstringUtilityTest {

        [Theory]
        [InlineData(new object[] {"abcabcbb", 3})]
        [InlineData(new object[] {"bbbbb", 1})]
        [InlineData(new object[] {"pwwkew", 3})]
        [InlineData(new object[] {"", 0})]
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
