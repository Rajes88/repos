using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_app_list
{
    class Program
    {

        
static void Main(string[] args)
        {
            mySet();
            Console.ReadLine();
        }

        private static void mySet()
        {
            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                // Populate numbers with just even numbers.
                evenNumbers.Add(i * 2);

                // Populate oddNumbers with just odd numbers.
                oddNumbers.Add((i * 2) + 1);
            }

            Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
            DisplaySet(evenNumbers);

            Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
            DisplaySet(oddNumbers);

            // Create a new HashSet populated with even numbers.
            HashSet<int> numbers = new HashSet<int>(evenNumbers);
            Console.WriteLine("numbers UnionWith oddNumbers...");
            numbers.UnionWith(oddNumbers);

            Console.Write("numbers contains {0} elements: ", numbers.Count);
            DisplaySet(numbers);

        }

        private static void DisplaySet(HashSet<int> evenNumbers)
        {
           
                Console.Write("{");
                foreach (int i in evenNumbers)
                {
                    Console.Write(" {0}", i);
                }
                Console.WriteLine(" }");
            }
        }
    }
    

