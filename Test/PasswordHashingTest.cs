using System;
using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class PasswordHashingTest
    {
        [Theory]
        [InlineData(["hello"])]
        public void ShouldReturnHashedPassword(string password)
        {
            // Arrange
            var hasher = new PasswordHasher(new HashingOptions());
            // Act
            var result = hasher.Hash(password);
            var (isValid, _) = hasher.Check(result, password);
            // Assert
            isValid.Should().BeTrue();

        }
    }
}
