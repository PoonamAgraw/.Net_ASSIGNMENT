using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class HotDrink : IDrink
    {
        public void Drink()
        {
            Console.WriteLine("You are in hot drink section");
        }
    }

   
}
