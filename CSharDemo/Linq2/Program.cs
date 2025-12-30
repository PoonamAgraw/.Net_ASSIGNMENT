namespace Linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emps = new List<Employee>() {
            new Employee() { Id = 1, Name = "Raju", Address = "Pune" },
            new Employee() { Id = 2, Name = "Bablu", Address = "Mumbai" },
            new Employee() { Id = 3, Name = "Pinky", Address = "Pune" },
            new Employee() { Id = 4, Name = "Rohit", Address = "Patna" },
            new Employee() { Id = 5, Name = "Mohit", Address = "Mumbai" },
            new Employee() { Id = 6, Name = "Rinky", Address = "Pune" },
            new Employee() { Id = 7, Name = "Mitthu", Address = "Patna" },
            new Employee() { Id = 8, Name = "Rinku", Address = "Mumbai" },
            new Employee() { Id = 9, Name = "Siya", Address = "Pune" },
            new Employee() { Id = 10, Name = "Rahul", Address = "Puri" }
               };

            Console.WriteLine("Enter city:");
            string? city = Console.ReadLine().ToLower();

            Func<Employee, bool> del = emp => emp.Address.ToLower() == city;

            foreach (Employee emp in emps)
            {
                //if(emp.Address.ToLower() == city)
                if (del(emp))
                {
                    Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
                }
            }

        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
