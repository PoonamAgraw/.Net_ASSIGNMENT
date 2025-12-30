namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Implicit implementation of interface IDrink
            //Drinks drink1 = new Drinks();
            //Console.WriteLine("Implicit implementation of interface IDrink");
            //drink1.Drink();
            #endregion

            #region  Implict implementation
            //Console.WriteLine("Enter Your Choice");
            //int choice = Convert.ToInt32(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        IDrink cold = new ColdDrink();
            //        cold.Drink();

            //        break;
            //    case 2:
            //        IDrink hot = new HotDrink();
            //        hot.Drink();

            //        break;
            //    default : Console.WriteLine("You are In Wrong Section");
            //        break;
            //}
            #endregion


            #region Explict implementation
            Console.WriteLine("Enter Your Choice 1.IX , 2.IY , 3.IDemo ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:  IX x = new Cmath();
                    Console.WriteLine(x.add(10, 20));
                    Console.WriteLine(x.sub(10, 20));
                    break;

                case 1:
                    IY y = new Cmath();
                    Console.WriteLine(y.add(10, 20));
                    Console.WriteLine(y.multi(10, 20));

                    break;

                case 2:
                    IDemo demo = new MyMath();
                    Console.WriteLine(demo.div(10, 20));
                    //Console.WriteLine(demo.log(Helllo));
                    break;


                default: Console.WriteLine("Wrong Choicee");
                    break;


            }


            #endregion
        }

    }
}
