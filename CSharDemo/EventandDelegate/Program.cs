namespace EventandDelegate
{
    public delegate void MyHandler(int mrk);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your marks:");
            Student student = new Student();
            student._Pass += new MyHandler(student.student_Pass);
            student._Fail += new MyHandler(student.student_Fail);
            student.Mark = Convert.ToInt32(Console.ReadLine());
           // student.TriggerEvents(student.Mark);


        }
    }
    public class Student
    {
        public event MyHandler _Pass;
        public event MyHandler _Fail;

        private int _Mark;

        public int Mark
        {
            set { 
                _Mark = value;
                if(_Mark > 40)
                {
                    _Pass(_Mark);
                }
                else
                {
                    _Fail.Invoke(_Mark);
                }
            }
            get {
                return _Mark;
            }
        }
        //public void TriggerEvents(int mrk) {
        //    if (mrk > 40)
        //    {
        //        _Pass(_Mark);
        //    }
        //    else
        //    {
        //        _Fail(_Mark);
        //    }
        //}
        public void student_Pass(int marks)
        {
            Console.WriteLine($"Congratualation you have pass the exam with {marks} marks");
        }
        public void student_Fail(int marks)
        {
            Console.WriteLine($"Congratualation you have fail the exam with {marks} marks");
        }
    }
}
