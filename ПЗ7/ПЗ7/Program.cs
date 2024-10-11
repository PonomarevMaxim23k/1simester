using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s5, s6, s7, s8, s9, s10, s11;
            s5 = "Каждый";
            s6 = "охотник";
            s7 = "желает";
            s8 = "знать";
            s9 = "где сидит";
            s10 = "фазан";
            string[] values = new string[] { s5, s6, s7, s8, s9, s10 };
            s11 = String.Join(" ", values);
            Console.WriteLine(s11);
            Console.ReadKey();
        }
    }
}