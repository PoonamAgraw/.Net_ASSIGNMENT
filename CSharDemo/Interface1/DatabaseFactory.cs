using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public class DatabaseFactory
    {
        public IDatabase GetSomeDatabase(int dbChoice)
        {
            IDatabase db = null;
            switch (dbChoice)
            {
                case 1:db= new Sql();
                    break;
                case 2:db= new MySql();
                    break;
                case 3:db= new Oracle();
                    break;
                default:db = null;
                    break;
            }
            return db;
        }
    }
}
