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

        [TestCase("alice@domain.com", false)]
        [TestCase("bob@domain.co.uk", false)]
        [TestCase("sally@ai", false)]
        [TestCase("jane@a.b.domain.com", false)]
        [TestCase("mary", true)]
        public void should_throw_on_invalid_email(string address, bool shouldThrow)
        {
            if (shouldThrow)
            {
                Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(address), address)
                    .InvalidEmail());
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(address),address)
                    .InvalidEmail());
            }
        }

        [TestCase(6, false)]
        [TestCase(5, false)]
        [TestCase(4, true)]
        public void should_throw_on_string_length(int maxLength, bool shouldThrow)
        {
            var str = "Hello";
            if (shouldThrow)
            {
                Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(str), str)
                    .LongerThan(maxLength));
            }
            else
            {
                Assert.DoesNotThrow(() => Guard.ThrowIf(nameof(str), str).LongerThan(maxLength));
            }
        }

        [Test]
        public void should_throw_on_whitespace_string()
        {
            var str = "    ";
            Assert.Throws<ArgumentException>(() => Guard.ThrowIf(nameof(str), str).Whitespace());
        }
    }
}