using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
            fifth();
            BR();
            sixth();
            BR();
            seventh();
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
            Console.WriteLine("введите ваш депозит");
            double Dep = Convert.ToDouble(Console.ReadLine());
            if (Dep < 100){
                Dep = Dep * 1.05;
            }
            else if (Dep <= 200){
                Dep = Dep * 1.07;
            }
            else if (Dep <= 200)
            {
                Dep = Dep * 1.1;
            }
            Console.WriteLine(Dep);
        }
        static void fifth()
        {
            Console.WriteLine("введите ваш депозит");
            double Dep = Convert.ToDouble(Console.ReadLine());
            if (Dep < 100)
            {
                Dep = Dep * 1.05;
            }
            else if (Dep <= 200)
            {
                Dep = Dep * 1.07;
            }
            else if (Dep <= 200)
            {
                Dep = Dep * 1.1;
            }
            Dep = Dep += 15;
            Console.WriteLine(Dep);
        }
        static void sixth()
        {
            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Сложение");
                    break;
                case 2:
                    Console.WriteLine("Вычитыние");
                    break;
                case 3:
                    Console.WriteLine("Умножение");
                    break;
                default:
                    Console.WriteLine("операция неопределена");
                    break;
            }
        }
        static void seventh()
        {
            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите два числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Сложение " + (a + b));
                    
                    break;
                case 2:
                    Console.WriteLine("Вычитыние "+(a-b));
                    break;
                case 3:
                    Console.WriteLine("Умножение "+(a*b));
                    break;
                default:
                    Console.WriteLine("операция неопределена");
                    break;
            }
        }
        static void BR() { Console.WriteLine("Нажмите Enter"); Console.ReadKey(); }

    }
}