using System;
using System.Reflection;

namespace Reflection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom("ReflectedObject.dll");
            Type reflectedObject = asm.GetType("ReflectedObject.ReflectedClass");
            object? obj = Activator.CreateInstance(reflectedObject);
            MethodInfo? foo = reflectedObject.GetMethod("foo");
            foo.Invoke(obj, null);

            PropertyInfo? ReflectedProperty = reflectedObject.GetProperty("ReflectedProperty");
            ReflectedProperty.SetValue(obj, 10);
            Console.WriteLine(ReflectedProperty.GetValue(obj));
        }
    }

}