using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows for the half-diamond: ");
        if (!int.TryParse(Console.ReadLine(), out int n)) return;

      
        for (int i = 1; i <= n; i++)
        {

            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");

           
            Console.Write("*");

            
            for (int j = 1; j < (i - 1) * 2; j++)
                Console.Write(" ");

           
            if (i > 1) Console.Write("*");

            Console.WriteLine();
        }

        
        for (int i = n - 1; i >= 1; i--)
        {
      
            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");


            Console.Write("*");
            for (int j = 1; j < (i - 1) * 2; j++)
                Console.Write(" ");



            if (i > 1) Console.Write("*");

            Console.WriteLine();
        }
    }
}
