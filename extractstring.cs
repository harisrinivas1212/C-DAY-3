using System.IO;
using System;

class Program
{
    public static void Main()
    {
        string x = "it is a bad color";
        Console.WriteLine("string: " +x);
        string y = "is a";
        Console.WriteLine("string: " +y);
        if (x.Contains(y))
        {
            Console.WriteLine("substring 'is a' is present");
            
        }
        Console.ReadLine();
    }
}