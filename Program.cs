using System;
using System.CodeDom;
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

            // List (Dynamic array)
            List<int> numbers = new List<int>();
            numbers.Add(64);
            numbers.Add(128);
            numbers.Add(256);
            Console.WriteLine($"First number: {numbers[0]}");
            Console.WriteLine($"Second number: {numbers[1]}");
            Console.WriteLine($"Third number: {numbers[2]}");
            numbers.Remove(128);
            Console.WriteLine($"second number: {numbers[1]}");
            numbers.Add(100);
            numbers[0] = numbers[1] + numbers[2];
            Console.WriteLine($"First number: {numbers[0]}");

            // Dictionaries
            Dictionary<string, float> products = new Dictionary<string, float>();
            products.Add("Apple", 0.99f);
            products.Add("Banana", 0.59f);
            products.Add("Orange", 0.79f);
            Console.WriteLine($"Apple: {products["Apple"]}");
            Console.WriteLine($"Banana: {products["Banana"]}");
            Console.WriteLine($"Orange: {products["Orange"]}");

            if (a > b) Console.WriteLine("Alright");

            if (products.Count > 0) Console.WriteLine("Products available");
            else Console.WriteLine("products unavailable.");

            int age = 15;
            if (age >= 18) Console.WriteLine("You are an adult.");
            else if (age >= 13) Console.WriteLine("You are a teenager.");
            else Console.WriteLine("You are a child.");

            char grade = 'B';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Good");
                    break;
                case 'C':
                    Console.WriteLine("Average");
                    break;
                case 'D':
                    Console.WriteLine("Passed");
                    break;
                case 'F':
                    Console.WriteLine("Faied");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine($"For loop iteration: {i}");
            }

            bool isTrue = true;
            int counter = 0;
            while (isTrue == true) // isTrue == true
            {
                Console.WriteLine("Eternity");
                if (counter == 10)
                {
                    isTrue = false;
                }
                counter++;
            }
            
            foreach (string car in cars)
            {
                Console.WriteLine($"Car: {car}");
            }

            for (int i = 0; i < cars.Length; i++)
            {  
                Console.WriteLine($"Car: {cars[i]}");
            }

        }
    }
}
