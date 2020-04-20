using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingAssignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingAssignment.Tests
{
    [TestClass()]
    public class ArithmeticEqualTesting
    {
        /// <summary>
        /// ArithmeticEqualTest_WithTwoIntegerVAlues
        /// </summary>
        [TestMethod()]
        public void ArithmeticEqualTest_WithTwoIntegerValues()
        {
            //Arrange
            int number1 = 5;
            int number2 = 5;
            bool expected = true;
            bool result;

            ArithmeticOperations equal = new ArithmeticOperations();
            //Act

            result = equal.ArithmeticEqual(number1,number2);

            //Assert
            Assert.AreEqual(expected,result);

        }
        /// <summary>
        /// ArithmeticEqualTest_WithTwoString
        /// </summary>
        [TestMethod()]
        public void ArithmeticEqualTest_WithTwoString()
        {
            //Arrange
            string number1 = "vijay";
            string number2 = "kumar";
            bool expected = false;
            bool result;

            ArithmeticOperations equal = new ArithmeticOperations();
            //Act

            result = equal.ArithmeticEqual(number1, number2);

            //Assert
            Assert.AreEqual(expected, result);

        }
        /// <summary>
        /// ArithmeticEqualTest_WithOneIntandString
        /// </summary>
        [TestMethod()]
        public void ArithmeticEqualTest_WithOneIntandString()
        {
            //Arrange
            int number1 = 25;
            string number2 = "number";
            bool expected = false;
            bool result;

            ArithmeticOperations equal = new ArithmeticOperations();
            //Act

            result = equal.ArithmeticEqual(number1, number2);

            //Assert
            Assert.AreEqual(expected, result);

        }
        /// <summary>
        /// ArithmeticEqualTest_WithOneNullAndInt
        /// </summary>
        [TestMethod()]
        public void ArithmeticEqualTest_WithOneNullAndInt()
        {
            //Arrange
            int? number1 =null ;
            int? number2 = 10;
            
            ArithmeticOperations equal = new ArithmeticOperations();


            //Assert
            Assert.ThrowsException<NullReferenceException>(() => equal.ArithmeticEqual(number1, number2));

        }
    }
}

