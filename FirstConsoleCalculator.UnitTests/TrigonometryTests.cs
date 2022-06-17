using MyFirstConsoleCalculator;
using NUnit.Framework;
using System;

namespace FirstConsoleCalculator.UnitTests
{
    [TestFixture]
    class TrigonometryTests
    {
        Trigonometry _trigonometry;

        [SetUp]
        public void SetUp()
        {
            _trigonometry = new Trigonometry();
        }

        [Test]
        [TestCase(20)]
        [TestCase(5)]
        public void AsinDegrees_WhenCalled_ReturnArcusSinusOfValue(double number)
        {
            var result = _trigonometry.AsinDegrees(number);
            Assert.That(result, Is.EqualTo(Math.Asin(number) * 180 / Math.PI));
        }
    }
}
