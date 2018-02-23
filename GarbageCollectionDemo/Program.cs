using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Calculator calculator = new Calculator())
            {
                //Domonstration of Garbage Control when exception thrown.
                Console.WriteLine($"120 / 0 = {calculator.Divide(120, 0)}");
                //Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");
            }
            Console.WriteLine("Program finishing");
        }
    }
}
