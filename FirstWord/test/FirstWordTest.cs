using System;
using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class FirstWordShould
    {
        [Theory]
        [InlineData(new object[] {"Hello world", "Hello"})]
        [InlineData(new object[] {" a word ",  "a"})]
        [InlineData(new object[] {"don't touch it",  "don't"})]
        [InlineData(new object[] {"greetings, friends",  "greetings"})]
        [InlineData(new object[] {"... and so on ...",  "and"})]
        [InlineData(new object[] {"hi",  "hi"})]
        [InlineData(new object[] {"Hello.World",  "Hello"})]
        public void BeEqualToExpected_WhenInputs(string input, string expected)
        {
            // Arrange
            var firstWord = new FirstWord();
            // Act
            var result = firstWord.Retrieve(input);
            // Assert
            result.Should().Be(expected);
        }
    }
}
