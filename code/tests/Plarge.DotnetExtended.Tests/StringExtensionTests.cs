using NUnit.Framework;
using NFluent;

namespace Plarge.DotnetExtended.Tests
{
    [TestFixture]
    public class StringExtensionTests
    {
        [Test]
        public void ShouldTruncateWhenStringIsLongerThanExpectedLength()
        {
            const string input = "This is a sample";
            const string expected = "This is a ";
            const int expectedLenght = 10;
            var result = input.Truncate(expectedLenght);
            Check.That(result).IsEqualTo(expected);
            Check.That(result.Length).IsEqualTo(expectedLenght);
        }


        [Test]
        public void ShouldNotTruncateWhenStringIsSmallerThanExpectedLength()
        {
            const string input = "This is a sample";
            const string expected = "This is a sample";
            const int expectedLenght = 200;
            var initialLenght = input.Length;
            var result = input.Truncate(expectedLenght);
            Check.That(result).IsEqualTo(expected);
            Check.That(result.Length).IsEqualTo(initialLenght);
        }
    }
}
