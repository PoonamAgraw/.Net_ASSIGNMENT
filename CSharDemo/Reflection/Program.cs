//using System.Reflection;

//namespace Reflection
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string assemblyPath = @"C:\Users\IET\Desktop\250845920050\.Net\CSharDemo\MyMath\bin\Debug\net8.0\MyMath.dll";
//            Assembly asm = Assembly.LoadFrom(assemblyPath);
//                Type[] allTypes = asm.GetTypes();
//                for (int i = 0; i < allTypes.Length; i++)
//                {
//                    Type t = allTypes[i];

//                    object dynamicallyCreatedObject = asm.CreateInstance(t.FullName);

//                    string methodSignature = "";

//                    MethodInfo[] allmethods = t.GetMethods();
//                    for (int j = 0; j < allmethods.Length; j++)
//                    {
//                        MethodInfo method = allmethods[j];
//                        methodSignature = method.ReturnType.ToString() + "" + method.Name + "(";

//                        ParameterInfo[] allParameters = method.GetParameters();
//                        for (int k = 0; k < allParameters.Length; k++)
//                        {
//                            ParameterInfo parameter = allParameters[k];

//                            methodSignature = methodSignature + parameter.ParameterType.ToString() + " " + parameter.Name + ",";
//                        }

//                        object[] inputValues = new object[allParameters.Length];
//                        for (int p = 0; p < allParameters.Length; p++)
//                        {
//                            ParameterInfo para = allParameters[p];
//                            Console.WriteLine($"Enter value for {para.Name} of type ={para.ParameterType.ToString()}");

//                            inputValues[p] = Convert.ChangeType(Console.ReadLine(), para.ParameterType);

//                        }
//                        methodSignature = methodSignature.TrimEnd(',') + ")";
//                        Console.WriteLine(methodSignature);

//                        object? result = t.InvokeMember(
//                            method.Name,
//                             BindingFlags.Public |
//                             BindingFlags.Instance |
//                             BindingFlags.InvokeMethod,
//                              null,
//                              dynamicallyCreatedObject,
//                                inputValues
//                            );
//                        Console.WriteLine($"{method.Name}={result}");



                    

//                    }
//                }
//        }
//    }

//}
