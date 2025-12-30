using EntityFramework.DAL;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DacContext _DbContext = new DacContext();
            while (true)
            {
                Console.WriteLine("Enter your Db Operation Choice:");
                Console.WriteLine("1. Select, 2. Insert, 3. Update, 4. Delete");
                int opChoice = Convert.ToInt32(Console.ReadLine());
                switch (opChoice)
                {
                    case 1:
                        
                        List<Emp> allEmps = _DbContext.emps.ToList();

                        foreach (var emp in allEmps)
                        {
                            Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
                        }
                        break;
                    case 2:
                        Emp newEmp = new Emp();

                        Console.WriteLine("Enter name: ");
                        newEmp.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address");
                        newEmp.Address = Console.ReadLine();

                        _DbContext.emps.Add(newEmp);
                        _DbContext.SaveChanges();
                        break;
                    case 3:
                        Console.WriteLine("Enter Emp Id To be updated");
                        int idToBeUpdated = Convert.ToInt32(Console.ReadLine());

                        Emp empToBeUpdated = _DbContext.emps.Find(idToBeUpdated);

                        Console.WriteLine("Enter updated name: ");
                        empToBeUpdated.Name = Console.ReadLine();
                        Console.WriteLine("Enter updated Address");
                        empToBeUpdated.Address = Console.ReadLine();

                        _DbContext.SaveChanges(); 
                        break;
                    case 4:
                        Console.WriteLine("Enter Emp Id To be deleted");
                        int idToBeUDeleted = Convert.ToInt32(Console.ReadLine());
                        Emp empToBeDeleted = _DbContext.emps.Find(idToBeUDeleted);

                        _DbContext.emps.Remove(empToBeDeleted);
                        _DbContext.SaveChanges(); 
                        break;
                    default:
                        Console.WriteLine("Invalid Operation Choice");
                        break;
                }
                Console.WriteLine("Do you wish to continue? y/n:");
                string ynChoice = Console.ReadLine();
                if (ynChoice == "n")
                    break;
            }
        }
    }
}
