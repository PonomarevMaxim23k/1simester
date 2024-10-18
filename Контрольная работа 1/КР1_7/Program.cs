using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            long cInd = (N - 1) / 6;
            long sInC = (N - 1) % 6 + 1;
            long oSInC = 0;
            char seatType = 'W';

            switch (sInC)
            {
                case 1: // место у окна (W)
                    oSInC = 6;
                    seatType = 'W';
                    break;
                case 2: // место среднее (M)
                    oSInC = 5;
                    seatType = 'M';
                    break;
                case 3: // место у прохода (A)
                    oSInC = 4;
                    seatType = 'A';
                    break;
                case 4: // место у прохода (A)
                    oSInC = 3;
                    seatType = 'A';
                    break;
                case 5: // место среднее (M)
                    oSInC = 2;
                    seatType = 'M';
                    break;
                case 6: // место у окна (W)
                    oSInC = 1;
                    seatType = 'W';
                    break;
            }
            long oppositeSeat = cInd * 6 + oSInC;
            Console.WriteLine($"{oppositeSeat} {seatType}");
            Console.ReadLine();
        }
    }
}
