
using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class StressfulSubjectTest
    {
        [Theory]
        [InlineData(["Hi", false])]
        [InlineData(["HELP", true])]
        [InlineData(["What is this!!!", true])]
        [InlineData(["I neeed HELP", true])]
        [InlineData(["asap help", true])]
        [InlineData(["UUUURGGGEEEEENT here", true])]
        [InlineData(["Hello!Please", false])]
        [InlineData(["Hello!!", false])]
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
