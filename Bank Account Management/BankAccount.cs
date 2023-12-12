using System;

namespace MyProgram
{
   public class BankAccount
  {
    public double balance;

    public BankAccount()
    {
        balance = 0;
    }

    public void Deposit(double amount)
    {
       

            if (amount <= 0)
            { 
                Console.WriteLine(" The deposite is negative");
            }
        else
            {
                balance += amount;
                Console.WriteLine($"Deposited: ${amount}");
            }
        


    }


    
   

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount is not valid");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds!");
                return;
            }

            balance -= amount;
            Console.WriteLine($"Withdrawn: ${amount}");
        }

        public void CheckBalance()
    {
        Console.WriteLine($"Account Balance: ${balance}");
    }

  }

}


