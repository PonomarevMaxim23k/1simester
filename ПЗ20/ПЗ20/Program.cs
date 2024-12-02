using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(sumstr());
            Console.ReadLine();
        }
        static int sumstr()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a != 0)
            {
                return a+sumstr(); 
            }
            else{ return 0; }
        }
    }
}
