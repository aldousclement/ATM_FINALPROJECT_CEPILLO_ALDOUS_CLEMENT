using Reviewer1;
using System;
using System.Dynamic;

class ATMMachine
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Signin Account");
        Console.Write("Enter your PIN: ");
        int pinCode = Convert.ToInt32(Console.ReadLine());

        if (EvaluationPincode.PinCodeEvaluation(pinCode))
        {
            Console.WriteLine("PIN code accepted..........\n");

            while (true)
            {
                Menu.Show();

                Console.Write("Do you want to continue (y/n): ");
                string choice = Console.ReadLine();
                string inputChoice = choice.ToLower();

                if (inputChoice == "n")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
            
        }
        else
        {
            Console.WriteLine("Invalid PIN");
        }
    }
}