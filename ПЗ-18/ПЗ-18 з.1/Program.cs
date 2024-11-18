using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ПЗ_18_з._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Z2();
            Console.ReadLine();
        }
        static void Z2()
        {
            Console.WriteLine("Напишите число цифер у билетов");  
            int a=Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i = 1; i< Math.Pow(10,Convert.ToInt32(a)); i++){
                string istr=Convert.ToString(i);
                string u = "";
                for (int p = 0; p < (Convert.ToInt32(a) - Convert.ToInt32(istr.Length)); p++) 
                {
                    u += '0';
                }
                u += Convert.ToString(i);
                int o = 0, r = 0;
                for (int j = 0; j < (a) / 2; j++)
                {
                    o += Convert.ToInt32(u[j]);
                    r += Convert.ToInt32(u[a - 1 - j]);
                }
                if (o == r) { count++; }
            }
            Console.WriteLine("Количество ''счастливых'' билетов : "+count);
        }
    }
}
