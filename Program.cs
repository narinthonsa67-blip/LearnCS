using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 60, b = 7;
            Console.WriteLine($"A + B = {a + b}");
            // Addition
            /* WASD
             * WASD
             * WASD
             */
            // Arrays
            string[] cars = new string[3];
            cars[0] = "Ford";
            cars[1] = "BMW";
            cars[2] = "Toyota";
            Console.WriteLine($"First car: {cars[0]}");
            Console.WriteLine($"Second car: {cars[1]}");
            Console.WriteLine($"Third car: {cars[2]}");

        }
    }
}
