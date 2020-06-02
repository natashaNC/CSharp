using System;
using System.Diagnostics;

namespace Fundamentals_I {

    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
            DivisibleBy3or5WhileLoop ();
        }

        static void PrintOneTo255 () {
            // Create a Loop that prints all values from 1-255
            for (int i = 1; i <= 255; i++) {
                Console.WriteLine (i);
            }

        }
        static void DivisibleBy3or5 () {
            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for (int i = 1; i <= 100; i++) {
                if (i % 3 == 0 && i % 5 != 0) {
                    Console.WriteLine ("Fizz");
                } else if (i % 3 != 0 && i % 5 == 0) {
                    Console.WriteLine ("Buzz");
                } else if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine ("FizzBuzz");
                }
            }
        }

        static void DivisibleBy3or5WhileLoop () {
            // (Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!
            int i = 1;
            while (i <= 100) {
                if (i % 3 == 0 && i % 5 != 0) {
                    Console.WriteLine ("Fizz");
                } else if (i % 3 != 0 && i % 5 == 0) {
                    Console.WriteLine ("Buzz");
                } else if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine ("FizzBuzz");
                }
                i++;
            }

        }

    }
}