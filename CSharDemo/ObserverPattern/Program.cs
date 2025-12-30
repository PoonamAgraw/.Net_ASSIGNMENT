namespace ObserverPattern
{
    public delegate void NotifyEventHandler(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();


            publisher.Notify += subscriber.MethodA;
            publisher.Notify += subscriber.MethodB;

            publisher.NotifySubscribers("The grand sale is UP! upto 70% off on selected products!");

            publisher.Notify -= subscriber.MethodB;
            publisher.NotifySubscribers("Flash Sale! Extra 10% of Electronics ");


        }

    }
    
    public class Subscriber
    {
        public void MethodA(string message)
        {
            Console.WriteLine($"methoda received :{message} via sms");
        }
        public void MethodB(string message)
        {
            Console.WriteLine($"methodb received :{message} via Email");
        }
    }

    public class Publisher
    {
        public event NotifyEventHandler Notify;
        //public void TriggerEvents()
        //{
        //    Notify.Invoke( "Evnt Triggered!" );
        //}

        public void NotifySubscribers(string message)
        {
            Notify?.Invoke( message );
        }





    }

}
