namespace Sealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public sealed class CMath
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public int subt(int x, int y)
        {
            return x - y;
        }
    }

    public class AdvanceMath
    {
        public virtual int square(int x)
        {
            return x * x;
        }
    }

    public class MyMath : AdvanceMath {
        public virtual void SayHi()
        {
            Console.WriteLine("Hii");
        }
        public sealed override int square(int x)
        {
            return x*x*100;
        }
    
    public class MyMath2 : MyMath
        {
            public override void SayHi()
            {
                Console.WriteLine("Hello ");
            }

        }
    }
}
