using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Client
{
    class Program
    {
        static readonly MathChallenge math = new MathChallenge();
        static void Main(string[] args)
        {
            int response = 6;
            do
            {
                showMenu();
                response = readAnInteger(-1);
                switch (response)
                {
                    case 1:
                        executeExerciseOne();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("That's not a valid option");
                        break;
                }
            } while (response != 6);

            Console.ReadKey();
        }

        private static void executeExerciseOne()
        {
            Console.WriteLine("How many multiples should be evaluated?");
            int readNumberOfMultiples = readAnInteger(-1);
            if (readNumberOfMultiples > 0)
            {
                int[] multiples = new int[readNumberOfMultiples];
                int maxNumber = 0;
                for (int count = 0; count < readNumberOfMultiples; count++)
                {
                    Console.WriteLine("Enter a number:");
                    multiples[count] = readAnInteger(-1);
                }
                Console.WriteLine("Enter the maximun");
                maxNumber = readAnInteger(-1);
                Console.WriteLine("The sum of all numbers multiples of those {0} is {1}", multiples.Count(), math.SumMultiples(maxNumber, multiples));
            }
        }

        static void showMenu()
        {
            Console.WriteLine("\n**Select an exercise**");
            Console.WriteLine("1. Sum of Multiples");
            Console.WriteLine("2. Suma de Multiplos");
            Console.WriteLine("3. Ejercicio 3");
            Console.WriteLine("4. Ejercicio 4");
            Console.WriteLine("5. Ejercicio 5");
            Console.WriteLine("6. Exit");
        }

        static int readAnInteger(int defaultValue)
        {
            int readInteger = defaultValue;
            try
            {
                readInteger = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                readInteger = defaultValue;
            }
            return readInteger;
        }

    }
}
