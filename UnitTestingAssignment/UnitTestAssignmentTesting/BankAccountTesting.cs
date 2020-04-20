using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTestingAssignment;

namespace UnitTestingAssignment.Tests
{
    [TestClass()]
    public class BankAccountTesting
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 3000.00;
            double debitAmount = 300.00;
            double expected = 2700;
            double loadFactor = 0.001;
            BankAccount account = new BankAccount("AF257025465", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, loadFactor, "Account not debited correctly");
        }


        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 3000.00;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("AF257025467", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

        [TestMethod]
        public void Debit_WhenAmountIsNotGreaterThanFiveThousand_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 15000;
            double debitAmount = 6500;
            BankAccount account = new BankAccount("AF25702548", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));

        }
    }
}