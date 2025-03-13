
public static class Program
{
    // can not be declared in a static class
    // List<Pedestrian> pedestrians;

    public static void Main()
    {
        // veel gebruikte voorbeelden van static methodes
        Console.WriteLine("hello world");
        Math.Abs(-2);
        double.Parse("2.0");

        Random rand = new Random();
        List<Pedestrian> pedestrians = new List<Pedestrian>();
        for (int i = 0; i < 15; i++)
        {
            pedestrians.Add(new Pedestrian
            {
                CurrentSpeed = rand.NextDouble() * Pedestrian.MaxSpeed
            });
        }

        ConsoleUtilities.PrintTextInRed("Hello, World!");
    }

    //can not be declared in a static class
    // public void SavePedestrians(List<Pedestrian> pedestrians)
    // {
    //     this.pedestrians = pedestrians;
    // }
}
