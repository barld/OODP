

static class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the program");

        Car myCar = new Car("Renault Clio", "red", 7.0, false);
        Car bmw = new Car("BMW M3", "Black", 3.0, false);

        PrintInformation(myCar);
    }

    private static void PrintInformation(Car car)
    {
        Console.WriteLine(car.Color);
        Console.WriteLine(car.GetDescription());
    }
}
