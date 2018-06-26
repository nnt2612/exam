using System;
using Exam.controller;
using Exam.utility;

namespace Exam.view
{
    public class MainView
    {
        public static void GenerateMenu()
        {
            ProductController controller = new ProductController();
            while (true)
            {
                Console.WriteLine("---------WELCOME TO SPRING HERO BANK---------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Delete");
                Console.WriteLine("4. Exit.");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Please enter your choice (1|2|3): ");
                var choice = Utility.GetInt32Number();
                switch (choice)
                {
                    case 1:
                        controller.Add();
                        break;
                    case 2:                       
                        controller.Display();
                        break;
                    case 3:
                        controller.Delete();
                        break;
                    case 4:
                        Console.WriteLine("See you later.");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
    
    
}