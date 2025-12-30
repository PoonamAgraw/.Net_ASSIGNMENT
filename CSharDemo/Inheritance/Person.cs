using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    #region BaseClass
		
    public class Person

    {
        String fname;
        String lname;
        public Person()
        {
            Console.WriteLine("In Person Default Constructor");
        }
        public Person(String fname, String lname)
        {
            this.fname = fname;
            this.lname = lname;
            Console.WriteLine("Name {0} ,{1}", fname, lname);
        }
    } 
#endregion
    #region Derived Inheritance

    public class Employee : Person
    {
        int empid;
        public Employee()
        {
            Console.WriteLine("In Emp default constructor");
        }
        public Employee(int empid, String fname, String lname)
        {
            this.empid = empid;
            Console.WriteLine("Id {2} Name {0} {1}", fname, lname, empid);
        }
    }

    #endregion


}
