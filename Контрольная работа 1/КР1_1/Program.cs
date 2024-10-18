using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace КР1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            int s = 0;
            string[] tokens = Console.ReadLine().Split();
            int t = Convert.ToInt32(tokens[0]);
            int v = Convert.ToInt32(tokens[1]);
            string[] days = Console.ReadLine().Split();
            for (int i = 0; i < days.Length; i++)
            {
                ch = Convert.ToInt32(days[i]);
                if (ch <= v / 2)
                {
                    s += 1;
                }
                else
                {
                    ch -= v / 2;
                    s += 1;
                    if (ch % v == 0)
                        {
                        s += ch / v;
                        }
                    else
                        {
                        s += ch / v + 1;
                        }
                }
            }
            Console.WriteLine(s);
            Console.Read();
        }
    }
}
