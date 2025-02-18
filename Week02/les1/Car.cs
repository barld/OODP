public class Car
{
    public string Name;
    public string Color;
    public double ZeroToHundred;
    public bool IsElectric;

    public bool IsTuned = false;

    public Car(string name, string color, double zeroToHundred, bool isElectric)
    {
        this.Name = name;
        this.Color = color;
        this.ZeroToHundred = zeroToHundred;
        this.IsElectric = isElectric;
    }

    public void MakeSound()
    {
        if (!this.IsElectric)
        {
            Console.WriteLine("Vroem Vroem");
        }
        else
        {
            Console.WriteLine("Zoem zoem");
        }
    }

    public string GetDescription()
    {
        return $"name: {this.Name} color: {this.Color}";
    }

    public bool TuneCar(double faster)
    {
        if (IsTuned) {
            return false;
        }
        else
        {
            this.IsTuned = true;
            this.ZeroToHundred -= faster;
            return true;
        }

        return this.IsTuned;
    }

    public bool IsTunable() => !this.IsTuned;
}