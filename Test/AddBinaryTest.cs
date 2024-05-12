using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class AddBinaryTest
    {
        [Theory]
        [InlineData(new object[] { "11", "1", "100" })]
        [InlineData(new object[] { "1010", "1011", "10101" })]
        [InlineData(new object[] { "0", "0", "0" })]
        public void AddBinaryTest_WhenInputs(string a, string b, string expected)
        {
            // Arrange

            // Act
            var result = AddBinarySolution.AddBinary(a, b);
            // Assert
            result.Should().Be(expected);
        }
    }
}
