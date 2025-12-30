namespace Linq3

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

            Console.WriteLine("Enter the first ch of city:");
            string? ch = Console.ReadLine().ToLower();

            var filterCity = new List<Employee>();
            foreach (Employee emp in emps)
            {
                if (emp.Address.ToLower().StartsWith(ch)) ;
                
                {
                    filterCity.Add(emp);
                }
            }


            //var result = (from emp in emps
            //             select emp.Name);

            //IQuerable<T> collection

            //foreach (string nm in result)
            //{
            //    Console.WriteLine(nm);
            //    //Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
            //}

            var filteredEmpCollectionBasedOnCity = (from emp in emps
                                                    where emp.Address.ToLower().StartsWith(ch)
                                                    select emp);



            foreach (Employee emp in filteredEmpCollectionBasedOnCity)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
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

