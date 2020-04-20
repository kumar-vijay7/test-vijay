using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingAssignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingAssignment.Tests
{
    [TestClass()]
    public class ArithmeticMultiplication
    {
        /// <summary>
        /// Multiplication two value Double with double
        /// </summary>
        [TestMethod]
        public void MultiplicationTwoNumber_DoubleValues()
        {
            //Arrange
            double number1 = 3.5;
            double number2 = 4.5;
            double expectedresult = 15.75;
            ArithmeticOperations multiplication = new ArithmeticOperations();

            //Act
            var result = multiplication.ArtiticmeticMultiplication(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }

        /// <summary>
        /// Adding Double with Intger Value
        /// </summary>
        [TestMethod]
        public void MultiplicationTwoNumber_DoubleAddWithIntegerValues()
        {
            //Arrange
            double number1 = 7.56;
            int number2 = 7;
            double expectedresult = 52.92;
            ArithmeticOperations multiplication = new ArithmeticOperations();

            //Act
            var result = multiplication.ArtiticmeticMultiplication(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }


        /// <summary>
        /// Multiplication Two numbers Double with Float value
        /// </summary>
        [TestMethod]
        public void MultiplicationTwoNumber_DoublewithFloatValues()
        {
            //Arrange
            double number1 = 77.25;
            float number2 = 3.5f;
            double expectedresult = 270.375;
            ArithmeticOperations multiplication = new ArithmeticOperations();

            //Act
            var result = multiplication.ArtiticmeticMultiplication(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }

        /// <summary>
        /// Adding two numbers Double with negative integer
        /// </summary>
        [TestMethod]
        public void MultiplicationTwoNumber_DoublewithNegativeIntValues()
        {
            //Arrange
            double number1 = 8.25;
            int number2 = -15;
            double expectedresult = -123.75;
            ArithmeticOperations multiplication = new ArithmeticOperations();

            //Act
            var result = multiplication.ArtiticmeticMultiplication(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }


        /// <summary>
        /// Multiplication Two Integer Values
        /// </summary>
        [TestMethod]
        public void MultiplicationTwoNumber_IntegerValues()
        {
            //Arrange
            int number1 = 2;
            int number2 = 6;
            double expectedresult = 12;
            ArithmeticOperations multiplication = new ArithmeticOperations();

            //Act
            var result = multiplication.ArtiticmeticMultiplication(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }

        /// <summary>
        /// Multiplication Two Values Float with Float
        /// </summary>
        [TestMethod]
        public void MultiplicationTwoNumber_floatwithFloatValues()
        {
            //Arrange
            float number1 = 9.5f;
            float number2 = 3.7f;
            double expectedresult = 35.15;
            ArithmeticOperations multiplication = new ArithmeticOperations();

            //Act
            var result = multiplication.ArtiticmeticMultiplication(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }

        /// <summary>
        /// Multiplication Two Int to Int values
        /// </summary>
        [TestMethod]
        public void MultiplicationTwoNumber_IntwithIntValues()
        {
            //Arrange
            int number1 = 10;
            int number2 = 10;
            double expectedresult = 101;//intentionally Wrong result to fail the test case
            ArithmeticOperations multiplication = new ArithmeticOperations();

            //Act
            var result = multiplication.ArtiticmeticMultiplication(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }

    }
}


