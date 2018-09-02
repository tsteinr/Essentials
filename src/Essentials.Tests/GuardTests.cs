using System;
using Xunit;

namespace Essentials.Tests
{
    public class GuardTests
    {
        [Fact]
        public void ShouldThrowException()
        {
            Assert.Equal(expected: "1", actual: "1");
        }
    }
}
