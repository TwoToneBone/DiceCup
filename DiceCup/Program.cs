using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceCup
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> stats = new Dictionary<int, int>();

            string[] inputs = Console.ReadLine().Split(' ');

            int dice1 = int.Parse(inputs[0]);
            int dice2 = int.Parse(inputs[1]);

            for (int i = 1; i <= dice1; i++)
            {
                for (int ii = 1; ii <= dice2; ii++)
                {
                    int sum = i + ii;
                    int value;
                    if (stats.TryGetValue(sum, out value))
                    {
                        stats[sum] += 1;
                    }
                    else
                    {
                        stats.Add(sum, 1);
                    }
                }
            }

            var maxKvP = stats.GroupBy(kv => kv.Value).OrderByDescending(a => a.Key).First();

            foreach (var kvp in maxKvP)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
