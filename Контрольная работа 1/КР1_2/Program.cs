using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int a1 = Convert.ToInt32(tokens[0]);
            int a2 = Convert.ToInt32(tokens[1]);
            int c;
            string b;
            int count = 0;
            for(; a1<a2+1; a1++)
            {
                b = Convert.ToString(a1, 8);
                c = Convert.ToInt32(b);
                if ((c % 100)/10 == 7)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
