namespace GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Emp emp1 = new Emp();
            emp1.Eid = 1;
            emp1.Ename = "Raju";
            emp1.Eadress = "Pune";

            Emp emp2 = new Emp();
            emp2.Eid = 2;
            emp2.Ename = "Pinky";
            emp2.Eadress = "Mumbai";

            Emp emp3 = new Emp();
            emp3.Eid = 3;
            emp3.Ename = "Soni";
            emp3.Eadress = "Nagpur";



            List<Emp> list = new List<Emp>();
            list.Add(emp1);
            list.Add(emp2);
            list.Add(emp3);

            foreach (var item in list)
            {
                Console.WriteLine($" Id : {item.Eid} , Name : {item.Ename} , Address : {item.Eadress}");
            }

            Dictionary<int,Emp> dic = new Dictionary<int,Emp>();
            dic.Add(emp1.Eid,emp1);
            dic.Add(emp2.Eid,emp2);
            dic.Add(emp3.Eid,emp3);

            foreach (KeyValuePair<int, Emp> element in dic) { 
                Emp emp = element.Value;
                Console.WriteLine($" Id : {emp.Eid} , Name : {emp.Ename} , Address : {emp.Eadress}");
        }
            foreach (int Key  in dic.Keys)
            {
                Emp emp = dic[Key] as Emp;
                Console.WriteLine($" Key = {Key} Id :  {emp.Eid} , Name : {emp.Ename} , Address : {emp.Eadress}");
        }

            foreach (Emp emp   in dic.Values)
            {
                Console.WriteLine($" Id : {emp.Eid} , Name : {emp.Ename} , Address : {emp.Eadress}");
            }
        }
    }
    public class Emp
    {
        private int _Eid;
        private string _Ename;
        private string _Eadress;

        public string Eadress
        {
            get { return _Eadress; }
            set { _Eadress = value; }
        }

        public string Ename
        {
            get { return _Ename; }
            set { _Ename = value; }
        }

        public int Eid
        {
            get { return _Eid; }
            set { _Eid = value; }
        }

    }
}
