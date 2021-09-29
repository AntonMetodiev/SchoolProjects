using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var even = nums.Where(x => x % 2 == 0);
            var odd = nums.Where(x => x % 2 != 0);
            var result = even.Sum() - odd.Sum();
            Console.WriteLine(result);
        }
    }
}
