using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_3___Keyboard_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#1
            int currentYear = DateTime.Now.Year, userAge, currentAge;
            string userName;
            Console.WriteLine("Hi there! What's your name?");
            userName = Console.ReadLine();
            Console.WriteLine("Ok and how old are you right now?");
            userAge = Convert.ToInt32(Console.ReadLine());
            currentAge = currentYear - userAge;
            Console.WriteLine($"Well {userName}, it seems you were born in {currentAge}. wooooow...");

            //#2

        }
    }
}
