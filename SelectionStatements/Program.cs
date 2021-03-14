using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 557;
            
            Console.WriteLine("Guess my favorite number from 1-1000!");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high.");
            }
            else
            {
                Console.WriteLine("Nice Guess, you are correct");
            }
        }
    }
}
