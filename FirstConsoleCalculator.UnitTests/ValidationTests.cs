using MyFirstConsoleCalculator;
using NUnit.Framework;
using System;

namespace FirstConsoleCalculator.UnitTests
{
    [TestFixture]
    class ValidationTests
    {
        private Validation _validation;

        [SetUp]
        public void SetUp()
        {
            _validation = new Validation();
        }

        [Test]
        public void SignCheck_WhenCalled_ReturnGivenSign()
        {
            string sign = "%";
            var result = _validation.SignCheck(sign);
            Assert.That(result, Is.EqualTo(sign));
        }

        [Test]
        public void SignCheck_WhenCalledWithWrongSing_ReturnInvalidInput()
        {
            var result = _validation.SignCheck("dodaj");
            Assert.That(result, Is.EqualTo("Invalid input"));
        }

        [Test]
        public void NumberCheck_WhenCalled_ReturnGivenNumber()
        {
            string numberAsString = "25";
            var result = _validation.NumberCheck(numberAsString);
            Assert.That(result, Is.EqualTo(numberAsString));
        }

        [Test]
        public void NumberCheck_WhenCalled_ReturnsAsTypeOfString()
        {
            var result = _validation.NumberCheck("25");
            Assert.That(result, Is.TypeOf<String>());
        }

        [Test]
        public void SignCheck_WhenCalledNumberOtherThanTypeOfDouble_ReturnInvalidInput()
        {
            var result = _validation.NumberCheck("24,-3");
            Assert.That(result, Is.EqualTo("Invalid input"));
        }
    }
}
