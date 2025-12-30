namespace _26Demo_FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\IET\Desktop\250845920050\.Net\CSharDemo\FileIO\File\demo1.txt";


            //FileStream fs = null;

            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            //}

            //StreamWriter writter = new StreamWriter(fs);
            //writter.WriteLine("Raju");
            //writter.Flush();
            //writter.Close();
            //fs.Close();
            //Console.WriteLine("Done.");


             //FileStream fs = null;

            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File not exist");
            //}
            //StreamReader streamReader = new StreamReader(fs);
            //string content = streamReader.ReadToEnd();
            //streamReader.Close();
            //fs.Close();
            //Console.WriteLine(content);

            Emp emp= new Emp();
            emp.Id = 1;
            emp.Name = "Raju";
            emp.Address = "Pune";

             FileStream fs = null;

            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            StreamWriter writter = new StreamWriter(fs);
            writter.WriteLine(emp);
            writter.Flush();
            writter.Close();
            fs.Close();
            Console.WriteLine("Done.");
        }
    }

    public class Emp
    {
        private int _Id;
        private string _Name;
        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

    }
}