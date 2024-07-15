using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class SelectionMenu
    {
        public static void Selection(int choice, double accountBalance)
        {
            switch (choice)
            {
                case 1:
                    Console.Write("Enter the amount to withdraw: ");
                    double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                    if (withdrawAmount > 0 && withdrawAmount <= accountBalance)
                    {
                        Console.WriteLine($"Succesful withdraw {withdrawAmount}Remaining balance {Money}");


                    }
                    else
                    {
                        Console.WriteLine("Invalid amount or insufficient balance.Please try again.");

                    }
                    break;
                case 2:
                    Console.WriteLine($"Your current balance is ${Money}");
                    break;
                case 3:
                    Deposit.DepositCash(accountBalance);
                    break;
                default:
                    Console.WriteLine("Invalid choice.Please try again.");
                    break;
            }
        }
        public static double Money(double accountBalance, double withdrawAmount)
        {
            return accountBalance - withdrawAmount;
        }
    }
}




