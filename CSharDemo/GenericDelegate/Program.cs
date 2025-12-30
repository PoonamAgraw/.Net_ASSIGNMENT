namespace GenericDelegate
{ 
    public delegate void MyDelegate();
    public delegate void MyDelegate1<T>(T para);
    public delegate void MyDelegate2<T1,T2>(T1 para1, T2 para2);
    public delegate bool MyDelegate3<T1>(T1 para);
    public delegate R FunDelegate<T,R>(T para);

    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            MyDelegate myDelegate = demo.SayHi;
            myDelegate();

            MyDelegate1<string> myDelegate1 = demo.SayHello;
            myDelegate1("Rahul");

            MyDelegate1<int> myDelegate2 = demo.Display;
            myDelegate2(56);

            MyDelegate3<int> myDelegate3 = demo.EvenNumber;
            Console.WriteLine(myDelegate3(56));

            MyClass myClass = new MyClass();
            MyDelegate2<string, string> myDelegate4 = demo.Greet;
            myClass.Test<string, string, string, string>(myDelegate4, "Hi", "Hello");
            
        }
    }

    public class Demo
    {
        public void SayHi()
        {
            Console.WriteLine("Hii");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public void Greet(string name, string msg) {
            Console.WriteLine($" Hello {name} , msg for you {msg}");
        }

        public void Display(int num)
        {
            Console.WriteLine($"Number is {num}");
        }

        public bool EvenNumber(int num)
        {
            return num % 2 == 0;
        }
        public bool OddNumber(int num)
        {
            return num % 2 != 0;
        }

        public int Add(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }

        public void Add(int n1, int n2, int n3, out int sum)
        {
            sum = n1 + n2 + n3;
        }
    }

    public class MyClass
    {
        public void Test<T1, T2, T3, T4>(MyDelegate2<T1,T2> myDelegate, T3 para1, T4 para2)
        {
            dynamic p1 = para1;
            dynamic p2 = para2;
            myDelegate.Invoke(p1, p2);
        }

    }
}
