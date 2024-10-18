using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int sum = 0;
            for(;a<20;a+=2)
            {
                sum += a;
                Console.WriteLine(sum);
            }
            Console.WriteLine("Сумма = {0}", sum);
            Console.ReadLine();
        }
    }
}
