using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class MyMath : IY, IDemo
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public int div(int n, int m)
        {
           return n / m;
        }

        public void log(string message)
        {
           Console.WriteLine(message);
        }

        public int multi(int x, int y)
        {
           return x*y;
        }
    }
}
