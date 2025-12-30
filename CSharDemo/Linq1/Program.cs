namespace Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Predicate<int> _Even = x => x % 2 == 0;
            //Predicate<int> _Odd = x => x % 2 != 0;

            //Console.WriteLine("Enter a number:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //var evenResult = _Even(n);
            //var oddResult = _Odd(n);
            //Console.WriteLine($" For number {n}  Even : {evenResult}, Odd :  {oddResult}");

            //Action action = new Action(delegate () { 
            //    Console.WriteLine("Hello Good Morning"); 
            //});
            //action();


            //Action action2 = delegate () {
            //    Console.WriteLine("Hello Good Morning");
            //};
            //action2();


            //Action action3 = () =>{
            //    Console.WriteLine("Hello Good Morning");
            //};
            //action3();


            //Action action1 = () => Console.WriteLine("Hello Good Morning");
            //action1();



            //Func<int> func = new Func<int>(delegate () 
            //{  return 1;
            //});
            //var result = func();
            //Console.WriteLine(result);


            //Func<double> func1 = new Func<double>(delegate ()
            //{
            //    return 412.523;
            //});
            //var result1 = func1();
            //Console.WriteLine(result1);


            //Func<string> func2 = new Func<string>(delegate ()
            //{
            //    return "Hello";
            //});
            //var result2 = func2();
            //Console.WriteLine(result2);


            //Func<int, bool> func = new Func<int, bool>(delegate (int x)
            //{
            //    return x % 2 == 0;
            //});

            //bool result = func(12);
            //Console.WriteLine(result);



            //Func<int, bool> func = new Func<int, bool>(x => x % 2 == 0);
            //bool result = func(12);
            //Console.WriteLine(result);




            //Predicate<int> _Even = x => x % 2 == 0;
            //Predicate<int> _Odd = x => x % 2 != 0;
            //Predicate<int> _Equal=x => x == 0;
            //bool output = _Even(69);
            //Console.WriteLine(output);

            //Func<int, bool> func = new Func<int, bool>(_Odd);
            //var result=func(15);
            //Console.WriteLine(result);


            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(arr.Sum());
            //Console.WriteLine(arr.Max());
            //Predicate<int> predicate = x => x == 5;
            //Func<int, bool> func = new Func<int, bool>(predicate);
            //var result = arr.Where(func);
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}

            //Predicate<int> predicate = x => x%2 == 0;
            //Func<int, bool> func = new Func<int, bool>(predicate);
            ////var result = arr.Where(func);
            //var result = arr.Where(x => x % 2 == 0);
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}


            //Func<int, int> func3 = new Func<int, int>(no => no * 2);
            ////var doubleArr = arr.Select(func3);
            //var doubleArr = arr.Select(no => no * 2);

            //foreach (int ele in doubleArr)
            //{
            //    Console.WriteLine(ele);
            //}


            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> lstArr = arr.MySelect();

            Func<int, bool> predicate = x => x % 2 == 0;
            lstArr.MyWhere<int>(predicate);
            var evenNumbers = lstArr.MyWhere<int>(x => x % 2 == 0);
            foreach (var no in evenNumbers)
            {
                Console.WriteLine(no);
            }
          
            var result = arr.MySelect().MyWhere<int>(x => x % 2 == 0);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
    public static class MyClass
    {
        public static List<T> MySelect<T>(this IEnumerable<T> source)
        {
            var list = new List<T>();
            foreach(var item in source)
            {
                list.Add(item);
            }
            return list;
        }

        public static IEnumerable<int> MyWhere<T> (this IEnumerable<int> source,Func<int ,bool> predicate)
        {
            List<int> list = new List<int>();
            foreach(int no in source)
            {
                if(predicate(no))
                {
                    list.Add(no);
                }

            }
            return list;
        }
    }
}
