// See https://aka.ms/new-console-template for more information
using W4_01;

Console.WriteLine("Hello, World!");

// method overloading
// meerdere methods met de zelfde naam maar met verschillende parameter signatures.
// waar hebben we dat al eerder gezien?

void exampleMethodOverloadingInFramework()
{
    Console.WriteLine();
    Console.WriteLine(0);
    Console.WriteLine(0.0);
    Console.WriteLine(true);
    Console.WriteLine("test");
    Console.WriteLine("With parameters {0}", 0);
    Console.WriteLine("With two parameters {0} {1}", 0, 1);
}

void methodOverloading()
{


    Vehicle vehicle = new Vehicle(2);

    vehicle = new Car(4);

    Car myCar = new Car(5);

    GasolineCar bmw = new(4);

    
}