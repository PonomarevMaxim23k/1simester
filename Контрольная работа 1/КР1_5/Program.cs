using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int n = Convert.ToInt32(tokens[0]);
            int t = Convert.ToInt32(tokens[1]);
            int day;
            int cool = 999;
            int cooln = 0;
            int o = 0;
            for (int i = 0; i < n; i++)
            {
                day = Convert.ToInt32(Console.ReadLine());
                if (day > t)
                {
                    o++;
                }
                if (day < cool)
                {
                    cool= day;
                    cooln = i+1;
                }
            }
            Console.WriteLine(cooln);
            Console.WriteLine(o);
            Console.ReadLine();
        }
    }
}
