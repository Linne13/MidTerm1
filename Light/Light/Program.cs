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

            while (true)
            {
                Thread.Sleep(100);

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("****");
                Console.WriteLine("****");
                Console.WriteLine("****");
                Console.WriteLine("****");
                Console.WriteLine("\n");

                Thread.Sleep(500);

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("****");
                Console.WriteLine("****");
                Console.WriteLine("****");
                Console.WriteLine("****");
                Console.WriteLine("\n");

                Thread.Sleep(500);

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("****");
                Console.WriteLine("****");
                Console.WriteLine("****");
                Console.WriteLine("****");

                Console.ReadKey();
            }
            
        }

       /* public static void Print2()
        {
            Thread.Sleep(300);

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("****");
            Console.WriteLine("****");
            Console.WriteLine("****");
            Console.WriteLine("****");
            
        }

        public static void Print3()
        {
            Thread.Sleep(600);

            Console.ForegroundColor = ConsoleColor.Green; 

            Console.WriteLine("****");
            Console.WriteLine("****");
            Console.WriteLine("****");
            Console.WriteLine("****");
            

        }
        */

        static void Main(string[] args)
        {
            /*Print1();
            Console.WriteLine("\n");

           Print2();
            Console.WriteLine("\n");
            Print3();
            Console.ReadKey(); */
            

            Thread t = new Thread(new ThreadStart(Print1));
            t.Start();

            /*
            Thread t2 = new Thread(new ThreadStart(Print2));
            Thread t3 = new Thread(new ThreadStart(Print3));
            t.Start();
            t2.Start();
            t3.Start();
            Console.ReadKey();*/


        }
    }
}
