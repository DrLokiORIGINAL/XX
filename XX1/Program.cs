using System;

namespace XX1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4] { 1, 2, 3, 4 };
            int u = Convert.ToInt32(Console.ReadLine());
            for (int o = 0; o < numbers.Length; o++)
            {
                numbers[o] -= u;              
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
