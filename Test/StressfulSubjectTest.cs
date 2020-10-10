
using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class StressfulSubjectTest
    {
        [Theory]
        [InlineData(new object[] {"Hi", false})]
        [InlineData(new object[] {"HELP", true})]
        [InlineData(new object[] {"What is this!!!", true})]
        [InlineData(new object[] {"I neeed HELP", true})]
        [InlineData(new object[] {"asap help", true})]
        [InlineData(new object[] {"UUUURGGGEEEEENT here", true})]
        [InlineData(new object[] {"Hello!Please", false})]
        [InlineData(new object[] {"Hello!!", false})]
        public void ShouldGet_Correct_IsStressful_Result(string input, bool expected)
        {
            // Arrange
            var sut = new StressSubjectAnalyzer();
            // Act
            var result = sut.IsStressful(input);
            // Assert
            result.Should().Be(expected);
        }
    }
}
