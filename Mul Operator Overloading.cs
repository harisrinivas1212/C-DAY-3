using System.IO;
using System;

class class3
    {
       int a;
       int b;
       
       class3(int _a, int _b)
       {
       		a =_a;
            b =_b;
       }
       
       public static class3 operator * (class3 _obj1,class3 _obj2)
       {
       		class3 _obj3 = new class3(0,0);
            _obj3.a = _obj1.a * _obj2.a;
            _obj3.b = _obj1.b * _obj2.b;
            return _obj3;
            
       }
       
       public static void showvalues(class3 _obj)
       {
       		Console.WriteLine("a = " +_obj.a);
            Console.WriteLine("b = " +_obj.b);
       }
       public static void Main()
       {
         class3 obj1 = new class3(1,2);
         class3 obj2 = new class3(1,2);
          class3 obj3 = new class3(0,0);
          obj3 = obj1 * obj2;
          class3.showvalues(obj3);
          Console.ReadLine();
       }
    }