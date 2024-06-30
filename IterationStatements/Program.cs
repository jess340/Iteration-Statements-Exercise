using System;

namespace IterationStatements
{
    public class Program
    {

        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
     


        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i); 
            }
        }



        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void Threes()
        {
            for(int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k); 
            }
        }


        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static bool OrEqual(int a, int b)
        {
            if(a == b)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        //Write a method to check whether a given number is even or odd

        public static string EvenOrOdd(int number)
        {
            if(number % 2 == 0)
            {
                return ("even"); 
            }

            else
            {
                return ("odd");
            }
        }

      

        //Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative(int thisNumber)
        {

            if (thisNumber >= 0)
            {
                Console.WriteLine("This number is positive");
            }

            else
            {
                Console.WriteLine("This number is negative");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void CheckVotingAge()
        {
            Console.WriteLine("What is your age?");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                if(age >= 18)
                {
                    Console.WriteLine("Great! You are of voting age.");
                }

                else
                {
                    Console.WriteLine("Sorry! You are not of voting age.");
                }

            }
        }


        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void InRange()
        {
            Console.WriteLine("Type a number that's in the range of -10 to 10");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number >= -10 && number <= 10)
                {
                    Console.WriteLine($"Number {number} is in the range of -10 to 10.");
                }

                else
                {
                    Console.WriteLine($"Try again!{number} is not in the range");
                }
            }

        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultiTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //calling the PrintThousand Method
            PrintThousand();

            //calling the Threes Method
            Threes();

            //calling the Equal to Method
            int a = 5;
            int b = 5;
            bool result = OrEqual(a, b);

            //calling the Even or Odd Method
            int number = 5;
            string otherResult = EvenOrOdd(number);

            //calling the Posiitve or Negative Method
            int number1 = 5;
            int number2 = -10;
            int number3 = 0;

            PositiveOrNegative(number1); // Output: The number is positive.
            PositiveOrNegative(number2); // Output: The number is negative.
            PositiveOrNegative(number3); // Output: The number is zero.

            //calling the Voting Age Method
            CheckVotingAge();

            //calling the Range Method
            InRange();

            //calling the Multiplication Table
            MultiTable(number);

        }
    }
}
