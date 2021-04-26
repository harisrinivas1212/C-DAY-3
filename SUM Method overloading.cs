using System;

namespace Function_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Class1.sum(5,4);
            Class1.sum(9.3f, 8.6f);
      
            Console.Read();
        }
    }
    static class Class1
    {
        
        public static void sum(int x, int y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
        }
        public static void sum(float x, float y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
        }
        
    }
}