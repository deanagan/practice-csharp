
using Xunit;
using FluentAssertions;
using System.Collections.Generic;

namespace lib.test
{
    public class SplitPairsTest
    {
        [Theory]
        [InlineData(new object[] {"abcd", new string[]{"ab", "cd"} })]
        [InlineData(new object[] {"abc", new string[]{"ab", "c_"} })]
        [InlineData(new object[] {"abcdf", new string[]{"ab","cd", "f_"} })]
        [InlineData(new object[] {"a", new string[]{"a_"} })]
        [InlineData(new object[] {"", new string[]{} })]
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