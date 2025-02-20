using System;

namespace les2;

public class FactoryCarBluePrint
{
    public string Name;
    public string Color;
    public double ZeroToHundred;
    public bool IsElectric;

    public FactoryCarBluePrint(string name, string color, double zeroToHundred, bool isElectric)
    {
        this.Name = name;
        this.Color = color;
        this.ZeroToHundred = zeroToHundred;
        this.IsElectric = isElectric;
    }
}
