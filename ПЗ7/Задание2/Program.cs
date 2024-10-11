using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Задание2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            first();
            second();
            third();    
            fourth();
            Console.ReadKey();
        }
        static void first()
        {
            string Text = "Я скоро поеду на научную конференцию в Курск";
            string SubString = "Курск";
            int indexOfSubstring = Text.IndexOf(SubString);
            Console.WriteLine("Индекс подстроки в строке {0} - {1}", SubString, indexOfSubstring);
        }
        static void second()
        {
            string text = "Я скоро поеду на научную конференцию в Курск";
            int ind = text.Length - 7;
            text = text.Remove(ind);
            Console.WriteLine(text);
        }
        static void third()
        {
            string text = "Я скоро поеду на научную конференцию в Курск";
            text = text.Replace("научную конференцию", "соревнование");
            Console.WriteLine(text);


        }
        static void fourth()
        {
            string text = "Я скоро поеду на научную конференцию в Курск";
            Console.WriteLine(text.ToUpper());
        }
    }
}
