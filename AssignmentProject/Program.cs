using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssignmentProject
{
    class Program
    {
        public static object Success { get; private set; }


        static void Main(string[] args)
        {
            //Hello World
            Console.WriteLine("Hello World!");
            
            //Variables 
            int myInt = 5;
            double myDouble = 5.5;
            string myString = "Hello World";
            bool myBool = true;
            char Mychar = 'A';

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            Console.WriteLine(myString);
            Console.WriteLine(myBool);
            Console.WriteLine(Mychar);

            //expression
            string pattern = @"([a-zA-Z]+) (\d+)"; //july 24
            string input = "the independence day was celebrated on july 24";
            Match match = Regex.Match(input, pattern);
            if (match.Success){
                Console.WriteLine(match.Value);
            }

            //Calculator
            int operation = 0;
            double result = 0;
            Console.WriteLine("Type you first number :");
            string stringFirstNum = Console.ReadLine();
            double firstNum = Convert.ToDouble(stringFirstNum);

            Console.WriteLine("Type you second number");
            string stringSecondNum = Console.ReadLine();
            double secondNum = Convert.ToDouble(stringSecondNum);

            Console.WriteLine("Enter the operation + (addition), - (soustraction), * (multiplication), / (division), ^ (exposant) or % (reste) :");
            string stringOperation = Console.ReadLine();

            if (stringOperation == "+" || stringOperation == "addition")
            {
                operation = 1;
            }
            else if (stringOperation == "-" || stringOperation == "soustraction")
            {
                operation = 2;
            }
            else if (stringOperation == "*" || stringOperation == "multiplication")
            {
                operation = 3;
            }
            else if (stringOperation == "/" || stringOperation == "division")
            {
                operation = 4;
            }
            else if (stringOperation == "^" || stringOperation == "exposant")
            {
                operation = 5;
            }
            else if (stringOperation == "%" || stringOperation == "reste")
            {
                operation = 6;
            }
            switch (operation)
            {
                case 1:
                    result = firstNum + secondNum;
                    break;
                case 2:
                    result = firstNum - secondNum;
                    break;
                case 3:
                    result = firstNum * secondNum;
                    break;
                case 4:
                    result = firstNum / secondNum;
                    break;
                case 5:
                    result = Math.Pow(firstNum, secondNum);
                    break;
                case 6:
                    result = firstNum % secondNum;
                    break;
            }
            Console.WriteLine("\nResult of " + firstNum + " " + stringOperation + secondNum + " = " + result + ".");

            //Input and Output
            string name = "Konika";
            Console.Write("\nThe Name is " + name);

            Console.Write("\nPlease Enter Name 1 \n");
            string name1 = Console.ReadLine();

            Console.Write("\n\nPlease Enter Name 2");
            string name2 = Console.ReadLine();

            Console.WriteLine(" ");

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();



        }

    }
}
