
using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class NearestValueShould
    {
        [Theory]
        [InlineData([new int[] { 4, 7, 10, 11, 12, 17 }, 9, 10])]
        [InlineData([new int[] { 4, 7, 10, 11, 12, 17 }, 8, 7])]
        [InlineData([new int[] { 4, 8, 10, 11, 12, 17 }, 9, 8])]
        [InlineData([new int[] { 4, 9, 10, 11, 12, 17 }, 9, 9])]
        [InlineData([new int[] { 4, 7, 10, 11, 12, 17 }, 0, 4])]
        [InlineData([new int[] { 4, 7, 10, 11, 12, 17 }, 100, 17])]
        [InlineData([new int[] { 5, 10, 8, 12, 89, 100 }, 7, 8])]
        [InlineData([new int[] { -1, 2, 3 }, 0, -1])]
        [InlineData([new int[] { 0, -2 }, -1, -2])]
        public void BeEqual_WhenGivenNumbers(int[] values, int search, int expected)
        {
            // Arrange
            var nv = new NearestValue();
            // Act
            var result = nv.Result(values, search);
            // Assert
            result.Should().Be(expected);
        }
    }
}
