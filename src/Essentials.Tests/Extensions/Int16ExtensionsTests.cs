using System;
using System.Collections.Generic;
using System.Text;
using Essentials.Extensions;
using Xunit;

namespace Essentials.Tests.Extensions
{
    public class Int16ExtensionsTests
    {
        [Fact]
        public void ShouldReturnTrue()
        {
            Int16 value = 1;
            Boolean returnedValue = value.ToBoolean();

            Assert.Equal(true, returnedValue);
        }
    }
}
