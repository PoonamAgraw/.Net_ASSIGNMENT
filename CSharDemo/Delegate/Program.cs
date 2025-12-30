using System.Reflection.Metadata.Ecma335;

namespace Delegate
{
    public delegate void MyDelegate();
    public delegate void MyDelegate1(string name);
    public delegate int MyAddDelegate(int x, int y);
    public delegate int MySubDelegate(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MyClass myClass = new MyClass();
            myClass.SayHello();
            myClass.Greet("Rohit");
            MyDelegate myDelegate = new MyDelegate(myClass.SayHello);
            myDelegate.Invoke();
            MyDelegate1 myDelegate1 = new MyDelegate1(myClass.Greet);
            myDelegate1.Invoke("Sumit");

            CMath cMath = new CMath();
            MyAddDelegate myAddDelegate = new MyAddDelegate(cMath.Add);

            //Console.WriteLine($"Addition is { cMath.Add(5, 9)}");
            //Console.WriteLine($"Subtraction is { cMath.Sub(9, 3)}");

            Console.WriteLine("Enter First Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int addResult = myAddDelegate(num1, num2);

            MySubDelegate mySubDelegate = new MySubDelegate(cMath.Sub);

            int subResult = mySubDelegate.Invoke(num1, num2);
            Console.WriteLine($"Addition is {addResult}  Subtraction is {subResult}");
        }
    }
    public class CMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        } 
        public int Sub(int x, int y)
        {
           return x - y;
        }
    }
    public class MyClass
    {
        public void SayHello()
        {
            Console.WriteLine("Hello..");
        }
        public void Greet(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
