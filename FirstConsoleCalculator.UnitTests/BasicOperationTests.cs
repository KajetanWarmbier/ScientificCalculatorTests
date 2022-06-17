using MyFirstConsoleCalculator;
using NUnit.Framework;
using System;

namespace FirstConsoleCalculator.UnitTests
{
    [TestFixture]
    class BasicOperationTests
    {
        private BasicOperation _basicOperation;

        [SetUp]
        public void SetUp()
        {
            _basicOperation = new BasicOperation();
        }

        [Test]
        [TestCase(10,10)]
        [TestCase(79.98,79.98)]
        public void Subtraction_WhenCalledWithSameVariables_ReturnsZero(double num1, double num2)
        {
            var result = _basicOperation.Subtraction(num1, num2);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(12.54, 17.84)]
        [TestCase(1, 2)]
        public void Subtraction_WhenCalledWithDifferentValue_IsNotEqualZero(double num1, double num2)
        {
            var result = _basicOperation.Subtraction(num1, num2);
            Assert.That(result, Is.Not.EqualTo(0));
        }

        [Test]
        [TestCase(10,0)]
        [TestCase(0,0)]
        public void Division_WhenCalledWithNum2AsZero_ThrowsError(double num1, double num2)
        {

            Assert.That(() => _basicOperation.Division(num1, num2), Throws.Exception.TypeOf<ArgumentException>());
        }
    }
}
