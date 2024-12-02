using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    
    internal class AverageMethods
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("1 - использовать массив целых чисел, 2 - использовать массив десятичных чисел");
            Console.WriteLine("Выберите операцию:");
            string a = Console.ReadLine();
            
            
            if (a == "1")
            {
                int[] massive = { 1, 2, 3, 4, 5, 6, 7, 8, 12312,3124,12,1 };
                Console.WriteLine("Используемый массив: " + massive);
                Console.WriteLine(Average(massive));
                Console.ReadLine();
            }
            else
            {
                float[] massive = { 1F, 2F, 3F,124F };
                Console.WriteLine("Используемый массив: " + massive);
                Console.WriteLine(Average(massive));
                Console.ReadLine();
            }
            
        }
        
        static double Average(int[] ints)
            {
            double summ = 0.0;
            for (int i = 0; i < ints.Length; i++)
            {
                summ += ints[i];
            }
                return summ / ints.Length;
        }
        static float Average(float[] floats)
            {
                float summ = 0;
                for (int i = 0; i < floats.Length; i++)
                {
                    summ += floats[i];
                }
                return summ / floats.Length;
            }

        
    }
}
