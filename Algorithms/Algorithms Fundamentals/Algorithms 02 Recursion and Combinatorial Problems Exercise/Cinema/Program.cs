using System;
using System.Collections.Generic;
using System.Linq;

namespace Cinema
{
    class Program
    {
        static List<string> names;
        static string[] ordered;
        static HashSet<int> occupied;
        static void Main(string[] args)
        {
            names = Console.ReadLine().Split(", ").ToList();
            ordered = new string[names.Count];
            occupied = new HashSet<int>();
            string preference = Console.ReadLine();
            while (preference!="generate")
            {
                string[] prefTokens = preference.Split(" - ");
                string name = prefTokens[0];
                int seat = int.Parse(prefTokens[1]);
                ordered[seat - 1] = name;
                names.Remove(name);
                occupied.Add(seat-1);
                preference = Console.ReadLine();
            }
            GenerateCombinations(0);
        }

        private static void GenerateCombinations(int index)
        {
            if (index>=names.Count)
            {
                Console.WriteLine(string.Join(" ", MakeOrder(names, ordered)));
                return;
            }
            GenerateCombinations(index + 1);
            for (int i = index+1; i < names.Count; i++)
            {
                Swap(i, index);
                GenerateCombinations(index + 1);
                Swap(i, index);
            }
        }

        private static void Swap(int i, int currentIndx)
        {
            string temp = names[i];
            names[i] = names[currentIndx];
            names[currentIndx] = temp;
        }

        private static string[] MakeOrder(List<string> names, string[] ordered)
        {
            int nextNameIndx = 0;
            for (int i = 0; i <ordered.Length; i++)
            {
                if (occupied.Contains(i))
                {
                    continue;
                }
                else
                {
                    ordered[i] = names[nextNameIndx++];
                }
                
            }
            return ordered;
        }
    }
}
