namespace Inheritance1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DerivedClass d = new DerivedClass();



            AdvanceMath ad = new AdvanceMath();
            Console.WriteLine(ad.add(34, 5)); ;
            ad.multi(4 , 7);
            ad.sub(8, 4);

        }
    }
}
