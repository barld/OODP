namespace les2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        FactoryCarBluePrint clioBLuePrint = new("Renault Clio", "red", 11.8, false);
        CarFactory clioFactory = new CarFactory(clioBLuePrint);
        Car clio1 = clioFactory.ProduceCar();

        // the clio factory has a field that contains a factory on its turn
        Console.WriteLine(clioFactory.BluePrint.Name);

        // what if we say we going to reuse the bluePrint of the clio
        FactoryCarBluePrint bmwBluePrint = clioBLuePrint;
        bmwBluePrint.Name = "BMW M3";
        bmwBluePrint.ZeroToHundred = 6.0;

        CarFactory bmwFactory = new CarFactory(bmwBluePrint);
        Car bmw1 = bmwFactory.ProduceCar();

        Car clio2 = clioFactory.ProduceCar();

        // dealing with null
        bmwFactory.BluePrint = null;
        // will produce error
        //bmwFactory.ProduceCar();
        HandleNull(null);

        CarParking parking = new CarParking { Cars = new List<Car> { clio1, clio2, bmw1 } };
    }

    public static void HandleNull(FactoryCarBluePrint print)
    {
        if (print is null)
        {
            throw new ArgumentNullException(nameof(print));
        }

        if (print is null)
        {
            print = new FactoryCarBluePrint("", "", 1.0, true);
        }

        print = print ?? new FactoryCarBluePrint("", "", 1.0, true);
        print = print ?? throw new ArgumentNullException(nameof(print));

        string? color = print?.Color;

        if (color is not null)
            color.ToUpper();
    }
}
