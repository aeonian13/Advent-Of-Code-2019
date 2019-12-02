using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day_One
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Advent Of Code 2019 | Day One\n");

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Part One:");

            string[] lines = File.ReadAllLines("input.txt");

            int[] masses = lines.Select(int.Parse).ToArray();

            int fuel = masses.Select(GetFuel).Sum();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"The sum of the fuel requirements is {fuel:n0} \n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Part Two:");

            int totalFuel = masses
                .Select(GetFinalFuel)
                .Sum();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"The sum of the fuel requirements when taking into account the mass of the added fuel is {totalFuel:n0}");

            Console.ReadKey();
        }

        static int GetFuel(int mass)
        {
            return (mass / 3) - 2;
        }

        static int GetFinalFuel(int mass)
        {
            int fuel = GetFuel(mass);
            int totalFuel = 0;
            while (fuel > 0)
            {
                totalFuel += fuel;
                fuel = GetFuel(fuel);
            }

            return totalFuel;
        }
    }
}


        

