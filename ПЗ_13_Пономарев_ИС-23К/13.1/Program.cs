using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int[] a = new int[29];
            for(; j < 29 ; j++)
            {
                a[j] = j+21;
            }
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
