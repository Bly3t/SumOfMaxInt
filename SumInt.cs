using System;
using System.Linq;

namespace SumInt
{
    class Program
    {
        public static int notDividedByTwo(int x) // there's no need to use that method u can skip it and put if-statement in LINQ.WHERE
        {
            if(x % 2 != 0)
            {
                return x;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            try
            {
                var max = int.MaxValue;
                var ans = Enumerable.Range(1, max).Where(x => x % 2 != 0).Sum(x => (long)x);
                Console.WriteLine(ans);
            }
            catch (OverflowException)
            {
                Console.WriteLine(" > " + Int32.MaxValue);
            }
        }
    }
}
