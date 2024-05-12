using Xunit;
using FluentAssertions;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace lib.test
{
    public class NullCoalescingAssignmentTest
    {

        [Theory]
        [InlineData([1, 3, 4])]
        [InlineData([null, 1, 1])]
        public void ShouldReturnExpectedTotal(int? baseNumber, int num, int expected)
        {
            // Arrange
            var sut = new NullCoalescingAssignment();
            // Act
            var total = sut.TotalNumbers(baseNumber, num);
            // Assert
            total.Should().Be(expected);
        }

        [Theory]
        [InlineData([new int[] { 1, 2, 3 }, 4, new int[] { 1, 2, 3, 4 }])]
        [InlineData([new int[] { }, 1, new int[] { 1 }])]
        public void ShouldReturnExpectedList(int[] numbers, int num, int[] expected)
        {
            // Arrange
            var sut = new NullCoalescingAssignment();
            // Act
            var result = sut.AddNumberToList(numbers.ToList(), num);
            // Assert
            result.Should().Equal(expected);
        }
    }
}
