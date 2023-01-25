/*
 Author: Elieser Myrtil
 Date: 01/24/2023
 Description: This C# console application can be utilized to display the letter grade 
              of the user depending on the numerical entry of the user.
*/

using System; // calling the library for the code that is needed, such as WriteLine.

namespace Conditional_Statement__1
{
    internal class Program
    {
        static void Main(string[] args) // The main function belongs to the class
        {
            Console.WriteLine("What grade do you expect to get in ISM 4300 (n1): ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 >100)
            {
                Console.WriteLine("The input exceeds 100");
                Console.ReadKey(true);
            }
            
            else if (n1 >=90)
            {
                Console.WriteLine(" Your grade will be an A.");
                Console.ReadKey(true);
            }
            
            else if (n1 <= 89 && n1 >=80)
            {
                Console.WriteLine(" Your grade will be a B.");
                Console.ReadKey(true);
            }
            
            else if (n1 <= 79 && n1 >= 70)
            {
                Console.WriteLine(" Your grade will be a C.");
                Console.ReadKey(true);
            }
            
            else if (n1 <= 69 && n1 >= 60)
            {
                Console.WriteLine(" Your grade will be a D.");
                Console.ReadKey(true);
            }

            else
            {
                Console.WriteLine(" Your grade will be an F.");
                Console.ReadKey(true);
            }

            // try catch statements

            try
            {
                Console.WriteLine("What grade they expect to get in ISM 4300? (n1):");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("The input is: " + n2);
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Please use an integer number");
                Console.ReadKey(true);           
            }

            /* Switch
             
            Console.WriteLine("Enter some integer number (n3): ");
            int n3 = int.Parse(Console.ReadLine());

            switch (n3)
            {
                case 0:
                    Console.WriteLine("Input is 0");
                    Console.ReadKey(true);
                    break;

                case 1:
                    Console.WriteLine("Input is 1");
                    Console.ReadKey(true);
                    break;

                case 2:
                    Console.WriteLine("Input is 2");
                    Console.ReadKey(true);
                    break;

                default:
                    Console.WriteLine("Input is not in range [0,2]");
                    break;

            }
            */
        }
    }
}