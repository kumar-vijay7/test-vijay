using UnitTestingAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingAssignment.Tests
{
    [TestClass()]
    public class ArithmeticDivisionTesting
    {
        /// <summary>
        /// Divide two value Double with double
        /// </summary>
        [TestMethod]
        public void DivideTwoNumber_DoubleValues()
        {
            //Arrange
            double number1 = 2.2;
            double number2 = 3.2;
            double expectedresult = 7.04000000000000001;
            ArithmeticOperations divide = new ArithmeticOperations();

            //Act
            var result = divide.ArtiticmeticDivision(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }

        /// <summary>
        /// Divide Double with Intger Value
        /// </summary>
        [TestMethod]
        public void DivideTwoNumber_DoubleWithIntegerValues()
        {
            //Arrange
            double number1 = 5568.25;
            int number2 = 2;
            double expectedresult = 11136.5;
            ArithmeticOperations divide = new ArithmeticOperations();

            //Act
            var result = divide.ArtiticmeticDivision(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }


        /// <summary>
        /// Divide Two numbers Double with Float value
        /// </summary>
        [TestMethod]
        public void DivideTwoNumber_DoublewithFloatValues()
        {
            //Arrange
            double number1 = 10.25;
            float number2 = 2.7f;
            double expectedresult = 2.95; //intentionally wrong value to fail the test case
            ArithmeticOperations divide = new ArithmeticOperations();

            //Act
            var result = divide.ArtiticmeticDivision(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }

        /// <summary>
        /// Divide Two numbers with Denominator zero
        /// </summary>
        [TestMethod]
        public void DivideTwoNumber_WithDenominatorzero_ThrowException()
        {
            //Arrange
            double number1 = 10.0;
            int number2 = 0;
            ArithmeticOperations divide = new ArithmeticOperations();

            Assert.ThrowsException<System.DivideByZeroException>(()=>divide.ArtiticmeticDivision(number1, number2));
            
        }
    }
}

