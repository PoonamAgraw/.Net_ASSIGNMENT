using LayeredArchitecture.DAL;
using LayeredArchitecture.Models;

namespace LayeredArchitecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dac50Context dac = new Dac50Context();
            int noOfRowAffected = 0;

            while (true) {
                Console.WriteLine("1.Select  2.Insert  3.Update  4.Delete  5.SearchById");
                Console.WriteLine("Enter Your Choicee!");
                int dbChoice = Convert.ToInt32(Console.ReadLine());
                switch (dbChoice) {
                    case 1:
                        var records = dac.GetEmpRecord();
                        foreach(var emp in records)
                        {
                            Console.WriteLine($"Id:{emp.EId}, Name:{emp.EName},Address:{emp.EAddress}");

                        }

                        break;
                    case 2:
                        Emp obj = new Emp();

                        
                        Console.WriteLine("Enter name");
                        obj.EName = Console.ReadLine();
                        Console.WriteLine("Enter address");
                        obj.EAddress = Console.ReadLine();

                        noOfRowAffected = dac.InsertRecord(obj);
                        if(noOfRowAffected > 0)
                        {
                            Console.WriteLine("Record inserted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Error.");
                        }

                            break;
                    case 3:
                        Emp emp1= new Emp();
                        Console.WriteLine("Enter ID for update");
                        emp1.EId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name FOr Update");
                        emp1.EName = Console.ReadLine();
                        Console.WriteLine("Enter Address for Update");
                        emp1.EAddress = Console.ReadLine();

                        noOfRowAffected=dac.UpdateRecord(emp1.EId,emp1);
                        if (noOfRowAffected > 0)
                        {
                            Console.WriteLine("Record Updated Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }




                            break;
                    case 4:
                        
                        Console.WriteLine("Enter Id FOr Delete");
                        int EId = Convert.ToInt32(Console.ReadLine());
                        noOfRowAffected = dac.DeleteRecord(EId);
                        if (noOfRowAffected > 0)
                        {
                            Console.WriteLine("Record Updated Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }


                        break;
                    case 5:
                        Console.WriteLine("Enter Id for Search");
                        int id = Convert.ToInt32(Console.ReadLine());

                        var record1 = dac.SearchById(id);
                        if(record1 != null)
                        {
                            Emp emp = record1.FirstOrDefault();
                            if(emp != null)
                            {
                                Console.WriteLine($"Id:{emp.EId}, Name:{emp.EName},Address:{emp.EAddress}");
                            }
                            else
                            {
                                Console.WriteLine($"No id found : {id}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Emp by id = {id} Not found / Error");
                        }
                            break;
                    default: Console.WriteLine("Wrong Choice.");
                        break;

                        
                }
                Console.WriteLine("Do you want to Continue y/n");
                string opChoice = Console.ReadLine();
                if (opChoice == "n")
                {
                    break;
                }
            }
        }
    }
}
