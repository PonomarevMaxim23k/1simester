using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = 2; x < 9; x++)
            {
                for(int y = 2; y < 6; y++)
                {
                    Console.Write(Convert.ToString(x*y)+" ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
