using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public class BaseClass
    {
        private int _baseNumber;
        public BaseClass()
        {
            Console.WriteLine("In Default Base Class");
        }
        public BaseClass(int baseNumber)
        {
            _baseNumber = baseNumber;
            Console.WriteLine("In Para BaseClass ");
            Console.WriteLine("BaseNumber is:", _baseNumber);
        }

        public void m1()
        {
            Console.WriteLine("In Base Class m1 Method ");
        }
}

public class DerivedClass : BaseClass {
        public DerivedClass()
        {
            Console.WriteLine("In Default Derived Class");
        }
        public DerivedClass( int _baseNumber):base(_baseNumber)
        {

        }
        public void m2()
        {
            Console.WriteLine("In Derived Class m2 Method ");
        }
    }
}
