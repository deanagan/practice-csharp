using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class FromCamelCaseTest
    {
        [Theory]
        [InlineData(new object[] { "MyFunctionName",  "my_function_name" })]
        [InlineData(new object[] { "IPhone",  "i_phone" })]
        [InlineData(new object[] { "ThisFunctionIsEmpty",  "this_function_is_empty" })]
        [InlineData(new object[] { "Name",  "name" })]
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
