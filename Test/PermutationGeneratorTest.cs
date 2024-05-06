using System;
using Xunit;
using FluentAssertions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace lib.test
{
    public class PermutationGeneratorTest
    {
        [Theory]
        [InlineData([new int[] { 1, 0, -1, 0, -2, 2 }])]
        public void BeEqualToExpected_WhenInputs(int[] nums)
        {
            // Arrange
            var permutationGenerator = new PermutationGenerator();
            // Act
            var result = permutationGenerator.GetPermutations(nums);
            // Assert
            // TBD
        }
    }
}
