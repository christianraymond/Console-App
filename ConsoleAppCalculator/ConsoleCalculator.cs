using System;

namespace ConsoleAppCalculator
{
    class ConsoleCalculator
    {
        public static bool NumberBetweenFive(int x, int y, int number)
        {
            return x <= number && number <= y;
        }
        static void Main(string[] args)
        {
            bool notValid = true;

            while (notValid)
            {
                try
                {
                    Console.WriteLine("Please enter a number less than 5: ");
                    int amountOfNumberInput = Convert.ToInt16(Console.ReadLine());

                    while (!NumberBetweenFive(1, 4, amountOfNumberInput)) //Checking if user input value is between 1 and 4.
                    {
                        Console.WriteLine("Not a valid amount, try again.\n"); //Inform user about the wrong input.
                        amountOfNumberInput = Convert.ToInt16(Console.ReadLine());

                    }

                    if (NumberBetweenFive(1, 4, amountOfNumberInput))
                    {
                        int result = 5 - amountOfNumberInput;
                        Console.WriteLine("The number required to get to 5 is " + result); //Let user this the result after they have entered a number less than five.

                    }

                    notValid = false;
                }
                catch
                {
                    Console.WriteLine("Text is not valid amount, try again.\n"); // Not allowing user to enter a string or a text.
                }

            }

        }
    }
}

