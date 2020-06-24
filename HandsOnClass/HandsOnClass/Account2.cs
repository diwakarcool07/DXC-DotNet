using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClass
{
    class Account2
    {
        public int accountno;
        public string customerName;
        public  string accountType; //static variable
        public double amount;//static variable
        public  double balance;

        public Account2(int ac,string cn,string actype,double am,double bl)
        {
            accountno = ac;
            customerName = cn;
            accountType = actype;
            amount = am;
            balance = bl;
        }
        public double credit(double amount)
        {
            double newBalance = balance + amount;
           return balance = newBalance;
        }

        public double deposite(double amount)
        {
            double newBalance = balance - amount;
            return balance = newBalance;
        }

        public void showData()
        {
            Console.WriteLine("AccountNo: " + accountno);
            Console.WriteLine("Customer name: " + customerName);
            Console.WriteLine("Account type: " + accountType);
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("balanace: " + balance);
        }

    }

    class Account_Test
    {
        static void Main()
        {
            Account2 ac = new Account2(344095, "Diwakar", "Saving", 50000, 50000);
            ac.showData();

            Console.WriteLine("Enter transaction type");
            string trans;
            string s1 = "Deposit";
            trans =Console.ReadLine();
            if (trans.Equals(s1))
            {
                Console.WriteLine(ac.credit(25000));

            }
            else
            {
               Console.WriteLine(ac.deposite(20000));
            }
            Console.ReadKey();
            
        }
        
    }
}
