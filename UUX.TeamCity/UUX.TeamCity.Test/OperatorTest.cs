using System;
using UUX.TeamCity.BusinessLogic;
using NUnit.Framework;

namespace UUX.TeamCity.Test
{
    [TestFixture]
    public class OperatorTest
    {
        [Test]
        public void TestSum()
        {
            decimal firstValue = 10;
            decimal secondValue = 5;
            decimal result = firstValue + secondValue;
            decimal operatorResult = Operator.Sum(firstValue, secondValue);

            Assert.AreEqual(operatorResult, result);
        }

        [Test]
        public void TestSubtraction()
        {
            decimal firstValue = 10;
            decimal secondValue = 5;
            decimal result = firstValue - secondValue;
            decimal operatorResult = Operator.Subtraction(firstValue, secondValue);

            Assert.AreEqual(operatorResult, result);
        }

        [Test]
        public void TestMultiplication()
        {
            decimal firstValue = 10;
            decimal secondValue = 5;
            decimal result = firstValue * secondValue;
            decimal operatorResult = Operator.Multiplication(firstValue, secondValue);

            Assert.AreEqual(operatorResult, result);
        }

        [Test]
        public void TestDivision()
        {
            decimal firstValue = 10;
            decimal secondValue = 5;
            decimal result = firstValue / secondValue;
            decimal operatorResult = Operator.Division(firstValue, secondValue);

            Assert.AreEqual(operatorResult, result);
        }
    }
}
