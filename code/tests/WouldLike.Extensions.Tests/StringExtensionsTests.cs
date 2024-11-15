using NUnit.Framework;
using NFluent;
using WouldLike.Extensions.String;

namespace WouldLike.Extensions.Tests
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [Test]
        public void ShouldTruncateWhenStringIsLongerThanExpectedLength()
        {
            const string input = "This is a sample";
            const string expected = "This is a ";
            const int expectedLength = 10;
            var result = input.Truncate(expectedLength);
            Check.That(result).IsEqualTo(expected);
            Check.That(result.Length).IsEqualTo(expectedLength);
        }


        [Test]
        public void ShouldNotTruncateWhenStringIsSmallerThanExpectedLength()
        {
            const string input = "This is a sample";
            const string expected = "This is a sample";
            const int expectedLength = 200;
            var initialLenght = input.Length;
            var result = input.Truncate(expectedLength);
            Check.That(result).IsEqualTo(expected);
            Check.That(result.Length).IsEqualTo(initialLenght);
        }
    }
}
