using System;
using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class RightToLeftShould
    {
        [Theory]
        [InlineData(new object[] {new string[]{"left", "right", "left", "stop"}, "left,left,left,stop"})]
        [InlineData(new object[] {new string[]{"bright aright", "ok"}, "bleft aleft,ok"})]
        [InlineData(new object[] {new string[]{"brightness wright"},"bleftness wleft"})]
        [InlineData(new object[] {new string[]{"enough", "jokes"}, "enough,jokes"})]
        public void ReplaceRightWithLeft_WhenGivenInputs(string[] inputs, string expected)
        {
            // Arrange
            var r2l = new RightToLeft();
            // Act
            var result = r2l.ReplaceRightWithLeft(inputs);
            // Assert
            result.Should().Be(expected);
        }
    }
}
