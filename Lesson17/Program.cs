using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    class BankAccount <T>
    {
        T accountNumber;
        double balance;
        string ownersName;
        public BankAccount(T accountNumber, double balance, string ownersName)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.ownersName = ownersName;
        }

        public T GetAccountNumber()
        { return accountNumber; }
        public void SetAccountNumber(T accountNumber)
        {  this.accountNumber = accountNumber; }
        public double GetBalance() { return balance; }
        public void SetBalance(double balance)
        {this.balance = balance; }
        public string GetOwnersName() {  return ownersName; }
        public void SetOwnersName(string ownersName)
        { this.ownersName = ownersName;}
        public void ShowData()
        {
            Console.WriteLine($"Имя владельца: {ownersName}, баланс: {balance}, номер счета: {accountNumber}");
        }

    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
           long accountNumber1 = 4245213124535;
            double balance1 = 5125412;
            string owner1 = "Иванов Михаил Степанович";
            string accountNumber2 = "SBER_051512512";
            double balance2 = 1095112;
            string owner2 = "Сидоров Петр Михайлович";
            BankAccount<long> intAccount = new BankAccount<long>(accountNumber1, balance1, owner1);
            BankAccount<string> stringAccount = new BankAccount<string>(accountNumber2, balance2, owner2);
            intAccount.ShowData();
            stringAccount.ShowData();
        }
    }
}
