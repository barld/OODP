using System;

namespace Les02;

public abstract class Shape
{
    public string Color {get;}

    public bool IsDark()
    {
        return Color == "black";
    }

    public abstract double GetSurfaceArea();

}

public class Circle : Shape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetSurfaceArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override string ToString()
    {
        return $"Circle with radius {Radius}, and color {Color}";
    }
}

public class Squire : Shape
{
    public double SideSize;

    public Squire(double sideSize)
    {
        this.SideSize = sideSize;
    }

    public override double GetSurfaceArea()
    {
        return SideSize * SideSize;
    }

    public override string ToString()
    {
        return $"Squire with side size {SideSize}, and color {Color}";
    }
}
