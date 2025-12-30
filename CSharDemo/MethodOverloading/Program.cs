using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    internal class Program
    {
        void add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        void add(int x, int y,int z)
        {
            Console.WriteLine(x + y+z);
            
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.add(1, 2);
            p.add(1,2,3);


            Methods m = new Methods();
            m.add(1, 9);
        }
    }
}
