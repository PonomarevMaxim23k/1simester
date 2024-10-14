using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ПЗ10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            z1();
            z2();
            z3();
            z4();
            z5();
        }
        static void z1()
        {
            int n;
            int m = 0;
            do{
                n = Convert.ToInt32(Console.ReadLine());
                if(n >= m)
                {
                    m = n;
                }
            }while (n!=0);
            Console.WriteLine("Наибольшее число последовательности: "+m);
            Console.ReadKey();
        }
        static void z2()
        {
            int n,t,p;
            p = 0;
            t = 1;
            int m = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n >= m)
                {
                    m = n;
                    p = t;
                }
                t++;
            } while (n != 0);
            Console.WriteLine($"Наибольшее число последовательности: {m}, его номер: {p}");
            Console.ReadKey();
        }
        static void z3()
        {
            double x, o, y;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите число х для операции y = 4(x-3)6-7(x-3)3 + 2");
                x = Convert.ToInt32(Console.ReadLine());
                o = x - 3;
                y = 4 * Math.Pow(o, 6) - 7 * Math.Pow(o, 3) + 2;
                Console.WriteLine($"Результат выражения равен {y}");
            }
            Console.ReadKey();
        }
        static void z4()
        {
            Console.WriteLine("Введите последовательно координаты ячеек на доске");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            int n = (i + j)%2;
            Console.WriteLine("команда выводит значение 0, если ячейка чёрная и 1, если ячейка белая. Результат - "+n);
            Console.ReadKey();
        }
        static void z5()
        {
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    if ((i + j)%2 == 0)
                    {
                        Console.Write("X ");
                    }
                    else 
                    {
                        Console.Write("O ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
