using System;

namespace XX2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4] { 5, 2, 3, 4 };
            int y = numbers[0];
            for (int e = 0; e < numbers.Length; e++)
            {
                numbers[e] /= y;
            }
            Console.WriteLine(string.Join(" ", numbers));
        } 
    }
}
