using System;
using System.Globalization;

namespace Exam.utility
{
    public class Utility
    {
        public static int GetInt32Number()
        {
            
            var choice = 0;
            while (true)
            {
                try
                {
                    var strChoice = Console.ReadLine();
                    choice = Int32.Parse(strChoice);
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter a number.");
                }
            }

            return choice;
        }
    }
}