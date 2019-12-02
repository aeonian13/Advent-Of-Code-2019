using System;
using System.IO;
using System.Linq;

namespace Day_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Advent Of Code 2019 | Day Two\n");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Part One:");

            int[] numbers = File.ReadAllText("input.txt").Split(',').Select(int.Parse).ToArray();

            numbers[1] = 12;
            numbers[2] = 2;
            bool x = true;
            int placeholder = 0;

            while (x)
            {
                switch (numbers[placeholder])
                {

                    case 1:
                        numbers[numbers[placeholder + 3]] = numbers[numbers[placeholder + 1]] + numbers[numbers[placeholder + 2]];
                        placeholder += 4;
                        break;

                    case 2:
                        numbers[numbers[placeholder + 3]] = numbers[numbers[placeholder + 1]] * numbers[numbers[placeholder + 2]];
                        placeholder += 4;
                        break;

                    case 99:
                        x = false;
                        break;

                    default: break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The puzzle input is: {numbers[0]:n0}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPart Two:");

            int finalNoun = 0;
            int finalVerb = 0;
            bool z = false;

            int[] initialValues = File.ReadAllText("input.txt").Split(',').Select(int.Parse).ToArray();

            for (int noun = 0; noun < 100; noun++)
            {
                for (int verb = 0; verb < 100; verb++)
                {

                    int[] values = (int[])initialValues.Clone();

                    values[1] = noun;
                    values[2] = verb;

                    int holdervalue = 0;
                    bool w = true;

                    while (w)
                    {
                        switch (values[holdervalue])
                        {
                            case 1:
                                values[values[holdervalue + 3]] = values[values[holdervalue + 1]] + values[values[holdervalue + 2]];
                                holdervalue += 4;
                                break;

                            case 2:
                                values[values[holdervalue + 3]] = values[values[holdervalue + 1]] * values[values[holdervalue + 2]];
                                holdervalue += 4;
                                break;

                            case 99:
                                w = false;
                                break;

                            default: break;
                        }
                    }

                    if (values[0] == 19690720)
                    {
                        z = true;
                        finalNoun = noun;
                        finalVerb = verb;
                    }

                    if (z)
                    {
                        break;
                    }
                }

                if (z)
                {
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The puzzle input is: {100 * finalNoun + finalVerb:n0}");
            Console.ReadKey();
        }
    }
}
