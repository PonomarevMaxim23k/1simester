using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace КР1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int q = Convert.ToInt32(tokens[0]);
            int a;
            int Count = 0;
            for (int i = 1; i < (tokens.Length) ; i++)
            {
                a = Convert.ToInt32(tokens[i]);
                if (a>=100000 && a<=999999)
                { 
                    Count++;
                }

            }
            Console.WriteLine(Count);
            Console.ReadLine();
        }
    }
}
