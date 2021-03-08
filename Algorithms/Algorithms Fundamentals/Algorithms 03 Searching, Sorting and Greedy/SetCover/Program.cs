using System;
using System.Collections.Generic;
using System.Linq;

namespace SetCover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            HashSet<int[]> sets = new HashSet<int[]>();
            HashSet<int[]> chosenSets = new HashSet<int[]>();
            for (int i = 0; i < n; i++)
            {
                int[] newSet = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                sets.Add(newSet);
            }
            while (sequence.Count!=0)
            {
                int[] currentSet = sets.OrderByDescending(x => x.Count(sequence.Contains)).FirstOrDefault();
                chosenSets.Add(currentSet);
                sets.Remove(currentSet);
                for (int i = 0; i < currentSet.Length; i++)
                {
                    sequence.Remove(currentSet[i]);
                }
            }
            Console.WriteLine($"Sets to take ({chosenSets.Count}):");
            foreach (var set in chosenSets)
            {
                Console.WriteLine(string.Join(", ", set));
            }
        }
    }
}
