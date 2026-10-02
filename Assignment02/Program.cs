/*
 * Student ID : 1670317146
 * Name       : Dakanda Jaknarai
 * Section    : 129A
 * No.        : 2
 * Course     : GI113 Computer Programming (GI)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Mythril";
            const double SmeltRate = 0.20;
            const double SalvageRate = 0.35; 
            const double MaxBatch = 1000.0;
           
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"-- The {MaterialName} Forge --");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"=> Smelting Rate: {SmeltRate} / Salvage Rate: {SalvageRate}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            Console.Write("=> Choose Menu: ");
            string menuInput = Console.ReadLine();
            bool isMenuValid = char.TryParse(menuInput, out char menu);
            
            Console.Write("=> How much would you like: ");
            string amountInput = Console.ReadLine();
            bool isAmountValid = double.TryParse(amountInput, out double amount);
            
            if (isAmountValid && amount > 0 && amount <= MaxBatch)
            {
                
                if (menu == 'S' || menu == 's')
                {
                    double result = amount * SmeltRate; 
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {result:F2} {MaterialName} Ingot");
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double result = amount / SalvageRate; 
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ingot = {result:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("error: menu (Invalid menu choice. Please use S or B.)");
                }
            }
            else
            {
                Console.WriteLine("error: amount (Invalid amount. Must be a number between 0.01 and " + MaxBatch + ")");
            }
        }
    }
}
