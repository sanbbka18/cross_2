using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// call the library with multiplication
            /// </summary>
            /// <param name="args"></param>
            
                Console.WriteLine("Введите r:");
                double r = double.Parse(Console.ReadLine());
                double S = Task1.Class1.square(r);

                Console.WriteLine("S = {0}", S);
                Console.ReadKey();
            
        }
    }
}
