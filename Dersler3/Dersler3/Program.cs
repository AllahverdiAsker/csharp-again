using System;

namespace Dersler3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "HASAN", "SHAMIL", "IHSAN", "MERYEM" };
            string n = "IHSAN";
            RequestedName(names, n);
            Console.WriteLine(RequestedName(names, n));
        }

        static bool RequestedName(string[] names,string n)
        {
            for(int i =0; i<names.Length; i++)
            {

                if (names[i] == n)
                {

                    return true;
                }

            }
            return false;

        }
    }
}
