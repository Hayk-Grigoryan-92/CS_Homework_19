using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Homework_19
{
    internal class BankAccount
    {
        public string AccountNumber {  get; set; }

        private int _ballance;

        public int Ballance
        {
            get
            {
                return _ballance;
            }
            set
            {
                if(value >= 0)
                {
                    _ballance = value;  
                }
            }
        }

        public BankAccount(string number, int money)
        {
            AccountNumber = number;
            Ballance = money;
        }

        public void DisplayAccountInfo()
        {
            Console.Write($"{AccountNumber} | {Ballance} \n");
        }
    }

    class SavingsAccount : BankAccount
    {
        private double _interestRate;

        public double InterestRate
        {
            get
            {
                return _interestRate;
            }
            set
            {
                if (value >= 0)
                {
                    _interestRate = value;
                }
            }
        }

        public SavingsAccount(string number, int money, double rate) : base(number, money)
        {
            InterestRate = rate;
        }

        public void DisplaySavingsAccountInfo()
        {
            Console.Write($"{AccountNumber} | {Ballance} | {InterestRate}");
        }
    }
}
