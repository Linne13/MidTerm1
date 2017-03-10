using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Light
{
    class Program
    {
        public static void Print1()
        {
            Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("****");
            Console.WriteLine("****");
            Console.WriteLine("****");
            Console.WriteLine("****");
        }

        public static void Print2()
        {
            Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("****");
            Console.WriteLine("****");
            Console.WriteLine("****");
            Console.WriteLine("****");
        }

        public static void Print3()
        {
            Thread.Sleep(100);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("****");
            Console.WriteLine("****");
            Console.WriteLine("****");
            Console.WriteLine("****");
        }


        static void Main(string[] args)
        {
            Print1();
            Console.WriteLine("\n");
            Print2();
            Console.WriteLine("\n");
            Print3();
            Console.ReadKey();

            

        }
    }
}
