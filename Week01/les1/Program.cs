static class Program
{
    static void Main()
    {
        // int amountOfStudents = 19;
        // long longNumber = 19L;
        // bool basecampPassed = true;
        // string nameOfClass = "inf1B";
        // char letter = 'B';
        
        // float grade = 8.5f;
        // double gradeD = 8.5;

        // Conversions();

        StringMethods();
    }

    private static void StringMethods()
    {
        string name = "Barld";

        name.ToUpper();
        name.ToLower();

        bool same = name == "barld"; // false
        same = name.ToUpper() == "barld".ToUpper(); // true
    
        name.Equals("barld", StringComparison.InvariantCultureIgnoreCase);

        Console.WriteLine("This is a \\n new line char");
    
    }

    private static void relationalOperators()
    {
        bool result = 5 < 2;
        result = 2 < 5;
        // result = 2 == "hoi";
        result = "hoi" != "dag";
    }

    private static void LogicalOperators()
    {
        bool result = true && true; // true
        result = true || false; // true
        result = !true; 
    }

    private static void Selection() 
    {
        if (true) 
        {
            // this is true
        } 
        else if (5 < 2)
        {
            // 5 is kleiner 2
        }
        else 
        {

        }
    }

    private static void Scope()
    {
        int a = 0;
        if (2 != 3)
        {
            a = 2;
        }
        Console.WriteLine(a);
    }

    private static void ternary()
    {
        int n = 42;
        var result = n == 42 ? "good answer" : "wrong";
    }

    static void Operators()
    {

        int sum = 2+2;
        double divide = 3/2.0;

        // -, %, *



        Console.WriteLine(divide);
    }

    // this is a comment
    /*
        this is a block
    */

    /// <summary>
    /// this is all about comments
    /// </summary>
    /// <param name="n">is the amount of comments</param>
    static void Comment(int n)
    {

    }


    static void stringsAndOutput()
    {
        string name = "Barld";
        string longString = "hoi ik heet" + name;
        string greeting = $"Hoi ik heet {name}";

        Console.WriteLine(greeting);
        Console.Write(greeting);
        Console.Write(greeting);
        
    }

    static void Read()
    {
        Console.WriteLine("are you happy");
        string areYouHappy = Console.ReadLine();
    }

    static void Conversions()
    {
        // string ageS = Console.ReadLine();

        // int age = int.Parse(ageS);
        // bool success = int.TryParse(ageS, out int ageI);
        // age = Convert.ToInt32(ageS);

        double grade = 9.8;
        int age = 30;
        int price = 1800;
        double priceSpecific = (double)price;
        double newPrice = priceSpecific * (1-age/100);

        int roundGrade = (int)grade;
        Console.WriteLine(roundGrade);
        roundGrade = Convert.ToInt32(grade);
        Console.WriteLine(roundGrade);

    }

    static void SwitchStatement()
    {
        int n = 42;

        switch(n)
        {
            case 1:
                Console.WriteLine("answer is 1");
                break;
            case 2 or 3 or 4:
                Console.WriteLine("answer is 2, 3 or 4");
                break;
            default:
                Console.WriteLine("wrong aswer");
                break;
        }
        int a = 2;
        string message = n switch {
            1 => "answer is 1",
            >1 and < 41 => $"answer is {n}",
            _ => "wrong answer"
        };
    }

}