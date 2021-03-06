// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace System.Runtime.InteropServices.Tests
{
    public class BindToMonikerTests
    {
        [Fact]
        [PlatformSpecific(TestPlatforms.AnyUnix)]
        public void BindToMoniker_Unix_ThrowsPlatformNotSupportedException()
        {
            Assert.Throws<PlatformNotSupportedException>(() => Marshal.BindToMoniker(null));
        }

        [Theory]
        [PlatformSpecific(TestPlatforms.Windows)]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("invalidName")]
        public void BindToMoniker_InvalidArgument_ThrowsAnyException(string monikerName)
        {
            Assert.ThrowsAny<Exception>(() => Marshal.BindToMoniker(monikerName));
        }
    }
}
