// See https://aka.ms/new-console-template for more information


using System.Data;

Console.WriteLine("Hello, World!");

shuffle();

void SimpleWhile()
{
    Console.WriteLine("Give me a integer");
    bool isValid = false;
    while(!isValid)
    {
        if(int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine(n);
            isValid = true;
        }
        else
        {
            Console.WriteLine("please try again");
        }
    }

    bool q = false;
    do
    {
        Console.WriteLine("1) option 1");
        Console.WriteLine("2) option 2");
        Console.WriteLine("3) option 3");
        Console.WriteLine("4) quit");

        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
            case "2":
            case "3":
                break;
            case "4":
                q = true;
                break;
        }

        if (q)
        {
            break;
        }
    }
    while(!q);
}

void ForLoop()
{

    for (int j = 0; j < 20; j++)
    {
        Console.WriteLine(j);
    }

    // ==
    int i = 0;
    while (i < 20)
    {
        Console.WriteLine(i);
        i++;
    }

}


void ListExample()
{
    List<int> numbers = new List<int>();
    numbers.Add(1);
    numbers.Add(2);

    Console.Write( numbers.Count);

    numbers.Remove(2);
    
    numbers = new List<int>() {1, 2,3,4,5};

    List<string> strings = new List<string>();
    List<List<int>> ints2d = new List<List<int>>() {new List<int>()};

    foreach(int number in numbers)
    {
        Console.WriteLine(number);
    }

    numbers[1] = 1;
}

void DictionaryExample()
{
    Dictionary<string, double> grades = new Dictionary<string, double>{
        {"0911517", 6.0},
    };

    grades.Add("124424", 6.0);

    if (grades.ContainsKey("214342"))
    {
        Console.WriteLine(grades["214342"]);
        grades.TryGetValue("214342",out double n);

        grades["214342"] = 9.0;
    }


}

void normalRandom()
{
    Random rand = new Random();

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(rand.Next(100));
        Console.WriteLine(rand.NextDouble());
    }
}

void Random()
{
    Random rand = new Random(78);

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(rand.Next(100));
    }
}

void shuffle()
{
    int[] numbers = new int[]{1,2,3,4};

    Random rand = new Random();
    rand.Shuffle(numbers);

    foreach(int n in numbers)
    {
        Console.WriteLine(n);
    }
}