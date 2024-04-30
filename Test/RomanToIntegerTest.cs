using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class RomanToIntegerTest
    {
        [Theory]
        [InlineData(new object[] { "III", 3 })]
        [InlineData(new object[] { "LVIII", 58 })]
        [InlineData(new object[] { "MCMXCIV", 1994 })]
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
