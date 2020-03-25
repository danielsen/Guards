using System;
using NUnit.Framework;

namespace Guards.Tests
{
    [TestFixture]
    public class StringExtensionTests
    {
        [Test]
        public void should_throw_on_empty_string()
        {
            var str = String.Empty;
            Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(str), str).Empty());
        }

        [Test]
        public void should_throw_on_whitespace_string()
        {
            var str = "    ";
            Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(str), str).Whitespace());
        }
    }
}