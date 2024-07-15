using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reviewer1
{
    internal class Transaction
    {
        private static double accountBalance = 10000;
        public static void WithdrawCash()
        {
            Console.Write("Enter the amount to withdraw: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            if (withdrawAmount > 0 && withdrawAmount <= accountBalance)
            {
                Console.WriteLine($"Succesful withdraw {withdrawAmount} Remaining balance {10000 - withdrawAmount}");
            }
            else
            {
                Console.WriteLine("Invalid amount or insufficient balance. Please try again.");
            }
        }
        public static void CheckBalance()
        {
            Console.WriteLine($"Your current balance is ${accountBalance}");
        }
        public static void Deposit()
        {
            Console.Write("Enter the amount to deposit: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Succesful deposit {depositAmount} Remaining balance {10000 + depositAmount}");
        }
        public static void History()
        {
            Console.WriteLine("History:");
            Console.WriteLine("******************************************");
            Console.WriteLine("histories of Tramsaction:                *");
            Console.WriteLine("* 1. Tramsfer Cash at A**** C***e*t M.   *");
            Console.WriteLine("* 2. Tramsfer Cash at A*** G***** A.     *");
            Console.WriteLine("* 3. Tramsfer Cash at A**** R**e D.      *");
            Console.WriteLine("* 4. Tramsfer Cash at J*** J**e c.       *");
            Console.WriteLine("******************************************");
        }
    }
}