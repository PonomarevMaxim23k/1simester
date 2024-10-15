using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Численность группы = ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int c;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Возраст {0}-го человеака: ", i + 1);
                c = Convert.ToInt32(Console.ReadLine());
                if (c < 0 || c >= 200)
                {
                    Console.WriteLine("вы ввели несуществующий возраст. Попробуйте снова");
                    i--;
                }
                else
                {
                    a[i] = c;
                }
            }
            double m = 0;
            for (int i = 0; i < n; i++)
                m = m + a[i];
            m = m / n;
            int min, max;
            min = a[0];
            max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] < min)
                    min = a[i];
                if (a[i] > max)
                    max = a[i];
            }
            Console.Write("ИТОГИ:\nВсего опрошено {0}\n", n);
            Console.WriteLine("средний возраст = {0}", m);
            Console.WriteLine("Минимальный возраст = {0}", min);
            Console.WriteLine("Максимальный возраст = {0}", max);
            Console.ReadKey();
        }
    }
}
