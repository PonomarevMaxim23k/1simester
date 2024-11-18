using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_19_Пономарев_ИС_23К
{
    internal class Z1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выведите координаты трех точек"); 
            string input = Console.ReadLine();
            string[] dot1 = input.Split(' ');
            input = Console.ReadLine();
            string[] dot2 = input.Split(' ');
            input = Console.ReadLine();
            string[] dot3 = input.Split(' ');
            double range1 = Math.Sqrt(Math.Pow(Convert.ToDouble(dot1[0]), 2) + Math.Pow(Convert.ToDouble(dot1[1]), 2) + Math.Pow(Convert.ToDouble(dot1[2]), 2));
            double range2 = Math.Sqrt(Math.Pow(Convert.ToDouble(dot2[0]), 2) + Math.Pow(Convert.ToDouble(dot2[1]), 2) + Math.Pow(Convert.ToDouble(dot2[2]), 2));
            double range3 = Math.Sqrt(Math.Pow(Convert.ToDouble(dot3[0]), 2) + Math.Pow(Convert.ToDouble(dot3[1]), 2) + Math.Pow(Convert.ToDouble(dot3[2]), 2));
            double min = Math.Min(Math.Min(range1, range2), Math.Min(range2, range3));
            double max = Math.Max(Math.Max(range1, range2), Math.Max(range2, range3));
            if ((range1 > range2 & range2 > range3) | (range3 > range2 & range2 > range1))
            {
                Console.Write($"{min}  {range2}  {max} ");
            }
            else if ((range2 > range3 & range3 > range1) | (range1 > range3 & range3 > range2))
            {
                Console.Write($"{min}  {range3}  {max} ");
            }
            else
            {
                Console.Write($"{min}  {range1}  {max} ");
            }
            Console.Write(" - удаленность этих точек");
            Console.ReadKey();
        }
    }
}
