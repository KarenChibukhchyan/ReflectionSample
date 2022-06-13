using System;

namespace ReflectedObject
{
    public class ReflectedClass
    {
        public int ReflectedProperty{get; set;}
        public void foo()
        {
            Console.WriteLine("Hello from reflected method");
        }

        public static void Main(string[] args)
        {

        }
    }
}