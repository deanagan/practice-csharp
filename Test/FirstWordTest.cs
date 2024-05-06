using System;
using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class FirstWordShould
    {
        [Theory]
        [InlineData(["Hello world", "Hello"])]
        [InlineData([" a word ", "a"])]
        [InlineData(["don't touch it", "don't"])]
        [InlineData(["greetings, friends", "greetings"])]
        [InlineData(["... and so on ...", "and"])]
        [InlineData(["hi", "hi"])]
        [InlineData(["Hello.World", "Hello"])]
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
