using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Cmath : IX, IY
    {
        public int add(int x, int y)
        {
            return x+ y;
        }

        public int multi(int x, int y)
        {
            return x * y;
        }

        public int sub(int x, int y)
        {
            return x - y;
        }
    }
}
