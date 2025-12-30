using System.Xml.Linq;

namespace CSharpFeature
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CMath math = new CMath();
            Console.WriteLine($"Addition is {math.Add(3,8)}");
            Console.WriteLine($"Multiplication is {math.Mult(5, 9)}");


            string name = null;
            ////int deptID = null; 
            // int? deptID = null;
            int? deptID = 232323;
            if (deptID.HasValue)
            {
                Console.WriteLine(deptID.Value);
            }
            else
            {
                Console.WriteLine("deptID = null");
            }







            //Nullable<int> dept = null; 
            Nullable<int> dept = 1234; 
            //if(deptID != null)
            if (dept.HasValue)
            {
                Console.WriteLine($"Dept is not null and is = {dept.Value}");
            }
            else
            {
                Console.WriteLine("Dept = null");
            }

            Demo demo = new Demo() { _id = 100 };
            Console.WriteLine(demo._id);

            Demo demo1 = new Demo() { _name = "Raju", _id = 1 };
            Console.WriteLine(demo1._name + " " + demo1._id);

            Console.WriteLine("Enter name:");
            string nm = Console.ReadLine();
            Console.WriteLine("Enter description:");
            string des = Console.ReadLine();

            Demo demo2 = new Demo() { _name = nm, _description = des };

            Console.WriteLine($"Name = {demo2._name}, Description= {demo2._description}");

;
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            int[] arr1 = new int[] { 1, 2, 3 };
            foreach (int ele in arr1)
            {
                Console.WriteLine(ele);
            }
            string[] names = new string[] { "Raju" , "Bablu", "Pinky", "Babli" };
            foreach (string ele in names)
            {
                Console.WriteLine(ele);
            }




            List<Demo> listDemoObjects = new List<Demo>() {
                new Demo(){ _id = 1, _name= "Raju", _description="Indian Actor"},
                 new Demo(){ _id = 2, _name= "SRK", _description="Indian Actor"},
            };

            foreach (Demo dm in listDemoObjects)
            {
                Console.WriteLine($"Id= {dm._id}, Name = {dm._name}, Description = {dm._description}");
            }


           

            Emp emp = new Emp()
            {
                EId = 101,
                EName = "Hugh Jackman",
                isActive = true,
                Salary = 50000,
                Doj = DateTime.Now,
                Projects = new List<string>() { "C++","Java",".Net" }
            };
            Console.WriteLine($"DOJ = {emp.Doj.ToString()}");
            foreach (string str1 in emp.Projects)
            {
                Console.WriteLine(str1);
            }





            var i = 100;
            var str = "Hello";

            var emp9 = new Emp();

            
            object obj;
            int j;

            Test obj1 = new Test();
            Console.WriteLine("Enter choice");
            int ch = Convert.ToInt32(Console.ReadLine());
            var result = obj1.GetSomething(ch);




            Emp emp1 = new Emp() { EId = 1, EName = "Raju" };
            var emp2 = new Emp() { EId = 2, EName = "Taniya" };
            Console.WriteLine(emp2.GetType().ToString());
            var emp3 = new Holder() { Id = 101, Name = "Taniya", Address = "Shivaji nagar" };
            Console.WriteLine(emp3.GetType().ToString());

            var emp4 = new Holder() { Id = 101, Address = "Shivaji nagar", Name = "Taniya" };
            Console.WriteLine(emp4.GetType().ToString());


            var v1 = new { Id = 101, Name = "Raju", Address = "Pune" };
            Console.WriteLine(v1.GetType().ToString());

            var v2 = new { Id = 102, Name ="Taniya", Address = "Shivaji Nagar" };
            Console.WriteLine(v2.GetType().ToString());

            var v3 = new { Id = 102, Address = "Shivaji Nagar", Name = "Taniya" };
            Console.WriteLine(v3.GetType().ToString());

            var v4 = new { Id = 102, Address = true, Name = "Taniya" };
            Console.WriteLine(v4.GetType().ToString());

            
            Console.WriteLine(v4.Address);

            Console.WriteLine("Enter value for Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for name");
            string n= Console.ReadLine();

            var v5 = new { CId = id, CName = nm };
            Console.WriteLine($"You Entered : CId= {v5.CId}, Name= {v5.CName}");

        }
    }


    
    public class Emp
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public string EAddress { get; set; }
        public bool isActive { get; set; }
        public double Salary { get; set; }
        public DateTime Doj { get; set; }
        public List<string> Projects { get; set; }
        public Demo  demo { get; set; }
    }
    public class Demo
    {
        public int _id;
        public string _name;
        public string _description;
    }



    public class Test
    {
        public object GetSomething(Nullable<int> choice)
        {
            if (choice == 1)
            {
                return 100;
            }
            else if (choice == 2)
            {
                return new Emp() { EId = 1, EName = "Raju", isActive = false };

            }
            else
            {
                return null;
            }
        }
    }

    public class Holder
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}
