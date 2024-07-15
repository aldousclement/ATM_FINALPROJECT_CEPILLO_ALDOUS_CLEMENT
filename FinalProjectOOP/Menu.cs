using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reviewer1
{
    internal class Menu
    {
        static List<string> Options = new List<string>();
        private static void UsersOptions()
        {
            Options.Add("1 Withdraw Cash");
            Options.Add("2 Check Balanced");
            Options.Add("3 Deposit");
            Options.Add("4 Transaction");
        }
        public static void Show()
        {
            UsersOptions();
            Console.WriteLine("Select Actions Below");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{Options[i]}");
            }

            int choice = InputMenu();
            switch (choice)
            {
                case 1:
                    Transaction.WithdrawCash();
                    break;
                case 2:
                    Transaction.CheckBalance();
                    break;
                case 3:
                    Transaction.Deposit();
                    break;
                case 4:
                    Transaction.History();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        public static int InputMenu()
        {
            Console.Write("Enter your choice (1, 2, 3 or 4): ");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            return userChoice;
        }
    }
}