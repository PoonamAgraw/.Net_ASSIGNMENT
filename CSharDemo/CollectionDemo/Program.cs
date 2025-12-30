namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region int[]
            //int[] arr = new int[5];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion

            #region Str[]
            //string[] names = new string[5];
            //names[0] = "Bob";
            //names[1] = "Alice";
            //names[2] = "Pappu";
            //names[3] = "Raju";
            //names[4] = "Sanju";

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //} 
            #endregion

            Emp emp1 = new Emp();
            emp1.Eid= 1;
            emp1.EName = "Babli";
            emp1.EAddress = "pune";
            

            Emp emp2 = new Emp();
            emp2.Eid = 2;
            emp2.EName = "Bablu";
            emp2.EAddress = "pune";

            Emp emp3 = new Emp();
            emp3.Eid = 3;
            emp3.EName = "Raju";
            emp3.EAddress = "pune";


            Book book = new Book();
            book.Bname = "Ramayan";

            Author author = new Author();
            author.Aname = "A.P.J Kalam";



            #region Emp[]
            Emp[] emps = new Emp[3];
            emps[0] = emp1;
            emps[1] = emp2;
            emps[2] = emp3;

            for (int i = 0; i < emps.Length; i++)
            {
                Console.WriteLine($"Id: {emps[i].Eid}, Name: {emps[i].EName}, Address: {emps[i].EAddress}");
            }

            #endregion
            #region object[]

            Object[] obj = new Object[3];
            //obj[0] = 100;
            //obj[1] = "something";
            //obj[2] = emp1;
            //obj[3] = book;
            //obj[4] = 12.34;
            #endregion


            for (int i = 0; i < obj.Length; i++)
            {
                object element = obj[i];
                if(element is int)
                {
                    int j  = Convert.ToInt32(element);
                    Console.WriteLine($"Value ={j},Type={element.GetType().ToString}");
                }

                if(element is double)
                {
                    double d = Convert.ToDouble(element);
                    Console.WriteLine($"Value ={d},Type={element.GetType().ToString}");
                }
                if (element is Emp)
                {
                    Emp emp = element as Emp;
                    Console.WriteLine($"Value = {emp.Eid} {emp.EName} {emp.EAddress}, Type ={element.GetType().ToString()}");
                }
                //if (element is Book)
                //{
                //    Book book2 = element as Book;
               
                //}
            }
        }









        }
    }
    public class Emp
    {

        private string _EName;

        public string EName
        {
            get { return _EName; }
            set { _EName = value; }
        }

        private int _Eid;

        public int Eid
        {
            get { return _Eid; }
            set { _Eid = value; }
        }

        private string _EAddress;

        public string EAddress
        {
            get { return _EAddress; }
            set { _EAddress = value; }
        }
    }


    public class Book
    {
        private string _BName;

        public string Bname
        {
            get { return _BName; }
            set { _BName = value; }
        }


    }
    public class Author
    {
        private string _AName;

        public string Aname
        {
            get { return _AName; }
            set { _AName = value; }
        }

    }








    




