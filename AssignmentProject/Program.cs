using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssignmentProject
{
    /*
     //polymorphism 
     
    abstract class Shape
    {
        public abstract int area();
    }
    class Rectngle: Shape
    {
        private int length;
        private int width;
        public Rectngle(int a = 0, int b= 0)
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * length);
        }

    }
    
    
    //Inheritence
        class Shape
    {
        public void setWidth(int w)
        {
           width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }    

    class Rectangular: Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }
    */

    
        /*
         
        //class
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
        public class Animal
        {
            public Animal()
            {
                Dog = "unknown";
            }
            public Animal(string dog)
            {
                Dog = dog;
            }
            public string Dog { get; }
            public override string ToString()
            {
                return Dog.ToString();
            }
        } 
        */

        class Program
        {
        public static object Success { get; private set; }
        
        static void Main(string[] args)
        {
            /*
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
            Console.WriteLine("\n\nThe name entered are {0} aand {1} ", name1, name2);

            Console.Write("\n\nPlease enter number 1  ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("\n\nPlease enter number 2  ");
            int y = int.Parse(Console.ReadLine());

            int z = x + y;
            Console.WriteLine("\n\nThe sum of {0} and {1} is {2}", x, y, z);
            

            //Data type, Float type, byte,
            decimal dec = 0.5555555555555555m;
            byte byteValue1 = 201;
            float flt = 3.5F;
            Console.WriteLine("My amount = {0:C}", dec);
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
            
            //If statement
            int a = 200;
            if (a == 20)
            {
                Console.WriteLine("Value of a is 20");
            }else if(a == 30)
            {
                Console.WriteLine("Value of a is 30");
            }else if(a == 40)
            {
                Console.WriteLine("Value of a is 40");
            }else
            {
                Console.WriteLine("None of the value is matching");
            }
            Console.WriteLine("Exact value of a is: {0}", a);
            Console.ReadLine();

            bool condition = true;
            if (condition)
            {
                Console.WriteLine("The variable is set to true.");
            }
            else
            {
                Console.WriteLine("The variable is set to false.");
            }
            */


            //Loop
            /*
            for ( ; ; )
            {
                Console.WriteLine("Hey! I am Trapped");
            }
            */

            //For loop
            /*
            int m;
            int n = 10;
            for(m=0, Console.WriteLine("Start: {0}", m); m<n; m++, n--, Console.WriteLine("m={0}, j={1}", m, n))
            {
                //Body of this For loop
            }
            //do while loop
            int z = 0;
            do
            {
                Console.WriteLine(z);
                z++;
            } while (z < 5);
            
            //While Loop
            int number = 0;

            while (number < 5)
            {
                Console.WriteLine(number);
                number = number + 1;
            }

            Console.ReadLine();
            
            //Array
            int[] array = new int[10];
            int p, r;
            for(p=0; p<10; p++)
            {
                array[p] = p + 100;
            }
            for(r=0; r<10; r++)
            {
                Console.WriteLine("Element[{0}] = {1}", r, array[r]);
            }
            Console.ReadKey();
            
            //Switch case
            char grade = 'B';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Well done");
                    break;
                case 'D':
                    Console.WriteLine("You passed");
                    break;
                case 'F':
                    Console.WriteLine("Better try again");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.WriteLine("Your grade is  {0}", grade);
            Console.ReadLine(); 
            
            //Forech loop
            var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            int count = 0;
            foreach (int element in fibNumbers)
            {
                count++;
                Console.WriteLine($"Element #{count}: {element}");
            }
            Console.WriteLine($"Number of elements: {count}   \n\n");


            char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            int male = 0, female = 0;
            foreach (char g in gender)
            {
                if (g == 'm')
                    male++;
                else if (g == 'f')
                    female++;
            }
            Console.WriteLine("Number of male = {0}", male);
            Console.WriteLine("Number of female = {0}", female);
            

            //Arithmatic Operation
            int g = 21;
            int h = 10;
            int j;
                    j = g + h;
            Console.WriteLine("1 - Value of j is {0}", j);
            j = g - h;
            Console.WriteLine("2 - Value of j is {0}", j);
            j = g * h;
            Console.WriteLine("3 - Value of j is {0}", j);
            j = g / h;
            Console.WriteLine("4 - Value of j is {0}", j);
            j = g % h;
            Console.WriteLine("5 - Value of j is {0}", j);
            j = g++;
            Console.WriteLine("6 - Value of j is {0}", j);
            j = g--;
            Console.WriteLine("7 - Value of j is {0}", j);
            Console.ReadLine();
            

            //Relational operator
            int ro1 = 21;
            int ro2 = 10;
            if(ro1 == ro2)
            {
                Console.WriteLine("ro1 is equal to ro2");
            }else
            { Console.WriteLine("ro1 isnot equal to ro2"); }
                if (ro1 < ro2)
            {
                Console.WriteLine("ro1 is less than than  ro2");
            }else
            { Console.WriteLine("ro1 is not less than than  ro2"); }
                if (ro1 > ro2)
            {
                Console.WriteLine("ro1 is greater than ro2");
            }
            else { Console.WriteLine("ro1 is greater than ro2"); }
            ro1 = 5;
            ro2 = 20;
            if(ro1 <= ro2)
            {
                Console.WriteLine("ro1 is either than less than or equal to ro2");
            }
            if (ro1 >= ro2)
            {
                Console.WriteLine("ro2 is either than less than or equal to ro1");
            }
            
            //Logical operator
            bool lo1 = true;
            bool lo2 = true;

            if(lo1 && lo2)
            {
                Console.WriteLine("This Condition is true");
            }
            if (lo1 || lo2)
            {
                Console.WriteLine("This Condition is true");
            }
            lo1 = false;
            lo2 = true;
            if (lo1 && lo2)
            {
                Console.WriteLine(" This Condition is true");
            }
            if (!(lo1 && lo2))
            {
                Console.WriteLine("Condition is true");
            }
            Console.ReadLine();

    
            //Objects & class
            Person person1 = new Person("Nashima", 6);
            Console.WriteLine("Person1 Name= {0} Age = {1}", person1.Name, person1.Age);

            Person person2 = person1; // Person are Objects
            person2.Name = "shefa";  //person2 is instance
            person2.Age = 20;

            Console.WriteLine("Person2 Name = {0} Age = {1}", person2.Name, person2.Age);
            Console.WriteLine("Person1 Name = {0} Age = {1}", person1.Name, person1.Age);


            //class
            var animal1 = new Animal();
            Console.WriteLine(animal1.Dog);
            var animal2 = new Animal("diyego");
            Console.WriteLine(animal2.Dog);
            Console.WriteLine(animal2.ToString());
            

            
            // inheritence
            Rectangular Rect = new Rectangular();
            Rect.setWidth(5);
            Rect.setHeight(7);
            Console.WriteLine("Total area: {0}", Rect.getArea());
            

            //polymorphism
            Rectngle r = new Rectngle(10, 7);
            double a = r.area();
            Console.WriteLine("Area of Ractangle: {0}", a);
            */

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();



        }

    }
}
