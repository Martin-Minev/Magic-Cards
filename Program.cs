using System;
using System.Linq;
using System.Collections.Generic;

namespace SugarCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sugarCubes = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Mort")
            {
                string[] comArgs = input.Split().ToArray();
                string command = comArgs[0];
                int value = int.Parse(comArgs[1]);

                switch (command)
                {
                    case "Add":
                        sugarCubes.Add(value);
                        break;

                    case "Remove":
                        int index = sugarCubes.FindIndex(x => x == value);
                        sugarCubes.RemoveAt(index);
                        break;

                    case "Replace":
                        int replacement = int.Parse(comArgs[2]);
                        int indexValue = sugarCubes.FindIndex(x => x == value);
                        sugarCubes[indexValue] = replacement;
                        break;

                    case "Collapse":
                        for (int i = sugarCubes.Count - 1; i >= 0; i--)
                        {
                            if (sugarCubes[i] < value)
                            {
                                sugarCubes.RemoveAt(i);

                            }

                        }
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", sugarCubes));
        }
    }
}