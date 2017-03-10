using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        public class Polygon
        {
            public List<Points> body;

            public void Body()
            {
                body = new List<Points>();
            }
          
            public override string ToString()
            {
                return body;
            }
        }

        static void getPerimeter(int a, int b)
        {
            int p = 2 * (a + b);
        }

         static void ShowInfo(DirectoryInfo directory)
        {
            foreach(FileSystemInfo fInfo in directory.GetFileSystemInfos)                                                                                       )
            {
                
                Console.WriteLine(fInfo.name);
            }


        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            getPerimeter(a, b);

            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\a_khan\Documents\Polygon");

            while (true)
            {
                ShowInfo(directory);
                Console.ReadKey();
            }
        }
    }
}
