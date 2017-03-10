using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int a;
            int sum = 0;
            if (x == 0)
            {
                sum = 0;
            }
            while (x > 0)
            {
                a = x % 10;
                x = x / 10;
                sum = sum + a;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
