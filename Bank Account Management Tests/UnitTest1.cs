using FluentAssertions;
using MyProgram;
using Xunit;

namespace Bank_Account_Management_Tests
{
    public class BankAccountTests
    {
        [Fact]
        public void CalculatingOfADeposit()
        {
            //Arrage
            BankAccount bankaccount = new BankAccount();

            //Act
            bankaccount.Deposit(10);

            //Assort
            bankaccount.balance.Should().Be(10);
        }

        [Fact]

        public void CalculatingOfADepositNegative()
        {
            //Arrage
            BankAccount bankaccount = new BankAccount();
            bankaccount.balance = 100;

            //Act
            bankaccount.Deposit(-10);

            //Assort
            bankaccount.balance.Should().Be(100);
        }

        [Fact]
        public void CalculatingOfAWithdrawNonNegative()
        {
            //Arrage
            BankAccount bankaccount = new BankAccount();
            bankaccount.balance = 100;

            //Act
            bankaccount.Withdraw(10);

            //Assort
            bankaccount.balance.Should().Be(90);
        }
        [Fact]
        public void CalculatingOfAWithdrawBiggerThanBalance()
        {
            //Arrage
            BankAccount bankaccount = new BankAccount();
            bankaccount.balance = 100;

            //Act
            bankaccount.Withdraw(110);

            //Assort
            bankaccount.balance.Should().Be(100);
        }

        [Fact]
        public void CCalculatingOfAWithdrawNegative()
        {
            //Arrage
            BankAccount bankaccount = new BankAccount();
            bankaccount.balance = 100;

            //Act
            bankaccount.Withdraw(-10);

            //Assort
            bankaccount.balance.Should().Be(100);
        }
    }




}

