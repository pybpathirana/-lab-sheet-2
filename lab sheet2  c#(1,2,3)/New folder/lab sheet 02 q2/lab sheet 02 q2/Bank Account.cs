using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet_02_q2
{
    internal class Bank_Account
    {
        public int AccountNumber;
        public int Balance;

        public void Deposite()
        {
            float balance = 1000;
            Console.WriteLine( " Enter amount of Deposite :");
            float deposite = float.Parse(Console.ReadLine());
             balance = deposite + balance;
            Console.WriteLine(" Your current balance is (Rs):"+balance);
        }

    }
}
