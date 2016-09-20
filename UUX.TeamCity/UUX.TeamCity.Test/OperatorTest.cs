using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UUX.TeamCity.BusinessLogic;

namespace UUX.TeamCity.Test
{
    [TestClass]
    public class OperatorTest
    {
        [TestMethod]
        public void TestSum()
        {
            decimal firstValue = 10;
            decimal secondValue = 5;
            decimal result = firstValue + secondValue + 5;
            decimal operatorResult = Operator.Sum(firstValue, secondValue);

            Assert.AreEqual(operatorResult, result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            decimal firstValue = 10;
            decimal secondValue = 5;
            decimal result = firstValue - secondValue + 5;
            decimal operatorResult = Operator.Subtraction(firstValue, secondValue);

            Assert.AreEqual(operatorResult, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            decimal firstValue = 10;
            decimal secondValue = 5;
            decimal result = firstValue * secondValue + 5;
            decimal operatorResult = Operator.Multiplication(firstValue, secondValue);

            Assert.AreEqual(operatorResult, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            decimal firstValue = 10;
            decimal secondValue = 5;
            decimal result = firstValue / secondValue + 5;
            decimal operatorResult = Operator.Division(firstValue, secondValue);

            Assert.AreEqual(operatorResult, result);
        }


    }
}
