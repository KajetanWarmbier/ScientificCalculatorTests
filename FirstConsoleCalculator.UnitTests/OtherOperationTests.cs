using MyFirstConsoleCalculator;
using NUnit.Framework;
using System;

namespace FirstConsoleCalculator.UnitTests
{
    [TestFixture]
    class OtherOperationTests
    {
        private OtherOperation _otherOperation;

        [SetUp]
        public void SetUp()
        {
            _otherOperation = new OtherOperation();
        }

        [Test]
        public void Factorial_WhenCalled_ReturnFactorialValue()
        {
            var result = _otherOperation.Factorial(5);
            var factorial = 5 * 4 * 3 * 2 * 1;
            Assert.That(result, Is.EqualTo(factorial));
        } 

        [Test]
        public void Factorial_WhenCalledWithValueLessThanOne_ThrowsArgumentOutOfRangeException()
        {
            Assert.That(() => _otherOperation.Factorial(-1), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void CubeRoot_WhenCalled_ReturnCubeRootValue()
        {
            var result = _otherOperation.CubeRoot(343);
            Assert.That(result, Is.EqualTo(7));
        }
    }


}