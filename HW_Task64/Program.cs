//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;

namespace HW_Task64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a natural number greater than 1: ");
            int number = int.Parse(Console.ReadLine());
            
            void NumberCounter(int number)
            {
                if (number < 0) Console.Write($"{number} Not a natural number");
                if (number == 0) return;
                Console.Write("{0,4}", number);
                NumberCounter(number - 1);
            }
            
            NumberCounter(number);            
        }
    }
}