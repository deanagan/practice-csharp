using System;
using System.Collections.Generic;
using System.Linq;

using Xunit;
using FluentAssertions;


namespace lib.test
{
    public class GradingStudentsTest
    {

        public GradingStudentsTest()
        {

        }

        [Theory]
        [InlineData([new int[] { 73, 67, 38, 33 }, new int[] { 75, 67, 40, 33 }])]
        public void ShouldReturnCorrectGrades(int[] grades, int[] expected)
        {
            // Arrange
            // Act
            var rounded = GradingStudents.GetGrading(grades.ToList());

            // Assert
            rounded.Should().Equal(expected);
        }

    }
}