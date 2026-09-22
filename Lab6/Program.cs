/*
 * Student ID : 1670317146
 * Name       : Dakanda Jaknarai
 * Section    : 129A
 * No.        : 2
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Silent Mail ===");
            Console.WriteLine("You found a creepy letter from a ghost child.");
            Console.WriteLine("1. Open the letter");
            Console.WriteLine("2. Burn the letter");
            Console.Write("Choice (1-2): ");

            bool isValid = int.TryParse(Console.ReadLine(), out int choice);

            if (!isValid)
            {
                Console.WriteLine("Error: Invalid input. The game crashes in your mind!");
            }
            else if (choice == 1)
            {
                Console.WriteLine("You opened it. The ghost child is behind you!");
            }
            else if (choice == 2)
            {
                Console.WriteLine("You burned it. You survived the night.");
            }
            else
            {
                Console.WriteLine("Error: Wrong number. The mailroom locks itself.");
            }
        }
    }
}
