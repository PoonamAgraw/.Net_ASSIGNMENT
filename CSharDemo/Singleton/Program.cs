using System.Data;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter your Db choice. 1. SqlServer, 2. MySql Server, 3. Oracle Server");
                int dbChoice = Convert.ToInt32(Console.ReadLine());

                DataBaseFactory factory = new DataBaseFactory();
                Database someDatabaseObject = factory.GetSomeDatabase(dbChoice);
                Console.WriteLine("Enter db operation choice : 1. Insert, 2. Update, 3. Delete");
                int opChoice = Convert.ToInt32(Console.ReadLine());
                switch (opChoice)
                {
                    case 1:
                        someDatabaseObject.Insert();
                        break;
                    case 2:
                        someDatabaseObject.Update();
                        break;
                    case 3:
                        someDatabaseObject.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid Db operation Choice");
                        break;
                }

                Console.WriteLine("Do you want to continue? y/n");
                string ynChoice = Console.ReadLine();
                if (ynChoice == "n")
                {
                    break;
                }
            }

        }

    }
    public abstract class Database
    {
        public Logger _logger = null;
        public Database()
        {
            _logger = Logger.GetLogger();
        }
        protected abstract void DoInsert();
        protected abstract void DoUpdate();
        protected abstract void DoDelete();
        protected abstract String GetDataBaseName();
        public void Insert()
        {
            DoDelete();
            _logger.Log($"Insert from {GetDataBaseName()} done.");
        }
        public void Update()
        {
            DoDelete();
            _logger.Log($"Update from {GetDataBaseName()} done.");
        }
        public void Delete()
        {
            DoDelete();
            _logger.Log($"Delete from {GetDataBaseName()} done.");
        }

    }

    public class DataBaseFactory()
    {
        public Database GetSomeDatabase (int dbchoice)
        {
            Database db = null;
            switch (dbchoice) {
                case 1: db = new SqlServer();
                    break;
                case 2:
                    db = new MySqlServer();
                    break;
                case 3:
                    db = new OracleServer();
                    break;
                default: db = null;
                    break;
            }
            return db;
        }
    }

    public class SqlServer : Database
    {
        protected override string GetDataBaseName()
        {
            return "SqlServer";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("Record inserted in SqlServer ");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Record updated in SqlServer ");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Record deleted in SqlServer ");
        }
    }
    public class MySqlServer : Database
    {
        protected override string GetDataBaseName()
        {
            return "MySqlServer";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("Record inserted in MySqlServer ");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Record updated in MySqlServer ");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Record deleted in MySqlServer ");
        }
    }
    public class OracleServer : Database
    {
        protected override string GetDataBaseName()
        {
            return "OracleServer";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("Record inserted in OracleServer ");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Record updated in OracleServer ");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Record deleted in OracleServer ");
        }
    }
    public class Logger
    {
        public static readonly Logger _logger1 = new Logger();
        private Logger()
        {
            Console.WriteLine("Logger Object is created for the first time..");
        }

        public static Logger GetLogger() { 
                return _logger1;

        }
        public void Log(string message) {
            Console.WriteLine("Logg at {0} ,message{1}",DateTime.Now.ToString(),message);
        }
    }
}