using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExersizeRepetitions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exersize 1 
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("The numbers are:");

            for (int i = 1; i <= a; i += 3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("==========================================");
            Console.WriteLine();

            // Exersize 2
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int j = n; j >= 1; j--)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine("==========================================");
            Console.WriteLine();

            // Exersize 3
            Console.Write("x = ");

            int x = int.Parse(Console.ReadLine());

            int num3 = 1;

            for (int l = 0; l <= x; l++)
            {
                Console.WriteLine(num3);
                num3 *= 2;
            }

            Console.WriteLine("==========================================");
            Console.WriteLine();

            // Exersize 4
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());

            int num4 = 1;

            for (int k = 0; k <= y; k += 2)
            {
                Console.WriteLine(num4);
                num4 *= 4;
            }

            Console.WriteLine("==========================================");
            Console.WriteLine();

            // Exersize 5
            Console.Write("z = ");
            int z = int.Parse(Console.ReadLine());

            int num5 = 1;

            while (num5 <= z)
            {
                Console.WriteLine(num5);
                num5 = num5 * 2 + 1;
            }
        }
    }
}
