namespace Interface1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Callmysql.
            MySql m = new MySql();
            m.insert();
            m.delete();
            m.update();

            #endregion

            Console.WriteLine("Enter your Choice:   1.SQL   2.MYSQL   3.ORACLE");
            int dbChoice = Convert.ToInt32(Console.ReadLine());
            DatabaseFactory dbFactory = new DatabaseFactory();
            IDatabase database = dbFactory.GetSomeDatabase(dbChoice);
            Console.WriteLine("Enter your Choice:   1.DELETE   2.INSERT   3.UPDATE");
            int opChoice = Convert.ToInt32(Console.ReadLine());
            switch (opChoice)
            {
                case 1:
                    database.delete();  
                    break;
                case 2:
                    database.insert();  
                    break;
                case 3:
                    database.update();
                    break;
                default:
                    Console.WriteLine("Invalid Db operation Choice");
                    break;
            }

        }
    }
}
