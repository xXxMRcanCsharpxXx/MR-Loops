using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_loops
{
    internal class Exercises
    {
        public static void NumbersInReverse()
        {
            // Print out numbers from 5 to 1.

            Console.Clear();
            Console.WriteLine("PRINT NUMBERS IN REVERSE ORDER\n");

            // SOLUTION HERE
            {
                //int num = 5;
                //while (num > 0)
                //{
                //    Console.WriteLine(num);
                //    num--;  
                //}
                
                for(int i = 5; i > 0; i--)
                {
                    Console.WriteLine(i);
                }


            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }


        public static void ReverseCounting()
        {
            // Ask the user for a number between 1-20. Starting at the number given,
            // count backwards to 1 and print the numbers to the console.

            Console.Clear();
            Console.WriteLine("REVERSE COUNTING\n");

            // SOLUTION HERE
            {
                int i;
                Console.WriteLine("Enter a number from 1-20");
                int input = Int32.Parse(Console.ReadLine());
                for ( i = input; input >= 0; i--)
                {
                    Console.WriteLine(i);
                }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void SquareOfEvenNumbers()
        {
            // Print the squares (the number multiplied by itself) for even numbers between 1-9. For the odd numbers, just print them.

            Console.Clear();
            Console.WriteLine("PRINT THE SQUARE OF EVEN NUMBERS\n");

                // SOLUTION HERE
        {

            // Function to print all the perfect
            // squares from the given range
            static void perfectSquares(float l, float r)
            {

                // Getting the very first number
                int number = (int)Math.Ceiling(Math.Sqrt(l));

                // First number's square
                int n2 = number * number;

                // Next number is at the difference of
                number = (number * 2) + 1;

                // While the perfect squares
                // are from the range
                while ((n2 >= l && n2 <= r))
                {

                    // Print the perfect square
                    Console.Write(n2 + " ");

                    // Get the next perfect square
                    n2 = n2 + number;

                    // Next odd number to be added
                    number += 2;
                }
            }

           
            public static void Main(String[] args)
            {
                int l = 2, r = 24;

                perfectSquares(l, r);
            }
        }

        



        Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void GuessMagicNumber()
        {
            // Write a console application that asks the user for an integer.
            // If that integer is evenly divisible by 3, then print “You Won!”.
            // If it isn’t, ask the user to “Try again.”
            // Keep asking them for a number (looping) until they win.

            Console.Clear();
            Console.WriteLine("GUESS THE MAGIC NUMBER\n");

            int userInput = Convert.ToInt32(Console.ReadLine());

                // This reads the user's input and converts it to an integer.
                // We'll assume that users can only input integers.
                // SOLUTION HERE
                

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
    }
}
