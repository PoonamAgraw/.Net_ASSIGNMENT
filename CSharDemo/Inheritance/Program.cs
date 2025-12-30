namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Empid");
            int empid = Console.Read();
            Console.ReadLine();
            Console.WriteLine("Enter fname");
            String fname = Console.ReadLine();
            Console.WriteLine("Enter Lname");
            String lname = Console.ReadLine();

            Employee emp = new Employee(empid,fname,lname);
        

        }
    }
}
