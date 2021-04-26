using System.IO;
using System;

class class1
{
	static void Main()
	{
	    string str1;
        char[] arr1;
        Console.Write("\nReplace lowercase characters by uppercase and vice-versa :");
       Console.Write("\nInput the string : ");
       str1 = Console.ReadLine();
       Console.WriteLine(str1);
       arr1 = str1.ToCharArray();

        Console.Write("\nAfter conversion, the string is : ");
        for(int i=0; i < arr1.Length; i++)
         {
           if (Char.IsLower(arr1[i]))
              Console.Write(Char.ToUpper(arr1[i])); 
              else
              Console.Write(Char.ToLower(arr1[i]));
        }
    Console.ReadLine();    
   }
}