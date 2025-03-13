using System;

namespace W4_01;

public class Vehicle
{
    public int Capacity;

    public Vehicle(int capacity)
    {
        Capacity = capacity;
    }

    public int GetMilage() => 10;
}

public class Bike : Vehicle
{
    public Bike() : base(1)
    {
    }
}

public class Car : Vehicle
{
    public bool Locked = false;

    public Car(int capacity) : base(capacity)
    {
        if (capacity < 2 || capacity > 8)
        {
            throw new ArgumentOutOfRangeException(nameof(capacity), "Cars should have a capacity between 2 and 8");
        }
    }

    

    public void LockDoors()
    {
        Console.WriteLine("The doors are locked");
        this.Locked = true;
    }

    public void UnlockDoors()
    {
        Console.WriteLine("The doors are open");
        this.Locked = false;
    }
}

public class GasolineCar : Car
{
    float EngineSize;
    public GasolineCar(int capacity) : base(capacity)
    {
    }
}

public class Bus : Vehicle
{
    public Bus() : base(60)
    {
    }
}
