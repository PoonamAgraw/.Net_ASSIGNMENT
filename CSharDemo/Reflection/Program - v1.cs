//using System.Reflection;

//namespace Reflection
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string assemblyPath = @"C:\Users\IET\Desktop\250845920050\.Net\CSharDemo\MyMath\bin\Debug\net8.0\MyMath.dll";
//            Assembly assembly = Assembly.LoadFrom(assemblyPath);
//            Type[] type = assembly.GetTypes();
//            for (int i = 0; i < type.Length; i++)
//            {
//                Type type1 = type[i];
//                Console.WriteLine(type1.FullName);
//                Console.WriteLine(type1.Name);
//                MethodInfo[] methods = type1.GetMethods();
//                for (int j = 0; j < methods.Length; j++) { 
//                    MethodInfo method = methods[j];
//                    Console.WriteLine($"Method Name : {method.Name} , Return Type ={method.ReturnType.ToString()}");
                
//                }
//            }


//        } 
//    }

//}
