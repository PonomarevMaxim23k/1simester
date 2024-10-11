using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            first();
            BR();
            second();
            BR();
            third();
            BR();
            fourth();
            BR();
        }
        static void first()
        {
            Console.WriteLine("Введите a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("a == b");
            }
            else if (b > a)
            {
                Console.WriteLine("a < b");
            }
            else
            {
                Console.WriteLine("a > b");
            }
        }
        static void second()
        {
            Console.WriteLine("Введите a");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 5 && a < 10)
            {
                Console.WriteLine("a больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
        static void third()
        {
            Console.WriteLine("Введите a");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 5 | a == 10)
            {
                Console.WriteLine("Число либо равно 5, либо равно 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
        static void fourth()
        {
            double Dep = Convert.ToDouble(Console.ReadLine());
            if (Dep < 100){
            
            }

        }
        static void BR() { Console.WriteLine("Нажмите любую клавишу"); Console.ReadKey(); }

    }
}
