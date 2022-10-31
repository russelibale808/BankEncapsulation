using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount(double amount)
        {
            _balance = amount;
        }

        private double _balance = 0;

        public void Deposit(double amount)
        {
             _balance += amount;
            Console.WriteLine("Deposit accepted\n");
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
        }

        public void GetBalance()
        {
            Console.WriteLine("Current Account balance");
            Console.WriteLine(_balance);
            Console.WriteLine();
        }
        public BankAccount()
        {

        }
    }
}
