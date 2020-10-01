using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace lib.test
{
    public class DisconnectedUserTest
    {
        public static IEnumerable<object[]> TestParameters
        {
            get
            {
                yield return new object[] { new Dictionary<string, string>{ { "A", "B" }, {"B" , "C"}, {"C", "D"} },
                                            new Dictionary<string, int>{ {"A", 10}, {"B", 20}, {"C", 30}, {"D", 40} },
                                            "A", new List<string>{"C"}, 70 };

                yield return new object[] { new Dictionary<string, string>{ { "A", "B" }, {"B" , "D"}, {"A", "C"}, {"C", "D"} },
                                            new Dictionary<string, int>{ {"A", 10}, {"B", 0}, {"C", 0}, {"D", 40} },
                                            "A", new List<string>{"B"}, 0 };

                yield return new object[] { new Dictionary<string, string>{ { "A", "B" }, {"A" , "C"}, {"A", "D"}, {"A", "E"}, {"A", "F"} },
                                            new Dictionary<string, int>{ {"A", 10}, {"B", 10}, {"C", 10}, {"D", 10}, {"E", 10}, {"F", 10} },
                                            "C", new List<string>{"A"}, 50 };

                yield return new object[] { new Dictionary<string, string>{ { "A", "B" }, {"B" , "C"}, {"C", "D"} },
                                            new Dictionary<string, int>{ {"A", 10}, {"B", 20}, {"C", 30}, {"D", 40} },
                                            "A", new List<string>{"A"}, 100 };
            }
        }

        [Theory]
        [MemberData(nameof(TestParameters))]

        public void ShouldReturnCorrectNumber(Dictionary<string, string> edges, Dictionary<string, int> lookUp, string source, List<string> crushes, int expected)
        {
            // Arrange
            var dc = new DisconnectedUsers(edges, lookUp);

            // Act
            var total = dc.Total(source, crushes);

            // Assert
            total.Should().Be(expected);
        }
    }
}
