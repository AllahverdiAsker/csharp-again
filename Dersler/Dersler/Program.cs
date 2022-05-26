using System;

namespace Dersler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 5, 7, 9, 5, 4 };
            int n = 4;
            Numberscount(numbers, n);
            Console.WriteLine(Numberscount(numbers, 4));
        }

        static int Numberscount (int[] numbers,int n)

        
        {
        int count = 0;

            for(int i=0; i<numbers.Length; i++)
            {
                if (numbers[i] == 4)
                {
                    count++;
                }

            }
            return count;
        }
    }
}
