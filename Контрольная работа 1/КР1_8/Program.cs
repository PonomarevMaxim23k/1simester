using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР1_8
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
            int full = 0;
            for (int i = 0; i < days.Length; i++)
            {
                ch = Convert.ToInt32(days[i]);
                full += ch;
                if (ch % v == 0)
                {
                    s += ch / v;
                }
                else
                {
                    s += ch / v + 1;
                }
            }
            int answer = (s - (full / v + Convert.ToInt32(full % v == 1) * 1));
            Console.WriteLine(answer);
            Console.Read();
        }
    }
}
