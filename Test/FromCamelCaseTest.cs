using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class FromCamelCaseTest
    {
        [Theory]
        [InlineData(["MyFunctionName", "my_function_name"])]
        [InlineData(["IPhone", "i_phone"])]
        [InlineData(["ThisFunctionIsEmpty", "this_function_is_empty"])]
        [InlineData(["Name", "name"])]
        public void Should_GetCorrect_Casing_WhenGivenInput(string input, string expected)
        {
            // Arrange
            var cc = new FromCamelCase();
            // Act
            var result = cc.Convert(input);
            // Assert
            result.Should().Be(expected);
        }
    }
}
