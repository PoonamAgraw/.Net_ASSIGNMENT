namespace GCDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass mYClass = new MyClass();
            //mYClass.SayHi();
            //mYClass.Dispose();


            //using (MyClass obj2 = new MyClass())
            //{
            //    obj2.SayHi();
            //}


            //GC.Collect(2);
            //Console.WriteLine(GC.MaxGeneration);

            //MyClass obj3 = new MyClass();
            //Console.WriteLine(GC.GetGeneration(obj3));
            //GC.WaitForPendingFinalizers();







        }
    }





    public class MyClass:IDisposable
    {
        public void Dispose() {
            Console.WriteLine("In Dispose Method");
        }
        public void SayHi()
        {
            Console.WriteLine("Hii");
        }

    }
}
