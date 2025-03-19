

public class Shape
{
    public string Color = "black";

    public virtual double GetSurfaceArea()
    {
        throw new NotImplementedException("Child has to implement this method");
    }

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


/// demo code
// public override string ToString()
// {
//     return $"Circle with radius {Radius}, and color {Color}";
// }

// public override string ToString()
// {
//     return $"Squire with side size {SideSize}, and color {Color}";
// }


//  public virtual double GetSurfaceArea()
//     {
//         throw new NotImplementedException("Child has to implement this method");
//     }

// public override double GetSurfaceArea()
//     {
//         return Math.PI * Math.Pow(Radius, 2);
//     }

//     public override double GetSurfaceArea()
//     {
//         return SideSize * SideSize;
//     }