using System.Reflection;
using System.Runtime.Serialization;
using BVS;

namespace MyApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string asmPath = @"C:\Users\IET\Desktop\250845920050\.Net\CSharDemo\EmpLib\bin\Debug\net8.0\EmpLib.dll";
            Assembly asm = Assembly.LoadFrom(asmPath);
            Type[] types = asm.GetTypes();
            for (int i = 0; i < types.Length; i++) { 
                Type t = types[i];
                Attribute[] attributes = t.GetCustomAttributes().ToArray();
                for(int j=0; j<attributes.Length; j++)
                {
                    Attribute a = attributes[j];
                    if(a is BonaventureSystemsAttribute)
                    {
                        BonaventureSystemsAttribute bonaventure = a as BonaventureSystemsAttribute;
                        Console.WriteLine($"Class {t.Name}  is developed by {bonaventure.DeveloperName} of (c) {bonaventure.CompanyName}");
                    }
                    if( a is SerializableAttribute)
                    {
                        Console.WriteLine($"Class {t.Name}  is marked as serializable");
                    }
                }
            }
        }
    }
}
