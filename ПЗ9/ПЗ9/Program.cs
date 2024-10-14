using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            first();
            second();
            third();
            fourth();
        }
        static void first()
        {
            Console.WriteLine("Введите сумму вклада");
            Decimal v = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите количество месяцев");
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                v += Convert.ToDecimal(Convert.ToInt32(v) * 0.07);
            }
            Console.WriteLine(v);
            Console.WriteLine("Нажмите клавишу Enter");
            Console.ReadKey();
        }
        static void second()
        {
            Console.WriteLine("Введите сумму вклада");
            Decimal v = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введите количество месяцев");
            int t = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < t)
            {
                v += Convert.ToDecimal(Convert.ToInt64(v) * 0.07);
                i++;
            }
            Console.WriteLine(v);
            Console.WriteLine("Нажмите клавишу Enter");
            Console.ReadKey();
        }
        static void third()
        {
            int i = 1;
            for (; i < 10; i++)
            {

                int y = Convert.ToInt32(i);
                Console.WriteLine($"{y} {y * 2} {y * 3} {y * 4} {y * 5} {y * 6} {y * 7} {y * 8} {y * 9}");
            }
            Console.ReadKey();
        }
        static void fourth()
        {
            Console.WriteLine("Введите последовательно два числа в диапазоне от 0 до 10");
            int a,b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            while (a < 0 | a > 10 | b < 0 | b>10)
            {

                Console.WriteLine("Введенные числа недопустимы, попробуйте ещё раз");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(a + b);
            Console.ReadKey();
        }
    }
}
