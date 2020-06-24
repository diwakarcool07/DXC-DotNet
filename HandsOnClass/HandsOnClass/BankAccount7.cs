using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClass
{    
    class BankException : Exception
    {
        public BankException(string msg) : base(msg) { }
    }
    class BankAccount7
    {
        public string name;
        public long accountNumber;
        public string accountType;
        public double balance;


        public BankAccount7()
        {
            Console.WriteLine("Enter name of depositor");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account number");
            accountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account type");
            accountType= Console.ReadLine();

            Console.WriteLine("Enter balance");
            balance = double.Parse(Console.ReadLine());
        }

        public void Deposit(double newAmmount)
        {
            balance = balance + newAmmount;
        }

        public void Withdraw(double amount)
        {
            try
            {
                if (balance - amount < 0)
                    throw new BankException("Not sufficient balance");
                else
                    balance = balance - amount;
            }
            catch(BankException b)
            {
                Console.WriteLine(b.Message);
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine(name + "/t" + balance);
        }
    }

    class Test_BankAccount
    {
        static void Main()
        {
            BankAccount7 bank = new BankAccount7();
            bank.Deposit(50000);
            bank.Withdraw(10000);
            bank.DisplayBalance();
            Console.ReadKey();
        }
    }
}
