using System;
using System.Text;


namespace Bank
{
   abstract class Account
    {
        public readonly string name;
        public double balance;
        protected string type;
        public double ammount;
        public abstract bool deposit(double amount);

        public abstract bool withdraw(double amount);
        
        public double getBalance()
        {
            return balance;
        }
        
        public void printAccount()
        {
           
            Console.WriteLine("Name : " + name); 
            Console.WriteLine("Balance :" + balance);
        }
        public Account()
        {

        }
        public Account(string name,  double balance)
        {
            this.name = name;
            this.balance = balance;
        }
    }
}