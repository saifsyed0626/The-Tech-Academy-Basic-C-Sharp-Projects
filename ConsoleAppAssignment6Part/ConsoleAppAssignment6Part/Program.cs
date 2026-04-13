using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment6Part
{
    class Program
    {
        static void Main()
        {
            // =========================
            // PART 1 - STRING ARRAY + USER INPUT + TWO LOOPS
            // =========================

            string[] words = { "Apple", "Banana", "Cherry", "Date" };

            Console.Write("Enter some text to append: ");
            string userInput = Console.ReadLine();

            // Append user input to each element in the array
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i] + " " + userInput;
            }

            // Print updated array
            Console.WriteLine("\nPART 1 OUTPUT:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }


            // =========================
            // PART 2 - INFINITE LOOP FIX
            // =========================

            Console.WriteLine("\nPART 2 OUTPUT:");

            // Original infinite loop (commented out because it would never stop)
            /*
            int i = 0;
            while (true)
            {
                Console.WriteLine(words[i]);
            }
            */

            // FIXED LOOP (added condition + increment)
            int index = 0;
            while (index < words.Length)
            {
                Console.WriteLine(words[index]);
                index++; // fixes infinite loop by moving forward
            }


            // =========================
            // PART 3 - < AND <= LOOPS
            // =========================

            Console.WriteLine("\nPART 3 OUTPUT (< operator):");

            for (int i = 0; i < words.Length; i++) // uses <
            {
                Console.WriteLine(words[i]);
            }

            Console.WriteLine("\nPART 3 OUTPUT (<= operator):");

            for (int i = 0; i <= words.Length - 1; i++) // uses <=
            {
                Console.WriteLine(words[i]);
            }


            // =========================
            // PART 4 - LIST SEARCH (FIRST MATCH ONLY)
            // =========================

            List<string> fruitsPart4 = new List<string>
            {
                "Apple", "Banana", "Cherry", "Date", "Mango"
            };

            Console.Write("\nPART 4 - Enter a fruit to search: ");
            string searchInput4 = Console.ReadLine();

            bool found4 = false;

            for (int i = 0; i < fruitsPart4.Count; i++)
            {
                if (fruitsPart4[i].Equals(searchInput4, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Match found at index: " + i);
                    found4 = true;
                    break; // stops after first match
                }
            }

            if (!found4)
            {
                Console.WriteLine("Your input is not on the list.");
            }


            // =========================
            // PART 5 - LIST SEARCH (ALL MATCHES)
            // =========================

            List<string> fruitsPart5 = new List<string>
            {
                "Apple", "Banana", "Cherry", "Apple", "Mango", "Banana"
            };

            Console.Write("\nPART 5 - Enter a fruit to search: ");
            string searchInput5 = Console.ReadLine();

            bool found5 = false;

            for (int i = 0; i < fruitsPart5.Count; i++)
            {
                if (fruitsPart5[i].Equals(searchInput5, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Match found at index: " + i);
                    found5 = true;
                }
            }

            if (!found5)
            {
                Console.WriteLine("Your input is not on the list.");
            }


            // =========================
            // PART 6 - DUPLICATE CHECK WITH FOREACH
            // =========================

            List<string> itemsPart6 = new List<string>
            {
                "A", "B", "C", "D", "C", "A"
            };

            HashSet<string> seen = new HashSet<string>();

            Console.WriteLine("\nPART 6 OUTPUT:");

            foreach (string item in itemsPart6)
            {
                if (seen.Contains(item))
                {
                    Console.WriteLine(item + " - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine(item + " - this item is unique");
                    seen.Add(item);
                }
            }
        }
    }
}