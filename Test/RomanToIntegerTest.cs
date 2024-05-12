using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class RomanToIntegerTest
    {
        [Theory]
        [InlineData(["III", 3])]
        [InlineData(["LVIII", 58])]
        [InlineData(["MCMXCIV", 1994])]
        public void RomantToInteger_Equivalent_Number(string input, int expected)
        {
            // Arrange

            // Act
            var result = RomanToInteger.GetNumericValue(input);
            // Assert
            result.Should().Be(expected);
        }
    }
}
