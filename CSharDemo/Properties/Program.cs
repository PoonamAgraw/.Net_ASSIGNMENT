namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); 
            employee.Eid = 11;
            int id = employee.Eid;
            Console.WriteLine($"Employee Id {id}");
            employee.Ename = "Rahul";
            Console.WriteLine($"Employee Name {employee.Ename}");
            employee.EAddress = "Pune";
            Console.WriteLine($"Employee Name {employee.EAddress}");
        }
    }
    public class Employee
    {
        private int _Eid;
        private string _Ename;
        private string _EAddress;

        #region Getter and Setter 
        public int Eid
        {

            set
            {
                _Eid = value;
            }
            get
            {
                return _Eid;
            }
        }

        public string Ename
        {

            set
            {

                if (value != null)
                {
                    _Ename = "Mr/Miss" + value;
                }
                else
                {
                    _Ename = "Invalid format";
                }
            }
            get
            {
                return _Ename;
            }
        }

        public string EAddress
        {

            set
            {
                _EAddress = value;
            }
            get
            {
                return _EAddress;
            }
        }
        #endregion

        #region Getter and Setter old approach
        //public void set_Eid(int eid)
        //{
        //    _Eid = eid;
        //}

        //public int get_Eid()
        //{
        //    if (_Eid == 0)
        //    {
        //        return _Eid + 1;
        //    }
        //    else
        //    {
        //        return _Eid;
        //    }
        //} 
        #endregion
    }
}
