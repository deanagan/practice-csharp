using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class NullCoalescingNumbersTest {

        [Theory]
        [InlineData(new object[] {1, 3, 4})]
        [InlineData(new object[] {null, 1, 1})]
        public void ShouldReturnExpectedTotal(int? baseNumber, int num, int expected)
        {
            // Arrange
            var sut = new NullCoalescingNumbers();
            // Act
            var total = sut.TotalNumbers(baseNumber, num);
            // Assert
            total.Should().Be(expected);
        }
    }
}
