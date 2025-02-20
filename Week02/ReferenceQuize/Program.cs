using System;
using System.Collections.Generic;

class MyClass
{
    public int Value;
}

class Program
{
    static void ModifyValue(int x)
    {
        x = 50;
    }

    static void ModifyObject(MyClass obj)
    {
        obj.Value = 50;
    }

    static void Main()
    {
        // Scenario 1
        MyClass obj1 = new MyClass();
        obj1.Value = 10;
        MyClass obj2 = obj1;
        obj2.Value = 20;
        Console.WriteLine("Scenario 1: " + obj1.Value); // What is the output?

        // Scenario 2
        int a = 10;
        ModifyValue(a);
        Console.WriteLine("Scenario 2: " + a); // What is the output?

        // Scenario 3
        MyClass obj3 = new MyClass();
        obj3.Value = 10;
        MyClass obj4 = obj3;
        obj4.Value = 30;
        Console.WriteLine("Scenario 3: " + obj3.Value); // What is the output?

        // Scenario 4
        MyClass obj5 = new MyClass();
        obj5.Value = 10;
        obj5 = new MyClass();
        obj5.Value = 20;
        Console.WriteLine("Scenario 4: " + obj5.Value); // What is the output?

        // Scenario 5
        int b = 10;
        int c = b;
        c = 20;
        Console.WriteLine("Scenario 5: " + b); // What is the output?

        // Scenario 6
        MyClass obj6 = new MyClass();
        obj6.Value = 10;
        ModifyObject(obj6);
        Console.WriteLine("Scenario 6: " + obj6.Value); // What is the output?

        // Scenario 7
        MyClass obj7 = new MyClass();
        obj7.Value = 10;
        obj7 = null;
        // Attempting to access obj7.Value here would cause a NullReferenceException
        // Console.WriteLine("Scenario 7: " + obj7.Value);

        // Scenario 8
        List<MyClass> list = new List<MyClass>();
        list.Add(new MyClass { Value = 10 });
        list.Add(new MyClass { Value = 20 });
        list[0].Value = 30;
        Console.WriteLine("Scenario 8: " + list[0].Value); // What is the output?
        Console.WriteLine("Scenario 8: " + list[1].Value); // What is the output?
    }

    
}