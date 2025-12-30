using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public class CMath
    {
        public int add(int x, int y) {
            Console.WriteLine("In base class");
            return x + y; 
        }
        public void add(int x, int y, int z)
        {
            //return x + y+z;
            Console.WriteLine("CMath add:{0}", (x + y + z));
        }

        public void sub(int x, int y)
        {
            Console.WriteLine("CMath Sub: {0}", (x - y));

        }
        public virtual void multi(int x, int y)
        {
            //return x + y;
            Console.WriteLine("CMath multi:{0}", (x * y));

        }
 }
        public class AdvanceMath : CMath
        {
        public   int add(int x, int y)
        {
            Console.WriteLine("In Derived class");
            return x + y;
           
        }
        public new void add(int x, int y, int z)
        {
            //return x + y+z;
            Console.WriteLine("AdvMath add:{0}", (x + y + z));
        }

        public void sub(int x, int y)
        {
            Console.WriteLine("AdvMath Sub: {0}", (x - y));

        }
        public  void multi(int x, int y)
        {
            //return x + y;
            Console.WriteLine("AdvMath multi:{0}", (x * y));

        }

    }



    
}
