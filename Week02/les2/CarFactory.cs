using System;

namespace les2;

public class CarFactory
{
    public FactoryCarBluePrint BluePrint;

    public CarFactory(FactoryCarBluePrint bluePrint)
    {
        BluePrint = bluePrint;
    }

    public Car ProduceCar()
    {
        return new Car(
            name: this.BluePrint.Name,
            color: this.BluePrint.Color,
            zeroToHundred: this.BluePrint.ZeroToHundred,
            isElectric: this.BluePrint.IsElectric
        );
    }
}
