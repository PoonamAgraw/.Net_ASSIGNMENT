using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public class Oracle : IDatabase
    {
        public void delete()
        {
            Console.WriteLine("Record Deleted in Oracle Successfully");
        }

        public void insert()
        {
            Console.WriteLine("Record Inserted in Oracle Successfully");
        }

        public void update()
        {
            Console.WriteLine("Record Updated in Oracle Successfully");
        }
    }
}
