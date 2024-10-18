using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР1_9
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
            string base6;
            int remainder;
            int count = 0;
            for (; a1 < a2 + 1; a1++)
            {
                b = Convert.ToString(a1);
                base6 = "";
                c = Convert.ToInt32(b);

                while (c > 0)
                {
                    remainder = c % 6; 
                    base6 = remainder + base6;     
                    c /= 6;            
                }
                int int6 = Convert.ToInt32(base6);
                if ((int6 % 100) / 10 == 5)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count}");
            Console.ReadLine();     
        }
    }
}
