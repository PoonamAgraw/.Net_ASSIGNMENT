namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter First Number");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                int n2 = Convert.ToInt32(Console.ReadLine());
                if (n2 == 0)
                {
                    throw new MyExceptionClass($"Do not write 0 for Second number");
                }
                int div = n1 / n2;
                Console.WriteLine($"Div Result {div}");

            }
            catch(MyExceptionClass obj)
            {
                Console.WriteLine(obj.Message);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine($"--{d.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("In Finally Block");
            }
        }
    }

    public class MyExceptionClass : Exception
    {
        public string Message { get; set; }
        public MyExceptionClass(string message)
        {
            Message = message;
        }
    }
}
