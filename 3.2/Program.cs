using System;

namespace _3._2
{
    class Program
    {
        static int f(int x)
        {
            int y;
            if (x < 0) return 0;
            else
            {
                if (x == 1) return 1;
                else return y = x * x + 1;
            }
        }
        static void Main(string[] args)
        {
            int a, b, h;
            Console.WriteLine("Введите промежуток от a до b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шаг h");
            h = Convert.ToInt32(Console.ReadLine());
            if (b < a || h <=0) Console.WriteLine("Неккоректно введены данные");
            else
            {
                for (int i = a; i < b; i += h)
                {
                    Console.WriteLine("f({0}) = {1}", i, f(i));
                }
            }
        }
    }
}
