using Essentials.Extensions;
using System;
using Xunit;

namespace Essentials.Tests.Extensions
{
    public class BooleanExtensionsTests
    {
        [Fact]
        public void ShouldReturnInt16()
        {
            Int16 returnedValue = true.ToInt16();

            Assert.Equal(1, returnedValue);
        }
    }
}
