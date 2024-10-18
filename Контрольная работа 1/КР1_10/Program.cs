using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int big = 0;
            string[] abg = Console.ReadLine().Split();
            for (int i = 0; i < abg.Length; i++)
            {
                int a = Convert.ToInt32(abg[i]);
                string g = Convert.ToString(a,2);
                int ones = 0;
                for (int j = 0; j < g.Length; j++)
                {
                    
                    if (g[j] == '1')
                        {
                        ones++;
                        }
                }
                if (ones % 2 == 0)
                {
                    if (a > big)
                    {
                        big = a;
                    }
                    ones = 0;
                }


            }
            Console.WriteLine(big);
            Console.ReadLine();
        }
    }
}
