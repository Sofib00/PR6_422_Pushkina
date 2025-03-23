using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankAccountNS;
using System.Security.Principal;
namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr.Roman Abramovich", beginningBalance);
            // Act
            account.Debit(debitAmount);
            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr.Roman Abramovich", beginningBalance);
        }
        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 1000000000000.00;
            BankAccount account = new BankAccount("Mr.Roman Abramovich", beginningBalance);
            try
            {
                account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }
        [TestMethod]
        public void Credit_WhenAmountIsNegative_ShouldThrowArgumentOutOfRange()
        {
            double beginningBalance = 100;
            double creditAmount = -100;
            BankAccount account = new BankAccount("Mr. Roman Abramovich", beginningBalance);
            try
            {
                account.Credit(creditAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.CreditAmountLessThanZeroMessage);
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void Credit_WithPositiveAmount_UpdatesBalance()
        {
            double beginningBalance = 100;
            double creditAmount = 1000;
            BankAccount account = new BankAccount("Mr.Roman Abramovich", beginningBalance);
            account.Credit(creditAmount);
            Assert.AreEqual(expected: beginningBalance + creditAmount, actual: account.Balance, delta: 0.001, message: "Баланс обновлен некорректно.");
        }
    }
}
