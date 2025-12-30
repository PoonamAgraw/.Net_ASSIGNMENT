namespace MultiCastDelegate
{
    public delegate void MyHandler();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is Guest Arrived?(y/n)");
            string isGuestArrived = Console.ReadLine();
            CollegeAnnualEvent collegeAnnualEvent = new CollegeAnnualEvent();
            MyHandler handler = collegeAnnualEvent.Welcome;
            handler += collegeAnnualEvent.WelcomeSpeech;
            if(isGuestArrived == "y")
            {
                handler += collegeAnnualEvent.GuestSpeech;
            }
            else
            {
                handler -= collegeAnnualEvent.GuestSpeech;
            }
                handler += collegeAnnualEvent.Dance;
            handler += collegeAnnualEvent.Dinner;
            handler += collegeAnnualEvent.GoodByee;
            handler();
        }
    }

    public class CollegeAnnualEvent
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to Party!!");
        }
        public void WelcomeSpeech()
        {
            Console.WriteLine("Welcome !!");
        }
        public void GuestSpeech()
        {
            Console.WriteLine("Blah!!");
        }
        public void Dance()
        {
            Console.WriteLine("Wow!!");
        }
        public void Dinner()
        {
            Console.WriteLine("Delicious Dinner!!");
        }
        public void GoodByee()
        {
            Console.WriteLine("Good Bye!!");
        }

    }
}
