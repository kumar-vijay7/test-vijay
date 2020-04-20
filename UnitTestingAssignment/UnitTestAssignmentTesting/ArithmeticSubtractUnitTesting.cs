using UnitTestingAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingAssignment.Tests
{
    [TestClass()]
    public class ArithmeticSubtractUnitTesting
    {
        /// <summary>
        /// Subtract two value Double with double
        /// </summary>
        [TestMethod]
        public void SubtractTwoNumber_DoubleValues()
        {
            //Arrange
            double number1 = 2.65;
            double number2 = 3.65;
            double expectedresult = -1;
            ArithmeticOperations sub = new ArithmeticOperations();

            //Act
            var result = sub.ArtiticmeticSubtract(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }

        /// <summary>
        /// Subtract Double with Intger Value
        /// </summary>
        [TestMethod]
        public void SubtractTwoNumber_DoubleAddWithIntegerValues()
        {
            //Arrange
            double number1 = 0.26;
            int number2 = 7;
            double expectedresult = -6.74;
            ArithmeticOperations sub = new ArithmeticOperations();

            //Act
            var result = sub.ArtiticmeticSubtract(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }


        /// <summary>
        /// Subtract Two numbers Double with Float value
        /// </summary>
        [TestMethod]
        public void SubtractTwoNumber_DoublewithFloatValues()
        {
            //Arrange
            double number1 = 24.6;
            float number2 = 2.7f;
            double expectedresult = 21.9;
            ArithmeticOperations sub = new ArithmeticOperations();

            //Act
            var result = sub.ArtiticmeticSubtract(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }

        /// <summary>
        /// Subtract two numbers Double with negative integer
        /// </summary>
        [TestMethod]
        public void SubtractTwoNumber_DoublewithNegativeIntValues()
        {
            //Arrange
            int number2 = -26;
            double number1 = 77.05;
            double expectedresult = 103.05;
            ArithmeticOperations sub = new ArithmeticOperations();

            //Act
            var result = sub.ArtiticmeticSubtract(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }


        /// <summary>
        /// Subtract Two Integer Values
        /// </summary>
        [TestMethod]
        public void SubtractTwoNumber_IntegerValues()
        {
            //Arrange
            int number1 = 254;
            int number2 = 355;
            double expectedresult = -101;
            ArithmeticOperations sub = new ArithmeticOperations();

            //Act
            var result = sub.ArtiticmeticSubtract(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }

        /// <summary>
        /// Subtract Two Values Float with Float
        /// </summary>
        [TestMethod]
        public void SubtractTwoNumber_floatwithFloatValues()
        {
            //Arrange
            float number1 = 5.56f;
            float number2 = 2.7f;
            double expectedresult = 2.86;
            ArithmeticOperations sub = new ArithmeticOperations();

            //Act
            var result = sub.ArtiticmeticSubtract(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }
        /// <summary>
        /// Subtract Two Int to Int Values
        /// </summary>
        [TestMethod]
        public void SubtractTwoNumber_IntegerwithIntegerValues()
        {
            //Arrange
            int number1 = 10;
            int number2 = 11;
            double expectedresult = -3;//intentionally Wrong result to fail the test case
            ArithmeticOperations sub = new ArithmeticOperations();

            //Act
            var result = sub.ArtiticmeticSubtract(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }
        /// <summary>
        /// Subtract Both Negative Integer numbers
        /// </summary>
        [TestMethod]
        public void SubtractTwoNumber_BothNegativeIntegerwithIntegerValues()
        {
            //Arrange
            int number1 = -10;
            int number2 = -20;
            double expectedresult = -30;//Wrong Result
            ArithmeticOperations sub = new ArithmeticOperations();

            //Act
            var result = sub.ArtiticmeticSubtract(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }
    }
}

