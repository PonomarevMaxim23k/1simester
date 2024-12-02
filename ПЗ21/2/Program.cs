using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Circle
    { 
        int x, y;
        int radius;
        static void Main(string[] args)
        {
            
        }
        public void konstr()
        {
            x = y = radius = 0;
        }
        public void konstr(int Radius)
        {
            x = y = 0;
            radius = Radius;
        }
        public void konstr(int xx, int yy)
        {
            x = xx; y = yy;
            radius = 0;
        }
        public void konstr(int xx, int yy, int Radius)
        {
            x = xx; y = yy; radius = Radius;
        }
    }
}
