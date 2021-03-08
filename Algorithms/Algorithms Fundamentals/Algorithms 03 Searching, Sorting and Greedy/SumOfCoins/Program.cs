using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int target = int.Parse(Console.ReadLine());
            coins = coins.OrderByDescending(x => x).ToArray();
            Dictionary<int, int> coinsCount = new Dictionary<int, int>();
            for (int i = 0; i < coins.Length; i++)
            {
                if (target>=coins[i])
                {
                    int countOfCoins = target / coins[i];
                    target -= countOfCoins * coins[i];
                    coinsCount.Add(coins[i], countOfCoins);
                }
            }
            if (target>0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine($"Number of coins to take: {coinsCount.Sum(x=>x.Value)}");
                foreach (var coin in coinsCount)
                {
                    Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
                }
            }
        }
    }
}
