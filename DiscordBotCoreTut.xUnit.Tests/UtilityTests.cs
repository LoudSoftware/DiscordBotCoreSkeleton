using System;
using Xunit;

namespace DiscordBotCoreTut.xUnit.Tests
{
    public class UtilityTests
    {
        [Fact]
        public void Test1()
        {
            const int expected = 5;
            var actual = Utilities.MyUtility(expected);
            Assert.Equal(expected, actual + 1);
        }
    }
}