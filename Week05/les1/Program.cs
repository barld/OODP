// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<Shape> shapes = new () {
    new Circle(5),
    new Circle(3),
    new Squire(5)
};

foreach(Shape shape in shapes)
{
    if (shape is Circle)
    {
        Console.WriteLine("shape is a circle");
    }
    if (shape is Squire)
    {
        Console.WriteLine("shape is a squire");
    }

    Console.WriteLine($"The color of the shape is {shape.Color}");
}

double calculateSurfaceArea(Shape shape)
{
    if (shape is Circle)
    {
        return Math.PI * Math.Pow(((Circle)shape).Radius, 2);
    }
    else if (shape is Squire)
    {
        return Math.Pow(((Squire)shape).SideSize, 2);
    }
    else
    {
        throw new NotImplementedException("Unknown shape");
    }
}

double calculateSurfaceAreaShapeAs(Shape shape)
{
    if (shape is Circle)
    {
        return Math.PI * Math.Pow((shape as Circle).Radius, 2);
    }
    else if (shape is Squire)
    {
        return Math.Pow((shape as Squire).SideSize, 2);
    }
    else
    {
        throw new NotImplementedException("Unknown shape");
    }
}

int age = (int)12.0;

double calculateSurfaceAreaWithSwitchExpression(Shape shape)
{
    return shape switch
    {
        Circle c => Math.PI * Math.Pow(c.Radius, 2),
        Squire s => Math.Pow(s.SideSize, 2),
        _ => throw new NotImplementedException("Unknown shape")
    };

    {
        // Is the same as:
        if (shape is Circle c)
        {
            return Math.PI * Math.Pow(c.Radius, 2);
        }
        else if (shape is Squire s)
        {
            return Math.Pow(s.SideSize, 2);
        }
        else
        {
            throw new NotImplementedException("Unknown shape");
        }
    }
}

// calculate the surface area
foreach(Shape shape in shapes)
{
    Console.WriteLine(calculateSurfaceArea(shape));
    Console.WriteLine(calculateSurfaceAreaWithSwitchExpression(shape));
    Console.WriteLine(shape.GetSurfaceArea());
}

// print the shape objects
foreach(Shape shape in shapes)
{
    Console.WriteLine(shape);
}

object o = new Shape();


BankAccount myAccount = new BankAccount("Jan Jansen", 1000m);
myAccount.Deposit(500m);
myAccount.Withdraw(200m);

// Probeer toegang te krijgen tot het private veld (dit zal een fout veroorzaken)
// Console.WriteLine(myAccount.balance); // Niet toegestaan

// Probeer toegang te krijgen tot de private methode (dit zal een fout veroorzaken)
// Console.WriteLine(myAccount.GetBalance()); // Niet toegestaan

