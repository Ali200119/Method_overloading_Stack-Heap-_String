using System;
namespace Heap_Stack
{
	public class Overloading
	{
        #region Method Overloading

        public static void Test()
        {
            Console.WriteLine("Hello World");
        }

        public static void Test(string n)
        {
            Console.WriteLine(n);
        }

        public static void Test(string n, int m)
        {
            Console.WriteLine($"{n} {m}");
        }

        #endregion
    }
}

