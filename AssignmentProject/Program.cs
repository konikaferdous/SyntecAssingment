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
            if (match.Success)
            {
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
            Console.WriteLine("\n\nThe name entered are {0} aand {1} ", name1, name2);

            Console.Write("\n\nPlease enter number 1  ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("\n\nPlease enter number 2  ");
            int y = int.Parse(Console.ReadLine());

            int z = x + y;
            Console.WriteLine("\n\nThe sum of {0} and {1} is {2}", x, y, z);


            //Data type, Float type, byte,
            decimal x = 0.5555555555555555m;
            byte byteValue1 = 201;
            float flt = 3.5F;
            Console.WriteLine("My amount = {0:C}", x);
            Console.WriteLine(byteValue1);
            Console.WriteLine(flt);
            //Nullable type
            Nullable<int> i = null;
            Console.WriteLine(i.GetValueOrDefault());


            //Conversion type
            string strgNumber = "33TG";
            int Output = 0;
            bool IsConversionSuccessful = int.TryParse(strgNumber, out Output);
            if (IsConversionSuccessful)
            {
                Console.WriteLine(Output);
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }


            //char type
            char[] chars = new char[4];

            chars[0] = 'X';
            chars[1] = '\x0058';
            chars[2] = (char)88;
            chars[3] = '\u0058';

            foreach (char c in chars)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();



        }

    }
}
