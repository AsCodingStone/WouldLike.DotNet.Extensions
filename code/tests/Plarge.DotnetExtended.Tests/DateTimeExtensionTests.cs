using NFluent;
using NUnit.Framework;
using System;

namespace Plarge.DotnetExtended.Tests
{
    [TestFixture]
    public class DateTimeExtensionTests
    {
        [Test]
        public void ToRename()
        {
            const int year = 2021;
            const int month = 9;
            const int day = 21;
            const int hour = 12;
            const int minute = 43;
            const int secoond = 54;
            const int millisecond = 234;
            var initialDateTime = new DateTime(year, month, day, hour, minute, secoond, millisecond);

            var result = initialDateTime.TrimMillisecond();
            Check.That(result.Millisecond).IsZero();
        }
    }
}
