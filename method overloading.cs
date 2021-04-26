using System.IO;
using System;

class Program
    {
        static void Main(string[] args)
        {
            class1.sum();
            class1.sum(5,4);
            class1.sum(9.3f, 8.6f);
            class1.sum("Hari");
            Console.Read();
        }
    }
    static class class1
    {
        public static void sum()
        {
            Console.WriteLine("I am empty");
        }
        public static void sum(int x, int y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
        }
        public static void sum(float x, float y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
        }
        public static void sum(string s)
        {
            Console.WriteLine("{0} - is not a numeric value", s);
        }
    }