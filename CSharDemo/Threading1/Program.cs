using System.Diagnostics;

namespace Threading1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    DoSomeThingComplex();
            //}
            //watch.Stop();
            //Console.WriteLine("Time taken = {0}", watch.ElapsedTicks); 


            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //for(int i = 0; i<10; i++)
            //{
            //    Thread t = new Thread(new ThreadStart(DoSomeThingComplex));
            //    t.Start();
            //    //Console.WriteLine("Current Thread ID:{0}", Thread.CurrentThread.ManagedThreadId);
            //}
            //Console.WriteLine("Time taken = {0}", stopwatch.ElapsedTicks);
            //stopwatch.Stop();


            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    Task t = new Task(new Action(DoSomeThingComplex));
            //    t.Start();
            //    Console.WriteLine("Current Task ID:{0}", t.Id.ToString());
            //}
            //Console.WriteLine("Time taken = {0}", stopwatch.ElapsedTicks);
            //stopwatch.Stop();



            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Stopwatch watch = new Stopwatch();
            watch.Start();
            //foreach (var item in arr)
            //{
            //    //Time taken = 123939
            //    Console.WriteLine($"Number : {item}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            //}
            Parallel.ForEach(arr, (number) =>
            {
                Console.WriteLine($"Number : {number}, Task Id: {Task.CurrentId}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            });
            watch.Stop();
            Console.WriteLine("Time taken = {0}", watch.ElapsedTicks);


            List<Emp> allEmployees = new List<Emp>()
            {
                 new Emp(){ ID =11,Name ="Pinky", Address ="Patna"},
                 new Emp(){ ID =12,Name ="Rahul", Address ="Nashik"},
                 new Emp(){ ID =13,Name ="Bablu", Address ="Nagpur"},
                 new Emp(){ ID =14,Name ="Raju", Address ="Pune"},
                 new Emp(){ ID =15,Name ="Banti", Address ="Indore"}
                };

            var result = (from emp in allEmployees.AsParallel()
                          where emp.Address.StartsWith("N")
                          select emp).ToList();

            foreach (var emp in result)
            {
                Console.WriteLine($"Name: {emp.Name}, Address: {emp.Address}");
            }

        }

        public static void DoSomeThingComplex()
        {
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    
                }
            }
        }
    }
    public class Emp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
