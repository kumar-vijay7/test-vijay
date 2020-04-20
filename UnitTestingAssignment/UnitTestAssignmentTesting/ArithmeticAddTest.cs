using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingAssignment;

namespace UnitTestingAssignment.Tests
{
    [TestClass()]
    public class ArithmeticAddTest
    {
        /// <summary>
        /// Adding two value Double with double
        /// </summary>
        [TestMethod]
        public void AddingTwoNumber_DoubleValues()
        {
            //Arrange
            double number1 = 0.2556;
            double number2 = 0.5468;
            double expectedresult = 0.8024;
            ArithmeticOperations add = new ArithmeticOperations();

            //Act
            var result = add.ArtiticmeticAdd(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }

        /// <summary>
        /// Adding Double with Intger Value
        /// </summary>
        [TestMethod]
        public void AddingTwoNumber_DoubleAddWithIntegerValues()
        {
            //Arrange
            double number1 = 0.2556;
            int number2 = 277;
            double expectedresult = 277.2556;
            ArithmeticOperations add = new ArithmeticOperations();

            //Act
            var result = add.ArtiticmeticAdd(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }


        /// <summary>
        /// Adding Two numbers Double with Float value
        /// </summary>
        [TestMethod]
        public void AddingTwoNumber_DoublewithFloatValues()
        {
            //Arrange
            double number1 = 0.25;
            float number2 = 2.7f;
            double expectedresult = 2.95;
            ArithmeticOperations add = new ArithmeticOperations();

            //Act
            var result = add.ArtiticmeticAdd(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }

        /// <summary>
        /// Adding two numbers Double with negative integer
        /// </summary>
        [TestMethod]
        public void AddingTwoNumber_DoublewithNegativeIntValues()
        {
            //Arrange
            double number1 = 0.25;
            int number2 = -25;
            double expectedresult = -24.75;
            ArithmeticOperations add = new ArithmeticOperations();

            //Act
            var result = add.ArtiticmeticAdd(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }


        /// <summary>
        /// Adding Two Integer Values
        /// </summary>
        [TestMethod]
        public void AddingTwoNumber_IntegerValues()
        {
            //Arrange
            int number1 = 254;
            int number2 = 355;
            double expectedresult = 609;
            ArithmeticOperations add = new ArithmeticOperations();

            //Act
            var result = add.ArtiticmeticAdd(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }

        /// <summary>
        /// Adding Two Values Float with Float
        /// </summary>
        [TestMethod]
        public void AddingTwoNumber_floatwithFloatValues()
        {
            //Arrange
            float number1 = 0.25f;
            float number2 = 2.7f;
            double expectedresult = 2.95;
            ArithmeticOperations add = new ArithmeticOperations();

            //Act
            var result = add.ArtiticmeticAdd(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }

        /// <summary>
        /// Adding Two Int to Int values
        /// </summary>
        [TestMethod]
        public void AddingTwoNumber_IntwithIntValues()
        {
            //Arrange
            int number1 = 10;
            int number2 = 11;
            double expectedresult = 20;//intentionally Wrong result to fail the test case
            ArithmeticOperations add = new ArithmeticOperations();

            //Act
            var result = add.ArtiticmeticAdd(number1, number2);

            //Assert
            Assert.AreEqual(expectedresult, result, 0.00001, "Test case failed....");
        }



    }
}


