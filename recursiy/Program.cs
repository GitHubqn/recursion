using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args) //Caller - вызывающая функция
        {
            int choice = 0;
            while (choice == 0) 
            {
                Console.Write("Выберите действие(1 - факториал, 2 - степень, 3 - количество чисел из ряда Фибоначчи): ");
                choice = Convert.ToInt32(Console.ReadLine());
            }

            switch (choice)
            {
                case 1:
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("fctorial = " + Factorial(num));
                    break;
                case 2:
                    Console.Write("Введите основание степени: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите показатель степени: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Power(a, n));
                    break;
                case 3:
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("_____\n");
                    Fibonacci_2(x);
                    break;
                default:
                    break;
            }
            
            Main(args);
        }
        static void Function()
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("Я функция ))");
        }
        static void Elevator(int floor)
        {
            if (floor == 0)
            {
                Console.WriteLine("Вы в подвале");
                return;
            }
            Console.WriteLine($"Вы на {floor} этаже");
            Elevator(floor - 1);
            Console.WriteLine($"Вы на {floor} этаже");
        }
        static long Factorial(long n)
        {
            if (n == 0) return 1;
            long f = n * Factorial(n - 1);
            Console.WriteLine($"{n}! = {f}");
            return f;
        }
        static double Power(double a, int n)
        {
            return n == 0 ? 1 : n > 0 ? a * Power(a, n - 1) : 1 / Power(a, -n);
        }
        static int Fibonacci(int n)
        {
            return n > 1 ? Fibonacci(n - 1) + Fibonacci(n - 2) : n;
        }
        static void Fibonacci_2(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i + " = " + Fibonacci(i)); 
            }
        }
    }
}