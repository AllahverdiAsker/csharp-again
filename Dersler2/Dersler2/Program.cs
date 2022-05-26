using System;

namespace Dersler2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 2, 6, 5, 4, 6, 3 };
            GPA(grades);
            
        }

        static int GPA(int[] grades)
        {
            int sum = 0;
            int counter = 0;
            for(int i=0; i<grades.Length; i++)
            {

                sum += grades[i];
                counter++;
            }

            int result = sum / counter;
            Console.WriteLine(result);
            return result;
            
        }
    }
}
