using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Deposit
    {
        public static void DepositCash(double accountBalance)
        {

            Console.Write("Enter the amount to deposit: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Succesful deposit {depositAmount} Remaining balance {accountBalance + depositAmount}");

        }
    }
}
