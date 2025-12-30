using System.Collections;

namespace CSharpFeature2
{
    public delegate bool MyDelegate(int num);
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number:");
            //int n = Convert.ToInt32 (Console.ReadLine());
            //var result = Check(n);
            //if (result)
            //{
            //    Console.WriteLine($"Number {n} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {n} is smaller than 10");
            //}


            //MyDelegate myDelegate = new MyDelegate(Check);
            //var result = myDelegate(n);
            //if (result)
            //{
            //    Console.WriteLine($"Number {n} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {n} is smaller than 10");
            //}


            //MyDelegate myDelegate = new MyDelegate(delegate (int num)
            //{
            //    return num > 10;
            //});

            //var result = myDelegate(n);
            //if (result)
            //{
            //    Console.WriteLine($"Number {n} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {n} is smaller than 10");
            //}



            //MyDelegate myDelegate = delegate (int num)
            //{
            //    return num > 10;
            //};

            //var result = myDelegate(n);
            //if (result)
            //{
            //    Console.WriteLine($"Number {n} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {n} is smaller than 10");
            //}


            //MyDelegate myDelegate =  (int num)=>
            //{
            //    return num > 10;
            //};

            //var result = myDelegate(n);
            //if (result)
            //{
            //    Console.WriteLine($"Number {n} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {n} is smaller than 10");
            //}


            //MyDelegate myDelegate = num => num > 10;
            //var result = myDelegate(n);
            //if (result)
            //{
            //    Console.WriteLine($"Number {n} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {n} is smaller than 10");
            //}



            //Predicate<int> predicate = num => num > 10;

            //if (predicate(n))
            //{
            //    Console.WriteLine($"Number {n} is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {n} is smaller than 10");
            //}


            //int[] arr = new int[] {0,1,2,3,4,5,6,7,8,9,10};
            //var result = arr.Sum();
            //Console.WriteLine($"Addition is : {result}");

            //var result1 = MySum(arr);
            //Console.WriteLine($"Addition is : {result1}");

            //string[] arr1 = new string[] { "Hello", "Good", "Morning", "Mam" };
            //var result2 = MySum(arr1);
            //Console.WriteLine($"Addition is : {result2}");



            //Console.WriteLine("Enter your email:");
            //string? email = Console.ReadLine();
            //if (email != null)
            //{
            //    if (CheckForValidEmail(email))
            //    {
            //        Console.WriteLine("Valid email id");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid email id");
            //    }
            //}

            //Console.WriteLine("Enter your email:");
            //string? email = Console.ReadLine();
            //if (email != null)
            //{
            //    if (email.CheckForValidEmail())
            //    {
            //        Console.WriteLine("Valid email id");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid email id");
            //    }
            //}




            //int[] numbers = { 101, 102, 103, 104, 105 };
            //string[] days = { "Mon", "Tue", "Wed", "Sun" };

            //List<int> output1 = numbers.ConvertToList(1111);
            //foreach (var item in output1)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //List<string> output2 = days.ConvertToList(4789);
            //foreach (var item in output2)
            //{
            //    Console.WriteLine($"{item}");
            //}



            //int[] arr = { 1, 2, 3, 4, 5 };
            
            //foreach (int ele in arr)
            //{
            //    Console.WriteLine(ele);
            //}
            //List<int> lstArr = new List<int>();
            //lstArr.Add(11);


            MyCustomCollection myCustomCollection = new MyCustomCollection();
            myCustomCollection.AddElement(10);
            myCustomCollection.AddElement(20);
            myCustomCollection.AddElement(30);

            var result = myCustomCollection.GetElements;
            for(int i = 0;i<result.Count;i++)
            {
                Console.WriteLine(result[i]);
            }

            foreach(var iteam in result)
            {
                Console.WriteLine(iteam);
            }

            foreach (var item in myCustomCollection)
            {
                Console.WriteLine($"--{item}");
            }



            MyCollection myCollection = new MyCollection();
            foreach(string day in myCollection)
            {
                Console.WriteLine(day);
            }
        }

        public static bool Check(int x)
        {
            return x > 10;
        }


        public static T MySum<T>(IEnumerable<T> arr)
        {
            dynamic sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }



    }

    public static class MyClass
    {
        public static bool CheckForValidEmail(this string email)
        {
            return email.Contains("@g.com");
        }

        public static List<T> ConvertToList<T>(this IEnumerable<T> source, int nonsenseParameter)
        {
            List<T> list = new List<T>();
            foreach (var item in source)
            {
                list.Add(item);
            }
            Console.WriteLine($"Nonsense Parameter value = {nonsenseParameter}");
            return list;
        }
    }



    public class MyCustomCollection : IEnumerable
    {
        private ArrayList  arr = new ArrayList();
        public ArrayList GetElements
        {
            set
            {
                arr.Add(value);
            }
            get
            {
                return arr;
            }
        }
        public void AddElement(int element)
        {
            arr.Add(element);
        }

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < arr.Count; i++)
            {
                yield return arr[i];
            }
        }
    }

    public class MyCollection : IEnumerable
    {
        private string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public IEnumerator GetEnumerator()
        {
            for(int i = 0;i < days.Length; i++)
            {
                string day = days[i];
                yield return day;
            }
        }
    }
}
