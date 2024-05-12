
using Xunit;
using FluentAssertions;
using System.Collections.Generic;

namespace lib.test
{
    public class SplitPairsTest
    {
        [Theory]
        [InlineData(["abcd", new string[] { "ab", "cd" }])]
        [InlineData(["abc", new string[] { "ab", "c_" }])]
        [InlineData(["abcdf", new string[] { "ab", "cd", "f_" }])]
        [InlineData(["a", new string[] { "a_" }])]
        [InlineData(["", new string[] { }])]
        public void ShouldGet_Correct_SplitUpList(string input, string[] expected)
        {
            // Arrange
            var sp = new SplitPairs();
            // Act
            var result = sp.SplitString(input);
            // Assert
            result.Should().Equal(expected);
        }
    }
}