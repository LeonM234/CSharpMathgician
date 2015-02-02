using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathgician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I AM THE MATHGICIAN");
            Console.WriteLine("What shall I math?\nFibonacci, Primes, or Integers");
            string desiredMaths = Console.ReadLine();
            Console.WriteLine("Ok.  I'm gonna do some " + desiredMaths);
            if ("Integers" == desiredMaths)
            {
                PrintIntegers();
            }
            else if ("Fibonacci" == desiredMaths)
            {
                PrintFibonacciSequence();
            }
            else if ("Primes" == desiredMaths)
            {
                PrintPrimes();
            }
            else
            {
                Console.WriteLine("Well, Actually... I Lied...");
            }
            Console.WriteLine("Press Any Key to Exit...");
            Console.ReadKey();
        }

        private static void PrintPrimes()
        {
            List<int> primes = new List<int>();
            primes.Add(2); 
            int counter = 3;
            Console.WriteLine(2);
            while (true)
            {
                bool isItPrime = true;
                for (int i = 0; i < primes.Count; i++)
                { 
                    if (counter % primes[i] == 0)
                    {
                        isItPrime = false;
                        break;
                    } 
                }
                if (isItPrime == true)
                {
                    Console.WriteLine(counter);
                    primes.Add(counter);
                        
                }
                System.Threading.Thread.Sleep(100);
                counter += 2;
            }
        }

        private static void PrintFibonacciSequence()
        {
            int previous = 0;
            int current = 1;
            while (true)
            {
                Console.WriteLine(current);
                System.Threading.Thread.Sleep(100);
                int newValue = previous + current;
                previous = current;
                current = newValue;
            }
        }

        private static void PrintIntegers()
        {
            int nextInteger = 0;
            while (true)
            {
                nextInteger++;
                Console.WriteLine(nextInteger);
            }
        }
    }
}
