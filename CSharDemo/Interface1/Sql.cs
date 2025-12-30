using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public class Sql : IDatabase
    {
        public void delete()
        {
            Console.WriteLine("Record Deleted in SQL Successfully");
        }

        public void insert()
        {
            Console.WriteLine("Record Inserted in SQL Successfully");
        }

        public void update()
        {
            Console.WriteLine("Record Updated in SQL Successfully");
        }
    }
}
