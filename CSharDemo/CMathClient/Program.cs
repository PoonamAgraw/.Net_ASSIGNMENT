using CMathLib;

namespace CMathClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath cMathLib = new CMath();
            cMathLib.Add(10, 54);
            AdvCMath advCMath = new AdvCMath();
            advCMath.AdvWrapper();
            MyMath myMath = new MyMath();
            myMath.MyMathWrapper();
        }
    }
    public class MyMath : CMath
    {
        public void MyMathWrapper()
        {
            base.Mul(6, 4);
            base.Squ(4);
        }
        public void mul(int x,int y)
        {
            base.Mul(4, 7);
        }
    }
}
