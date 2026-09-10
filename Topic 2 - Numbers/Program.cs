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
            int num1, num2, num3, sum;
            Console.WriteLine("Hey could you give me a number?");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ok and another one?");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And one more?");
            num3 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2 + num3;
            Console.WriteLine($"The sum of those numbers is {sum}.");

            //#3
            double dis1, dis2, dis3, averageDis;
            Console.WriteLine("Hey could you give me a distance?");
            dis1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ok and another one?");
            dis2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("And one more please?");
            dis3 = Convert.ToDouble(Console.ReadLine());
            averageDis = (dis1 + dis2 + dis3) / 3;
            Console.WriteLine($"The average of those distances is {averageDis}.");

            //#4
            double side1, side2, hypotenuse;
            Console.WriteLine("Hey could you give me one side length of a right angle triangle");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ok and the other side length?");
            side2 = Convert.ToDouble(Console.ReadLine());
            hypotenuse = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
            Console.WriteLine($"The hypotenuse of that triangle is {hypotenuse}.");
        }
    }
}
