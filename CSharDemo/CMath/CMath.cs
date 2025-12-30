namespace CMathLib
{
    public class CMath
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition is {x+y}");
        }

        private void Sub(int x, int y) {
            Console.WriteLine($"Subtraction is {x - y}");
        }
        protected void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication is {x *y}");
        }
        internal void Div(int x, int y)
        {
            Console.WriteLine($"Division is {x / y}");
        }
        protected internal void Squ(int x)
        {
            Console.WriteLine($"Square is {x * x}");
        }
       
    }
    public class AdvCMath : CMath
    {
        public void AdvWrapper()
        {
            base.Div(50,2);
            base.Mul(4, 7);
            base.Squ(5);

        }
    }
}
